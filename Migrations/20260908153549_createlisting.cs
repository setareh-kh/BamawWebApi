using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace BamawWebApi.Migrations
{
    /// <inheritdoc />
    public partial class createlisting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trims_Generations_GenerationId",
                table: "Trims");

            migrationBuilder.DropTable(
                name: "Generations");

            migrationBuilder.RenameColumn(
                name: "GenerationId",
                table: "Trims",
                newName: "UsageTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Trims_GenerationId",
                table: "Trims",
                newName: "IX_Trims_UsageTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "VehicleModels",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BodyTypId",
                table: "Trims",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BodyTypeId",
                table: "Trims",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BodyConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    Name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyConditions", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BodyType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BodyType_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    Name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Locations_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ModelMarketPeriods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    VehicleModelId = table.Column<int>(type: "int", nullable: false),
                    MarketName = table.Column<string>(type: "longtext", nullable: false),
                    StartYear = table.Column<int>(type: "int", nullable: false),
                    EndYear = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelMarketPeriods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModelMarketPeriods_VehicleModels_VehicleModelId",
                        column: x => x.VehicleModelId,
                        principalTable: "VehicleModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    Name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    Name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UsageType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsageType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsageType_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MarketPeriodTrims",
                columns: table => new
                {
                    ModelMarketPeriodId = table.Column<int>(type: "int", nullable: false),
                    TrimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketPeriodTrims", x => new { x.ModelMarketPeriodId, x.TrimId });
                    table.ForeignKey(
                        name: "FK_MarketPeriodTrims_ModelMarketPeriods_ModelMarketPeriodId",
                        column: x => x.ModelMarketPeriodId,
                        principalTable: "ModelMarketPeriods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarketPeriodTrims_Trims_TrimId",
                        column: x => x.TrimId,
                        principalTable: "Trims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CarListings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    VehicleModelId = table.Column<int>(type: "int", nullable: false),
                    ProductionYear = table.Column<int>(type: "int", nullable: false),
                    TrimId = table.Column<int>(type: "int", nullable: true),
                    UsageStatus = table.Column<int>(type: "int", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: true),
                    DeliveryTime = table.Column<int>(type: "int", nullable: true),
                    ExteriorColorId = table.Column<int>(type: "int", nullable: false),
                    InteriorColorId = table.Column<int>(type: "int", nullable: true),
                    BodyConditionId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    PriceType = table.Column<int>(type: "int", nullable: false),
                    CashAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FirstDownPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SecondDownPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InstallmentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InstallmentCount = table.Column<int>(type: "int", nullable: true),
                    PaymentDue = table.Column<int>(type: "int", nullable: true),
                    DeliveryCarTime = table.Column<int>(type: "int", nullable: true),
                    FreeZonePlate = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Description = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    PackageId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarListings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarListings_BodyConditions_BodyConditionId",
                        column: x => x.BodyConditionId,
                        principalTable: "BodyConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarListings_Colors_ExteriorColorId",
                        column: x => x.ExteriorColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarListings_Colors_InteriorColorId",
                        column: x => x.InteriorColorId,
                        principalTable: "Colors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarListings_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarListings_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarListings_Trims_TrimId",
                        column: x => x.TrimId,
                        principalTable: "Trims",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarListings_VehicleModels_VehicleModelId",
                        column: x => x.VehicleModelId,
                        principalTable: "VehicleModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PackageOptions",
                columns: table => new
                {
                    PackageId = table.Column<int>(type: "int", nullable: false),
                    OptionId = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageOptions", x => new { x.PackageId, x.OptionId });
                    table.ForeignKey(
                        name: "FK_PackageOptions_Options_OptionId",
                        column: x => x.OptionId,
                        principalTable: "Options",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackageOptions_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ListingMedias",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CarListingId = table.Column<long>(type: "bigint", nullable: false),
                    MediaType = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListingMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListingMedias_CarListings_CarListingId",
                        column: x => x.CarListingId,
                        principalTable: "CarListings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Trims_BodyTypeId",
                table: "Trims",
                column: "BodyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyType_VehicleTypeId",
                table: "BodyType",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CarListings_BodyConditionId",
                table: "CarListings",
                column: "BodyConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_CarListings_ExteriorColorId",
                table: "CarListings",
                column: "ExteriorColorId");

            migrationBuilder.CreateIndex(
                name: "IX_CarListings_InteriorColorId",
                table: "CarListings",
                column: "InteriorColorId");

            migrationBuilder.CreateIndex(
                name: "IX_CarListings_LocationId",
                table: "CarListings",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_CarListings_PackageId",
                table: "CarListings",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_CarListings_TrimId",
                table: "CarListings",
                column: "TrimId");

            migrationBuilder.CreateIndex(
                name: "IX_CarListings_VehicleModelId",
                table: "CarListings",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ListingMedias_CarListingId",
                table: "ListingMedias",
                column: "CarListingId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ParentId",
                table: "Locations",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketPeriodTrims_TrimId",
                table: "MarketPeriodTrims",
                column: "TrimId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelMarketPeriods_VehicleModelId",
                table: "ModelMarketPeriods",
                column: "VehicleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageOptions_OptionId",
                table: "PackageOptions",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_UsageType_VehicleTypeId",
                table: "UsageType",
                column: "VehicleTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trims_BodyType_BodyTypeId",
                table: "Trims",
                column: "BodyTypeId",
                principalTable: "BodyType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trims_UsageType_UsageTypeId",
                table: "Trims",
                column: "UsageTypeId",
                principalTable: "UsageType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trims_BodyType_BodyTypeId",
                table: "Trims");

            migrationBuilder.DropForeignKey(
                name: "FK_Trims_UsageType_UsageTypeId",
                table: "Trims");

            migrationBuilder.DropTable(
                name: "BodyType");

            migrationBuilder.DropTable(
                name: "ListingMedias");

            migrationBuilder.DropTable(
                name: "MarketPeriodTrims");

            migrationBuilder.DropTable(
                name: "PackageOptions");

            migrationBuilder.DropTable(
                name: "UsageType");

            migrationBuilder.DropTable(
                name: "CarListings");

            migrationBuilder.DropTable(
                name: "ModelMarketPeriods");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "BodyConditions");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_Trims_BodyTypeId",
                table: "Trims");

            migrationBuilder.DropColumn(
                name: "BodyTypId",
                table: "Trims");

            migrationBuilder.DropColumn(
                name: "BodyTypeId",
                table: "Trims");

            migrationBuilder.RenameColumn(
                name: "UsageTypeId",
                table: "Trims",
                newName: "GenerationId");

            migrationBuilder.RenameIndex(
                name: "IX_Trims_UsageTypeId",
                table: "Trims",
                newName: "IX_Trims_GenerationId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "VehicleModels",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Generations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    VehicleModelId = table.Column<int>(type: "int", nullable: false),
                    EndYear = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    StartYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Generations_VehicleModels_VehicleModelId",
                        column: x => x.VehicleModelId,
                        principalTable: "VehicleModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Generations_VehicleModelId",
                table: "Generations",
                column: "VehicleModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trims_Generations_GenerationId",
                table: "Trims",
                column: "GenerationId",
                principalTable: "Generations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
