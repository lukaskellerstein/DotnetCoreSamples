using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using App.Model;

namespace App
{
    class Program
    {
        static void Main()
        {
            List<KustoDataObj> MockedData = new List<KustoDataObj>();
            MockedData.Add(new KustoDataObj(112, "Pull Request 112", 1, 1, "Test run 1", 0.5));
            MockedData.Add(new KustoDataObj(112, "Pull Request 112", 1, 1, "Test run 2", 0.2));
            MockedData.Add(new KustoDataObj(112, "Pull Request 112", 2, 2, "Test run 1", 0.6));
            MockedData.Add(new KustoDataObj(112, "Pull Request 112", 2, 2, "Test run 2", 0.3));
            MockedData.Add(new KustoDataObj(113, "Pull Request 113", 3, 3, "Test run 3", 0.1));
            MockedData.Add(new KustoDataObj(114, "Pull Request 114", 4, 4, "Test run 4", 0.7));
            MockedData.Add(new KustoDataObj(114, "Pull Request 114", 5, 5, "Test run 5", 0.3));

            using (var db = new BloggingContext())
            {

                foreach (var row in MockedData)
                {
                    long id = row.PrId;
                    PullRequest pr = db.PullRequests.Find(id);
                    if (pr == null)
                    {
                        pr = new PullRequest()
                        {
                            Id = id,
                            Title = row.PrTitle
                        };

                        db.PullRequests.Add(pr);
                    }

                    long buildId = row.BuildId;
                    PullRequestBuildInfo prBuild = db.Builds.Find(buildId);
                    if (prBuild == null)
                    {
                        prBuild = new PullRequestBuildInfo()
                        {
                            Id = buildId,
                            TestRuns = new List<TestRun>(),
                            PullRequest = pr
                        };

                        db.Builds.Add(prBuild);
                    }

                    long testRunId = row.TrId;
                    TestRun testRun = db.TestRuns.Find(testRunId);
                    if (testRun == null)
                    {
                        testRun = new TestRun()
                        {
                            Id = testRunId,
                            BuildId = testRunId,
                            Content = row.TrContent,
                            PullRequest = pr
                        };

                        db.TestRuns.Add(testRun);
                    }

                    var metric = new LatencyMetric()
                    {
                        Percentile = row.Percentile
                    };
                    testRun.LatencyMetrics.Add(metric);
                    prBuild.TestRuns.Add(testRun);

                    db.SaveChanges();
                }
            }
        }
    }
}