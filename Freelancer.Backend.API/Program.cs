using Freelancer.Backend.API.ExceptionHandling;
using Freelancer.Backend.API.Hubs;
using Freelancer.Backend.Business.Mapping;
using Freelancer.Backend.CompositionRoot;
using Freelancer.Backend.Infrastructure.Configurations;
using Freelancer.Backend.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.HttpOverrides;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("LocalDb");
builder.Services.AddServices(connectionString ?? throw new ArgumentNullException());

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
})
.AddCookie(options =>
{
    options.ExpireTimeSpan = TimeSpan.FromDays(1);
    options.SlidingExpiration = true;
    options.LoginPath = null;
    options.LogoutPath = null;
    options.Events.OnRedirectToLogin = context =>
    {
        context.Response.StatusCode = 401;
        return Task.CompletedTask;
    };
});

var policy = "_allowOrigin";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policy,
        policy =>
        {
            policy.WithOrigins("http://localhost:3000")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials();
        });
});

builder.Services.AddSignalR();

builder.Services.AddControllers();

builder.Host.UseSerilog((context, logConf) =>
{
    logConf
    .ReadFrom.Configuration(context.Configuration)
    .Enrich.FromLogContext()
    .WriteTo.Console();
});
builder.Services.AddAutoMapper(typeof(BusinessMappingProfile));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<StorageOptions>(builder.Configuration.GetSection(StorageOptions.ConfigKey));
builder.Services.Configure<EmailOptions>(builder.Configuration.GetSection(EmailOptions.ConfigKey));
builder.Services.AddHttpContextAccessor();

var app = builder.Build();

app.MapHub<ChatHub>("/api/chathub");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

app.UseMiddleware<CustomExceptionHandler>();

app.UseHttpsRedirection();

app.UseCors(policy);

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

InitializeDatabase(app);

app.Run();

void InitializeDatabase(WebApplication application)
{
    app.Services.GetRequiredService<IDbInitializer>().Initialize();
}
