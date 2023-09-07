using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [Role] ([Name]) VALUES ('Admin')");
            migrationBuilder.Sql("INSERT INTO [Role] ([Name]) VALUES ('Manager')");
            migrationBuilder.Sql("INSERT INTO [Role] ([Name]) VALUES ('Team Lead')");

            migrationBuilder.Sql("INSERT INTO [User] ([UserName], [FullName]) VALUES ('Mohit_Sharma', 'Mohit Sharma')");
            migrationBuilder.Sql("INSERT INTO [User] ([UserName], [FullName]) VALUES ('Stiv_Smith', 'Stive Smith')");

            migrationBuilder.Sql("INSERT INTO [UserRole]  ([RoleId], [UserId]) VALUES (1, 1)");
            migrationBuilder.Sql("INSERT INTO [UserRole] ([RoleId], [UserId]) VALUES (3, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
