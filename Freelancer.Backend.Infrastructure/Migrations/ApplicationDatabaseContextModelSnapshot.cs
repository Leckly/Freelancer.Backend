﻿// <auto-generated />
using System;
using Freelancer.Backend.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Freelancer.Backend.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDatabaseContext))]
    partial class ApplicationDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Freelancer.Backend.Domain.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Tags")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Job", (string)null);
                });

            modelBuilder.Entity("Freelancer.Backend.Domain.JobPhoto", b =>
                {
                    b.Property<int?>("JobId")
                        .HasColumnType("int");

                    b.Property<int?>("PhotoId")
                        .HasColumnType("int");

                    b.HasIndex("JobId");

                    b.HasIndex("PhotoId");

                    b.ToTable("JobPhoto", (string)null);
                });

            modelBuilder.Entity("Freelancer.Backend.Domain.JobsUser", b =>
                {
                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasIndex("JobId");

                    b.HasIndex("UserId");

                    b.ToTable("JobsUsers");
                });

            modelBuilder.Entity("Freelancer.Backend.Domain.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ContentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("JobId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.ToTable("Photo", (string)null);
                });

            modelBuilder.Entity("Freelancer.Backend.Domain.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<byte>("Rate")
                        .HasColumnType("tinyint");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Rating", (string)null);
                });

            modelBuilder.Entity("Freelancer.Backend.Domain.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.HasKey("Id");

                    b.ToTable("Role", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Employee"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Employeer"
                        });
                });

            modelBuilder.Entity("Freelancer.Backend.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CompanyName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Country")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Description")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Krs")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("KRS");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nip")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("NIP");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("PhotoId")
                        .HasColumnType("int");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Tags")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PhotoId");

                    b.HasIndex("RoleId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Freelancer.Backend.Domain.UserJob", b =>
                {
                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasIndex("JobId");

                    b.HasIndex("UserId");

                    b.ToTable("UserJobs");
                });

            modelBuilder.Entity("JobUser", b =>
                {
                    b.Property<int>("JobUsersId")
                        .HasColumnType("int");

                    b.Property<int>("JobsUserId")
                        .HasColumnType("int");

                    b.HasKey("JobUsersId", "JobsUserId");

                    b.HasIndex("JobsUserId");

                    b.ToTable("JobUser");
                });

            modelBuilder.Entity("Freelancer.Backend.Domain.Job", b =>
                {
                    b.HasOne("Freelancer.Backend.Domain.User", "User")
                        .WithMany("Jobs")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Job__UserId__02084FDA");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Freelancer.Backend.Domain.JobPhoto", b =>
                {
                    b.HasOne("Freelancer.Backend.Domain.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .HasConstraintName("FK__JobPhoto__JobId__07C12930");

                    b.HasOne("Freelancer.Backend.Domain.Photo", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId")
                        .HasConstraintName("FK__JobPhoto__PhotoI__08B54D69");

                    b.Navigation("Job");

                    b.Navigation("Photo");
                });

            modelBuilder.Entity("Freelancer.Backend.Domain.JobsUser", b =>
                {
                    b.HasOne("Freelancer.Backend.Domain.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .IsRequired()
                        .HasConstraintName("FK__JobsUsers__JobId__05D8E0BE");

                    b.HasOne("Freelancer.Backend.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__JobsUsers__UserI__04E4BC85");

                    b.Navigation("Job");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Freelancer.Backend.Domain.Photo", b =>
                {
                    b.HasOne("Freelancer.Backend.Domain.Job", null)
                        .WithMany("JobPhotos")
                        .HasForeignKey("JobId");
                });

            modelBuilder.Entity("Freelancer.Backend.Domain.Rating", b =>
                {
                    b.HasOne("Freelancer.Backend.Domain.User", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Rating__UserId__06CD04F7");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Freelancer.Backend.Domain.User", b =>
                {
                    b.HasOne("Freelancer.Backend.Domain.Photo", "Photo")
                        .WithMany("Users")
                        .HasForeignKey("PhotoId")
                        .HasConstraintName("FK__User__PhotoId__7F2BE32F");

                    b.HasOne("Freelancer.Backend.Domain.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK__User__RoleId__7E37BEF6");

                    b.Navigation("Photo");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Freelancer.Backend.Domain.UserJob", b =>
                {
                    b.HasOne("Freelancer.Backend.Domain.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .IsRequired()
                        .HasConstraintName("FK__UserJobs__JobId__03F0984C");

                    b.HasOne("Freelancer.Backend.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__UserJobs__UserId__02FC7413");

                    b.Navigation("Job");

                    b.Navigation("User");
                });

            modelBuilder.Entity("JobUser", b =>
                {
                    b.HasOne("Freelancer.Backend.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("JobUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Freelancer.Backend.Domain.Job", null)
                        .WithMany()
                        .HasForeignKey("JobsUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Freelancer.Backend.Domain.Job", b =>
                {
                    b.Navigation("JobPhotos");
                });

            modelBuilder.Entity("Freelancer.Backend.Domain.Photo", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Freelancer.Backend.Domain.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Freelancer.Backend.Domain.User", b =>
                {
                    b.Navigation("Jobs");

                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
