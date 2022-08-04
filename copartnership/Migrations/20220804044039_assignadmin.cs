using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace copartnership.Migrations
{
    public partial class assignadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[AspNetUserRoles] (UserId, RoleId) SELECT '0b5476f9-4835-4f11-bd61-cc5dd29d399f', Id FROM [dbo].[AspNetRoles]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [dbo].AspNetUserRoles WHERE UserId = '0b5476f9-4835-4f11-bd61-cc5dd29d399f'");
        }
    }
}
