using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SummerInternRegistration.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Intern",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PREFIX = table.Column<string>(nullable: true),
                    FNAME = table.Column<string>(nullable: true),
                    PMNAME = table.Column<string>(nullable: true),
                    LNAME = table.Column<string>(nullable: true),
                    SUFFIX = table.Column<string>(nullable: true),
                    EMAIL1 = table.Column<string>(nullable: true),
                    MOBILE = table.Column<string>(nullable: true),
                    MAJOR = table.Column<string>(nullable: true),
                    CLASSIFICATION = table.Column<string>(nullable: true),
                    GPA = table.Column<string>(nullable: true),
                    COLLEGECREDIT = table.Column<string>(nullable: true),
                    SEMESTERTERM = table.Column<string>(nullable: true),
                    SEMESTERYEAR = table.Column<string>(nullable: true),
                    ACADEMICCREDITSEMESTER = table.Column<string>(nullable: true),
                    ACADEMICCREDITYEAR = table.Column<string>(nullable: true),
                    COLLEGEGRADUATIONSEMESTER = table.Column<string>(nullable: true),
                    COLLEGEGRADUATIONYEAR = table.Column<string>(nullable: true),
                    FNAMEPROF = table.Column<string>(nullable: true),
                    LNAMEPROF = table.Column<string>(nullable: true),
                    PREFEREDSITE = table.Column<string>(nullable: true),
                    DRUGSCREEN = table.Column<string>(nullable: true),
                    BACKGROUNDCHECK = table.Column<string>(nullable: true),
                    FIRSTEXPERIENCE = table.Column<string>(nullable: true),
                    LOCATIONOUTSIDEGA = table.Column<string>(nullable: true),
                    LOCATIONLODGING = table.Column<string>(nullable: true),
                    INTERNSHIPPREP = table.Column<string>(nullable: true),
                    EDITOR = table.Column<string>(nullable: true),
                    NOTES = table.Column<decimal>(nullable: false),
                    TIMESTAMP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intern", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Intern");
        }
    }
}
