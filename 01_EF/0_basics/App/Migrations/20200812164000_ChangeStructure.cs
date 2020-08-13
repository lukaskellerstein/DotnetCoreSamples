using Microsoft.EntityFrameworkCore.Migrations;
using System.Collections.Generic;
using System.Linq;

namespace EFGetStarted.Migrations
{
    public partial class ChangeStructure : Migration
    {

        List<LatencyMetric> LMArray = new List<LatencyMetric>();

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "TestRuns",
                type: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "LatencyMetrics",
                nullable: true,
                type: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Origin",
                table: "LatencyMetrics",
                nullable: true,
                type: "nvarchar(50)");

            migrationBuilder.AddColumn<string>(
                name: "Experience",
                table: "TestRuns",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Origin",
                table: "TestRuns",
                nullable: false,
                type: "nvarchar(50)",
                defaultValue: "TSW");

            migrationBuilder.AddColumn<string>(
                name: "Origin",
                table: "PullRequests",
                nullable: false,
                type: "nvarchar(50)",
                defaultValue: "TSW");

            migrationBuilder.AddColumn<string>(
                name: "Origin",
                table: "Builds",
                nullable: false,
                type: "nvarchar(50)",
                defaultValue: "TSW");


            migrationBuilder.DropForeignKey(
                name: "FK_LatencyMetrics_TestRuns_TestRunId",
                table: "LatencyMetrics");

            migrationBuilder.DropForeignKey(
                name: "FK_TestRuns_Builds_PullRequestBuildInfoId",
                table: "TestRuns");

            migrationBuilder.DropForeignKey(
                name: "FK_TestRuns_PullRequests_PullRequestId",
                table: "TestRuns");

            migrationBuilder.DropForeignKey(
                name: "FK_Builds_PullRequests_PullRequestId",
                table: "Builds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PullRequests",
                table: "PullRequests"
            );

            migrationBuilder.DropPrimaryKey(
                name: "PK_Builds",
                table: "Builds"
            );

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestRuns",
                table: "TestRuns"
            );


            migrationBuilder.AddPrimaryKey(
                "PK_PullRequests"
                , "PullRequests",
                new[] { "Id", "Origin" });

            migrationBuilder.AddPrimaryKey(
                "PK_Builds"
                , "Builds",
                new[] { "Id", "Origin" });

            migrationBuilder.AddPrimaryKey(
                "PK_TestRuns"
                , "TestRuns",
                new[] { "Id", "Origin", "Content" });



            // --------------------------------------------------------
            // --------------------------------------------------------
            // migrate data 
            // --------------------------------------------------------
            // --------------------------------------------------------


            // using (var context = new BloggingContext())
            // {


            //     this.LMArray = (from lm in context.LatencyMetrics
            //                     select lm).ToList();

            // }

            // using (var context = new BloggingContext())
            // {


            //     foreach (var itemLM in this.LMArray)
            //     {

            //         var trId = itemLM.TestRunId;

            //         var trItem = (from tr in context.TestRuns
            //                       where tr.Id == trId
            //                       select tr).FirstOrDefault();

            //         migrationBuilder.UpdateData(
            //             table: "LatencyMetrics",
            //             keyColumn: "Id",
            //             keyValue: itemLM.Id,
            //             column: "Origin",
            //             value: trItem.Origin);

            //         migrationBuilder.UpdateData(
            //             table: "LatencyMetrics",
            //             keyColumn: "Id",
            //             keyValue: itemLM.Id,
            //             column: "Content",
            //             value: trItem.Content);
            //     }
            // }





            migrationBuilder.AddForeignKey(
                name: "FK_LatencyMetrics_TestRuns",
                table: "LatencyMetrics",
                columns: new string[] { "TestRunId", "Origin", "Content" },
                principalTable: "TestRuns",
                principalColumns: new[] { "Id", "Origin", "Content" }
            );

            migrationBuilder.AddForeignKey(
                name: "FK_TestRuns_Builds",
                table: "TestRuns",
                columns: new string[] { "PullRequestBuildInfoId", "Origin" },
                principalTable: "Builds",
                principalColumns: new[] { "Id", "Origin" }
            );

            migrationBuilder.AddForeignKey(
                name: "FK_TestRuns_PullRequests",
                table: "TestRuns",
                columns: new string[] { "PullRequestId", "Origin" },
                principalTable: "PullRequests",
                principalColumns: new[] { "Id", "Origin" }
            );

            migrationBuilder.AddForeignKey(
                name: "FK_Builds_PullRequests_PullRequestId",
                table: "Builds",
                columns: new string[] { "PullRequestId", "Origin" },
                principalTable: "PullRequests",
                principalColumns: new[] { "Id", "Origin" }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropColumn(
            //     name: "Experience",
            //     table: "TestRuns");

            // migrationBuilder.DropColumn(
            //     name: "Origin",
            //     table: "TestRuns");

            // migrationBuilder.DropColumn(
            //     name: "Origin",
            //     table: "PullRequests");

            // migrationBuilder.DropColumn(
            //     name: "Origin",
            //     table: "Builds");
        }
    }
}
