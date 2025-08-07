using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_Master_DataAccess.Migrations
{
    public partial class modifyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SM_USER_SM_PREFIX_SM_PREFIXPrefix_ID",
                table: "SM_USER");

            migrationBuilder.DropForeignKey(
                name: "FK_SM_USER_SM_USER_TYPES_SM_USER_TYPESUser_Type_ID",
                table: "SM_USER");

            migrationBuilder.DropIndex(
                name: "IX_SM_USER_SM_PREFIXPrefix_ID",
                table: "SM_USER");

            migrationBuilder.DropIndex(
                name: "IX_SM_USER_SM_USER_TYPESUser_Type_ID",
                table: "SM_USER");

            migrationBuilder.DropColumn(
                name: "SM_PREFIXPrefix_ID",
                table: "SM_USER");

            migrationBuilder.DropColumn(
                name: "SM_USER_TYPESUser_Type_ID",
                table: "SM_USER");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_Prefix_ID",
                table: "SM_USER",
                column: "Prefix_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_User_Type_ID",
                table: "SM_USER",
                column: "User_Type_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SM_USER_SM_PREFIX_Prefix_ID",
                table: "SM_USER",
                column: "Prefix_ID",
                principalTable: "SM_PREFIX",
                principalColumn: "Prefix_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SM_USER_SM_USER_TYPES_User_Type_ID",
                table: "SM_USER",
                column: "User_Type_ID",
                principalTable: "SM_USER_TYPES",
                principalColumn: "User_Type_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SM_USER_SM_PREFIX_Prefix_ID",
                table: "SM_USER");

            migrationBuilder.DropForeignKey(
                name: "FK_SM_USER_SM_USER_TYPES_User_Type_ID",
                table: "SM_USER");

            migrationBuilder.DropIndex(
                name: "IX_SM_USER_Prefix_ID",
                table: "SM_USER");

            migrationBuilder.DropIndex(
                name: "IX_SM_USER_User_Type_ID",
                table: "SM_USER");

            migrationBuilder.AddColumn<int>(
                name: "SM_PREFIXPrefix_ID",
                table: "SM_USER",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SM_USER_TYPESUser_Type_ID",
                table: "SM_USER",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_SM_PREFIXPrefix_ID",
                table: "SM_USER",
                column: "SM_PREFIXPrefix_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_SM_USER_TYPESUser_Type_ID",
                table: "SM_USER",
                column: "SM_USER_TYPESUser_Type_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SM_USER_SM_PREFIX_SM_PREFIXPrefix_ID",
                table: "SM_USER",
                column: "SM_PREFIXPrefix_ID",
                principalTable: "SM_PREFIX",
                principalColumn: "Prefix_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SM_USER_SM_USER_TYPES_SM_USER_TYPESUser_Type_ID",
                table: "SM_USER",
                column: "SM_USER_TYPESUser_Type_ID",
                principalTable: "SM_USER_TYPES",
                principalColumn: "User_Type_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
