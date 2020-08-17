﻿// <auto-generated />
using System;
using App.Model2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Migrations.BloggingContext2Migrations
{
    [DbContext(typeof(BloggingContext2))]
    [Migration("20200817140454_NewStructure")]
    partial class NewStructure
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("App.Model2.LatencyMetric", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Percentile")
                        .HasColumnType("float");

                    b.Property<long>("TestRunId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TestRunId");

                    b.ToTable("LatencyMetrics");
                });

            modelBuilder.Entity("App.Model2.PullRequest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PullRequests");
                });

            modelBuilder.Entity("App.Model2.PullRequestBuildInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContainerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PullRequestId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PullRequestId");

                    b.ToTable("Builds");
                });

            modelBuilder.Entity("App.Model2.TestRun", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BuildId")
                        .HasColumnType("bigint");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PullRequestBuildInfoId")
                        .HasColumnType("bigint");

                    b.Property<long?>("PullRequestId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PullRequestBuildInfoId");

                    b.HasIndex("PullRequestId");

                    b.ToTable("TestRuns");
                });

            modelBuilder.Entity("App.Model2.LatencyMetric", b =>
                {
                    b.HasOne("App.Model2.TestRun", null)
                        .WithMany("LatencyMetrics")
                        .HasForeignKey("TestRunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("App.Model2.PullRequestBuildInfo", b =>
                {
                    b.HasOne("App.Model2.PullRequest", "PullRequest")
                        .WithMany("Builds")
                        .HasForeignKey("PullRequestId");
                });

            modelBuilder.Entity("App.Model2.TestRun", b =>
                {
                    b.HasOne("App.Model2.PullRequestBuildInfo", null)
                        .WithMany("TestRuns")
                        .HasForeignKey("PullRequestBuildInfoId");

                    b.HasOne("App.Model2.PullRequest", "PullRequest")
                        .WithMany()
                        .HasForeignKey("PullRequestId");
                });
#pragma warning restore 612, 618
        }
    }
}