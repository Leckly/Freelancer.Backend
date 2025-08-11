namespace Freelancer.Backend.Infrastructure.Configurations;

public class EmailOptions
{
    public const string ConfigKey = "EmailConfiguration";
    public string EmailFrom { get; set; }
    public string EmailTo { get; set; }
    public int SMTPPort { get; set; }
    public string SMTPHost { get; set; }
    public string SMTPUsername { get; set; }
    public string SMTPPassword { get; set; }
}
