using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace copartnership.Migrations
{
    public partial class addadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'0b5476f9-4835-4f11-bd61-cc5dd29d399f', N'فيصل', N'العتيبي', N'fv99xz@hotmail.com', N'FV99XZ@HOTMAIL.COM', N'fv99xz@hotmail.com', N'FV99XZ@HOTMAIL.COM', 0, N'AQAAAAEAACcQAAAAEKtd22xm5XZmodXqxzCHnRpy4s4fnEJnHLteLoarvcxdsumq53esoxIsVPA2KQdw6A==', N'MHPTMHKKWSZ4YJLOWKNI3QDTC3CNX3FY', N'c99748da-464d-477f-ad3b-066493b12b44', NULL, 0, 0, NULL, 1, 0)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [dbo].[AspNetUsers] WHERE Id = '0b5476f9-4835-4f11-bd61-cc5dd29d399f' ");
        }
    }
}
