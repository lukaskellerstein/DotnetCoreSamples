using Microsoft.EntityFrameworkCore.Migrations;

namespace EFGetStarted.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PullRequests",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PullRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Builds",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    ContainerName = table.Column<string>(nullable: true),
                    PullRequestId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Builds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Builds_PullRequests_PullRequestId",
                        column: x => x.PullRequestId,
                        principalTable: "PullRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TestRuns",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    BuildId = table.Column<long>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    PullRequestId = table.Column<long>(nullable: true),
                    PullRequestBuildInfoId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestRuns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestRuns_Builds_PullRequestBuildInfoId",
                        column: x => x.PullRequestBuildInfoId,
                        principalTable: "Builds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TestRuns_PullRequests_PullRequestId",
                        column: x => x.PullRequestId,
                        principalTable: "PullRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LatencyMetrics",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Percentile = table.Column<double>(nullable: false),
                    TestRunId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LatencyMetrics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LatencyMetrics_TestRuns_TestRunId",
                        column: x => x.TestRunId,
                        principalTable: "TestRuns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Builds_PullRequestId",
                table: "Builds",
                column: "PullRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_LatencyMetrics_TestRunId",
                table: "LatencyMetrics",
                column: "TestRunId");

            migrationBuilder.CreateIndex(
                name: "IX_TestRuns_PullRequestBuildInfoId",
                table: "TestRuns",
                column: "PullRequestBuildInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_TestRuns_PullRequestId",
                table: "TestRuns",
                column: "PullRequestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LatencyMetrics");

            migrationBuilder.DropTable(
                name: "TestRuns");

            migrationBuilder.DropTable(
                name: "Builds");

            migrationBuilder.DropTable(
                name: "PullRequests");
        }
    }
}
