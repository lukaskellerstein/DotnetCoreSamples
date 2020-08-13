using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace App
{
    public class BloggingContext : DbContext
    {
        public DbSet<PullRequest> PullRequests { get; set; }
        public DbSet<PullRequestBuildInfo> Builds { get; set; }
        public DbSet<TestRun> TestRuns { get; set; }
        public DbSet<LatencyMetric> LatencyMetrics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data Source=localhost;Initial Catalog=EFTest;User Id=sa;Password=Master_1234;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PullRequest>().Property(pr => pr.Id).ValueGeneratedNever();
            modelBuilder.Entity<PullRequestBuildInfo>().Property(pr => pr.Id).ValueGeneratedNever();
            modelBuilder.Entity<TestRun>().Property(run => run.Id).ValueGeneratedNever();

            var testRunsProperty = modelBuilder.Entity<PullRequestBuildInfo>()
                .Metadata.FindNavigation(nameof(PullRequestBuildInfo.TestRuns));
            testRunsProperty.SetPropertyAccessMode(PropertyAccessMode.Field);

            var latencyMetricsProperty = modelBuilder.Entity<TestRun>()
                .Metadata.FindNavigation(nameof(TestRun.LatencyMetrics));
            latencyMetricsProperty.SetPropertyAccessMode(PropertyAccessMode.Field);
        }
    }

    public class PullRequest
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public string Origin { get; set; }

        public List<PullRequestBuildInfo> Builds { get; set; } = new List<PullRequestBuildInfo>();
    }

    public class PullRequestBuildInfo
    {
        public long Id { get; set; }
        public string ContainerName { get; set; }

        public string Origin { get; set; }

        public PullRequest PullRequest { get; set; }

        public List<TestRun> TestRuns { get; set; } = new List<TestRun>();
    }

    public class TestRun
    {
        public long Id { get; set; }

        public long BuildId { get; set; }
        public string Content { get; set; }

        public string Origin { get; set; }

        public string Experience { get; set; }

        public PullRequest PullRequest { get; set; }

        public List<LatencyMetric> LatencyMetrics { get; set; } = new List<LatencyMetric>();
        // and other metrics
    }


    public class LatencyMetric
    {
        public long Id { get; set; }
        public double Percentile { get; set; }

        public long TestRunId { get; set; }

        public string Origin { get; set; }
        public string Content { get; set; }
    }


}