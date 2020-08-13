using Microsoft.EntityFrameworkCore.Migrations;
using System.Collections.Generic;
using System.Linq;
namespace EFGetStarted.Migrations
{
    public partial class ChangeStructure2 : Migration
    {

        List<LatencyMetric> LMArray = new List<LatencyMetric>();

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // --------------------------------------------------------
            // --------------------------------------------------------
            // migrate data 
            // --------------------------------------------------------
            // --------------------------------------------------------


            using (var context = new BloggingContext())
            {


                this.LMArray = (from lm in context.LatencyMetrics
                                select lm).ToList();

            }

            using (var context = new BloggingContext())
            {


                foreach (var itemLM in this.LMArray)
                {

                    var trId = itemLM.TestRunId;

                    var trItem = (from tr in context.TestRuns
                                  where tr.Id == trId
                                  select tr).FirstOrDefault();

                    migrationBuilder.UpdateData(
                        table: "LatencyMetrics",
                        keyColumn: "Id",
                        keyValue: itemLM.Id,
                        column: "Origin",
                        value: trItem.Origin);

                    migrationBuilder.UpdateData(
                        table: "LatencyMetrics",
                        keyColumn: "Id",
                        keyValue: itemLM.Id,
                        column: "Content",
                        value: trItem.Content);
                }
            }

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
