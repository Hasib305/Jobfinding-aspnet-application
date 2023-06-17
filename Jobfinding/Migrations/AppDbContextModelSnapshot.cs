﻿// <auto-generated />
using System;
using Jobfinding.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jobfinding.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Jobfinding.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Jobfinding.Models.Findjobs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Enddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobCategory")
                        .HasColumnType("int");

                    b.Property<int>("JobsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<DateTime>("Startdate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("JobsId");

                    b.ToTable("Findjobs");
                });

            modelBuilder.Entity("Jobfinding.Models.Jobs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("Jobfinding.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Jobfinding.Models.question_ans", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Ans")
                        .HasColumnType("int");

                    b.Property<int>("FindjobsId")
                        .HasColumnType("int");

                    b.Property<string>("Opt_1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opt_2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opt_3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opt_4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FindjobsId");

                    b.ToTable("question_anss");
                });

            modelBuilder.Entity("Jobfinding.Models.skills_findingjobs", b =>
                {
                    b.Property<int>("FindjobsId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("FindjobsId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("skills_Findingjobs");
                });

            modelBuilder.Entity("Jobfinding.Models.Findjobs", b =>
                {
                    b.HasOne("Jobfinding.Models.Company", "Company")
                        .WithMany("findjobs")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jobfinding.Models.Jobs", "Jobs")
                        .WithMany("Findjobs")
                        .HasForeignKey("JobsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("Jobfinding.Models.question_ans", b =>
                {
                    b.HasOne("Jobfinding.Models.Findjobs", "Findjobs")
                        .WithMany("question_ans")
                        .HasForeignKey("FindjobsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Findjobs");
                });

            modelBuilder.Entity("Jobfinding.Models.skills_findingjobs", b =>
                {
                    b.HasOne("Jobfinding.Models.Findjobs", "Findjobs")
                        .WithMany("skills_Findingjobs")
                        .HasForeignKey("FindjobsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Jobfinding.Models.Skill", "Skill")
                        .WithMany("skills_Findingjobs")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Findjobs");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("Jobfinding.Models.Company", b =>
                {
                    b.Navigation("findjobs");
                });

            modelBuilder.Entity("Jobfinding.Models.Findjobs", b =>
                {
                    b.Navigation("question_ans");

                    b.Navigation("skills_Findingjobs");
                });

            modelBuilder.Entity("Jobfinding.Models.Jobs", b =>
                {
                    b.Navigation("Findjobs");
                });

            modelBuilder.Entity("Jobfinding.Models.Skill", b =>
                {
                    b.Navigation("skills_Findingjobs");
                });
#pragma warning restore 612, 618
        }
    }
}
