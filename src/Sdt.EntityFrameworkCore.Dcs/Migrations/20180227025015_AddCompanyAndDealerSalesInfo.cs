using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sdt.Dcs.Migrations
{
    public partial class AddCompanyAndDealerSalesInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BusinessAddress = table.Column<string>(maxLength: 200, nullable: true),
                    BusinessScope = table.Column<string>(maxLength: 200, nullable: true),
                    CityCategory = table.Column<string>(maxLength: 100, nullable: true),
                    CityName = table.Column<string>(maxLength: 50, nullable: true),
                    Code = table.Column<string>(maxLength: 50, nullable: false),
                    ContactAddress = table.Column<string>(maxLength: 200, nullable: true),
                    ContactMail = table.Column<string>(maxLength: 100, nullable: true),
                    ContactPerson = table.Column<string>(maxLength: 100, nullable: true),
                    ContactPhone = table.Column<string>(maxLength: 100, nullable: true),
                    ContactPostCode = table.Column<string>(maxLength: 100, nullable: true),
                    CorporateNature = table.Column<int>(nullable: true),
                    CountyName = table.Column<string>(maxLength: 50, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorName = table.Column<string>(maxLength: 100, nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DcsCompanyType = table.Column<int>(nullable: false),
                    DealerId = table.Column<int>(nullable: true),
                    Fax = table.Column<string>(maxLength: 100, nullable: true),
                    FoundDate = table.Column<DateTime>(nullable: true),
                    IdDocumentNumber = table.Column<string>(maxLength: 100, nullable: true),
                    IdDocumentType = table.Column<int>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LegalRepresentative = table.Column<string>(maxLength: 100, nullable: true),
                    ModifierName = table.Column<string>(maxLength: 100, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    ProvinceName = table.Column<string>(maxLength: 50, nullable: true),
                    RegionId = table.Column<int>(nullable: true),
                    RegisterCapital = table.Column<decimal>(type: "decimal(19, 4)", nullable: true),
                    RegisterCode = table.Column<string>(maxLength: 50, nullable: true),
                    RegisterDate = table.Column<DateTime>(nullable: true),
                    RegisterName = table.Column<string>(maxLength: 100, nullable: true),
                    Remark = table.Column<string>(maxLength: 200, nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    ShortName = table.Column<string>(maxLength: 50, nullable: true),
                    Status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_Dealer_DealerId",
                        column: x => x.DealerId,
                        principalTable: "Dealer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DealerSalesInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    BranchId = table.Column<int>(nullable: false),
                    CancellationTime = table.Column<DateTime>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorName = table.Column<string>(maxLength: 100, nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DealerId = table.Column<int>(nullable: false),
                    DegradeTime = table.Column<DateTime>(nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    ErpServiceCode = table.Column<string>(maxLength: 50, nullable: true),
                    Fax = table.Column<string>(maxLength: 50, nullable: true),
                    GroupName = table.Column<string>(maxLength: 100, nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    ModifierName = table.Column<string>(maxLength: 100, nullable: true),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
                    SalesHotline = table.Column<string>(maxLength: 100, nullable: true),
                    ShopLevel = table.Column<string>(maxLength: 100, nullable: true),
                    ShopProperty = table.Column<string>(maxLength: 100, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    SubscriptionTime = table.Column<DateTime>(nullable: true),
                    ZipCode = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealerSalesInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DealerSalesInfo_Dealer_DealerId",
                        column: x => x.DealerId,
                        principalTable: "Dealer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DealerSalesInfoHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    BranchId = table.Column<int>(nullable: false),
                    CancellationTime = table.Column<DateTime>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorName = table.Column<string>(maxLength: 100, nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DealerId = table.Column<int>(nullable: false),
                    DealerSalesInfoId = table.Column<int>(nullable: true),
                    DegradeTime = table.Column<DateTime>(nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Fax = table.Column<string>(maxLength: 50, nullable: true),
                    FileTime = table.Column<DateTime>(nullable: true),
                    FilerId = table.Column<int>(nullable: true),
                    FilerName = table.Column<string>(maxLength: 100, nullable: true),
                    GroupName = table.Column<string>(maxLength: 100, nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    ModifierName = table.Column<string>(maxLength: 100, nullable: true),
                    RecordId = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(maxLength: 500, nullable: true),
                    SalesHotline = table.Column<string>(maxLength: 100, nullable: true),
                    ShopLevel = table.Column<string>(maxLength: 100, nullable: true),
                    ShopProperty = table.Column<string>(maxLength: 100, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    SubscriptionTime = table.Column<DateTime>(nullable: true),
                    ZipCode = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealerSalesInfoHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DealerSalesInfoHistory_DealerSalesInfo_DealerSalesInfoId",
                        column: x => x.DealerSalesInfoId,
                        principalTable: "DealerSalesInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Company_DealerId",
                table: "Company",
                column: "DealerId",
                unique: true,
                filter: "[DealerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DealerSalesInfo_DealerId",
                table: "DealerSalesInfo",
                column: "DealerId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerSalesInfoHistory_DealerSalesInfoId",
                table: "DealerSalesInfoHistory",
                column: "DealerSalesInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "DealerSalesInfoHistory");

            migrationBuilder.DropTable(
                name: "DealerSalesInfo");
        }
    }
}
