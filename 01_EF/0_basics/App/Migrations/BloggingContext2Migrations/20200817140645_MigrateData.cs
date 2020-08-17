
using Microsoft.EntityFrameworkCore.Migrations;

using App.Model;

using App.Model2;

using System.Linq;
using System.Collections.Generic;

namespace App.Migrations.BloggingContext2Migrations
{
    public partial class MigrateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            var LMArray = new List<Model.LatencyMetric>();
            var PRArray = new List<Model.PullRequest>();

            using (var context = new BloggingContext())
            {


                // LMArray = (from lm in context.LatencyMetrics
                //            select lm).ToList();

                PRArray = (from lm in context.PullRequests
                           select lm).ToList();

            }


            using (var context = new BloggingContext2())
            {


                // foreach (var item in LMArray)
                // {

                //     var temp = new Model2.LatencyMetric();
                //     temp.Percentile = item.Percentile;
                //     temp.TestRunId = item.TestRunId;

                //     context.Add(temp);
                // }

                foreach (var item in PRArray)
                {

                    var temp = new Model2.PullRequest
                    {
                        Author = item.Author,
                        Origin = "TSW",
                        Title = item.Title
                    };

                    context.Add(temp);
                }

                context.SaveChanges();

            }



        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Origin",
                table: "PullRequests");
        }
    }
}
