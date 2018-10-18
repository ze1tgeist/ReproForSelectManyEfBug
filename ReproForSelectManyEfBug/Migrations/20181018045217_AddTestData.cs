using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReproForSelectManyEfBug.Migrations
{
    [DbContext(typeof(ReproDbContext))]
    [Migration("20181018045217_AddTestData")]
    public partial class AddTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Parents", "Name", "Parent With No Children");
            migrationBuilder.InsertData("Parents", "Name", "Parent With One Child");
            migrationBuilder.InsertData("Parents", "Name", "Parent With Two Children");

            var childColumns = new string[] { "Name", "ParentId" };
            migrationBuilder.InsertData("Children", childColumns, new object[] { "Only Child of Parent With One Child", 2 });
            migrationBuilder.InsertData("Children", childColumns, new object[] { "First Child of Parent With Two Children", 3 });
            migrationBuilder.InsertData("Children", childColumns, new object[] { "Second Child of Parent With Two Children", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
