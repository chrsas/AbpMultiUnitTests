using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sdt.Dcs.Migrations
{
    public partial class Update_Company_And_Dealer_RelationShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Dealer_DealerId",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Company_DealerId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "DealerId",
                table: "Company");

            migrationBuilder.AddColumn<int>("Id2", "Dealer", nullable: true);

            migrationBuilder.Sql("Update Dealer Set Id2 = Id");

            migrationBuilder.DropForeignKey("FK_DealerSalesInfo_Dealer_DealerId", "DealerSalesInfo");

            migrationBuilder.DropPrimaryKey("PK_Dealer", "Dealer");

            migrationBuilder.DropColumn("Id", "Dealer");

            migrationBuilder.RenameColumn("Id2", "Dealer", "Id");

            migrationBuilder.AlterColumn<int>("Id", "Dealer", nullable: false, oldNullable: true);

            migrationBuilder.AddPrimaryKey("PK_Dealer", "Dealer", "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Dealer_Company_Id",
            //    table: "Dealer",
            //    column: "Id",
            //    principalTable: "Company",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dealer_Company_Id",
                table: "Dealer");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Dealer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "DealerId",
                table: "Company",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Company_DealerId",
                table: "Company",
                column: "DealerId",
                unique: true,
                filter: "[DealerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Dealer_DealerId",
                table: "Company",
                column: "DealerId",
                principalTable: "Dealer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
