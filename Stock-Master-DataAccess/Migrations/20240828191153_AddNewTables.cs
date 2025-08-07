using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_Master_DataAccess.Migrations
{
    public partial class AddNewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SM_CATEGORY",
                columns: table => new
                {
                    Item_Category_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item_Category_Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_CATEGORY", x => x.Item_Category_ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_PATIENT_DETAILS",
                columns: table => new
                {
                    Patient_Details_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patient_ID = table.Column<int>(type: "int", nullable: false),
                    Disease = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_PATIENT_DETAILS", x => x.Patient_Details_ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_PREFIX",
                columns: table => new
                {
                    Prefix_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prefix = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_PREFIX", x => x.Prefix_ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_SUPPLIERS",
                columns: table => new
                {
                    Supplier_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Supplier_Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Registration_No = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Contact_Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_SUPPLIERS", x => x.Supplier_ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_USER_TYPES",
                columns: table => new
                {
                    User_Type_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_USER_TYPES", x => x.User_Type_ID);
                });

            migrationBuilder.CreateTable(
                name: "SM_ITEMS",
                columns: table => new
                {
                    Item_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item_Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Item_Category_ID = table.Column<int>(type: "int", nullable: false),
                    Decription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    BulkId_Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Preorder_Level = table.Column<int>(type: "int", nullable: false),
                    SM_CATEGORYItem_Category_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_ITEMS", x => x.Item_ID);
                    table.ForeignKey(
                        name: "FK_SM_ITEMS_SM_CATEGORY_SM_CATEGORYItem_Category_ID",
                        column: x => x.SM_CATEGORYItem_Category_ID,
                        principalTable: "SM_CATEGORY",
                        principalColumn: "Item_Category_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SM_USER",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Middle_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Prefix_ID = table.Column<int>(type: "int", nullable: false),
                    User_Type_ID = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Username = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NIC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mobile_Number = table.Column<int>(type: "int", nullable: false),
                    User_Display_Number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    User_Display_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SM_PREFIXPrefix_ID = table.Column<int>(type: "int", nullable: false),
                    SM_USER_TYPESUser_Type_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_USER", x => x.User_ID);
                    table.ForeignKey(
                        name: "FK_SM_USER_SM_PREFIX_SM_PREFIXPrefix_ID",
                        column: x => x.SM_PREFIXPrefix_ID,
                        principalTable: "SM_PREFIX",
                        principalColumn: "Prefix_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_USER_SM_USER_TYPES_SM_USER_TYPESUser_Type_ID",
                        column: x => x.SM_USER_TYPESUser_Type_ID,
                        principalTable: "SM_USER_TYPES",
                        principalColumn: "User_Type_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SM_DOCTOR_DETAILS",
                columns: table => new
                {
                    Dr_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    REGISTATION_NO = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_DOCTOR_DETAILS", x => x.Dr_ID);
                    table.ForeignKey(
                        name: "FK_SM_DOCTOR_DETAILS_SM_USER_User_ID",
                        column: x => x.User_ID,
                        principalTable: "SM_USER",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SM_GRN",
                columns: table => new
                {
                    GRN_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Supplier_ID = table.Column<int>(type: "int", nullable: false),
                    Submit_By = table.Column<int>(type: "int", nullable: false),
                    Submit_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Received_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SM_SUPPLIERSSupplier_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_GRN", x => x.GRN_ID);
                    table.ForeignKey(
                        name: "FK_SM_GRN_SM_SUPPLIERS_SM_SUPPLIERSSupplier_ID",
                        column: x => x.SM_SUPPLIERSSupplier_ID,
                        principalTable: "SM_SUPPLIERS",
                        principalColumn: "Supplier_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_GRN_SM_USER_Submit_By",
                        column: x => x.Submit_By,
                        principalTable: "SM_USER",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SM_PATIENTS",
                columns: table => new
                {
                    Patient_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patient_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    NIC = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Custodians_NIC = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Mobile_Number = table.Column<int>(type: "int", nullable: false),
                    Requested_By = table.Column<int>(type: "int", nullable: false),
                    Requested_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_PATIENTS", x => x.Patient_ID);
                    table.ForeignKey(
                        name: "FK_SM_PATIENTS_SM_USER_Requested_By",
                        column: x => x.Requested_By,
                        principalTable: "SM_USER",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SM_STOCK_OUT",
                columns: table => new
                {
                    STOCK_OUT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    Inv_Details_ID = table.Column<int>(type: "int", nullable: false),
                    QTY = table.Column<int>(type: "int", nullable: false),
                    Requested_Reason = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Patient_ID = table.Column<int>(type: "int", nullable: false),
                    Requested_By = table.Column<int>(type: "int", nullable: false),
                    Requested_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_STOCK_OUT", x => x.STOCK_OUT_ID);
                    table.ForeignKey(
                        name: "FK_SM_STOCK_OUT_SM_USER_Requested_By",
                        column: x => x.Requested_By,
                        principalTable: "SM_USER",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SM_GRN_DETAILS",
                columns: table => new
                {
                    GRN_DETAILS_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GRN_ID = table.Column<int>(type: "int", nullable: false),
                    Item_ID = table.Column<int>(type: "int", nullable: false),
                    Number_Of_Bulk = table.Column<int>(type: "int", nullable: false),
                    Number_Of_Item_Per_Bulk = table.Column<int>(type: "int", nullable: false),
                    Number_Of_Separate_Item = table.Column<int>(type: "int", nullable: false),
                    Expiration_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SM_GRNGRN_ID = table.Column<int>(type: "int", nullable: false),
                    SM_ITEMSItem_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_GRN_DETAILS", x => x.GRN_DETAILS_ID);
                    table.ForeignKey(
                        name: "FK_SM_GRN_DETAILS_SM_GRN_SM_GRNGRN_ID",
                        column: x => x.SM_GRNGRN_ID,
                        principalTable: "SM_GRN",
                        principalColumn: "GRN_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_GRN_DETAILS_SM_ITEMS_SM_ITEMSItem_ID",
                        column: x => x.SM_ITEMSItem_ID,
                        principalTable: "SM_ITEMS",
                        principalColumn: "Item_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SM_INVENTORY",
                columns: table => new
                {
                    Inv_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item_ID = table.Column<int>(type: "int", nullable: false),
                    GRN_ID = table.Column<int>(type: "int", nullable: false),
                    QTY = table.Column<int>(type: "int", nullable: false),
                    Is_Bulk_Item = table.Column<bool>(type: "bit", nullable: false),
                    Bulk_MAINT_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Bulk_Serial_No = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SM_ITEMSItem_ID = table.Column<int>(type: "int", nullable: false),
                    SM_GRNGRN_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_INVENTORY", x => x.Inv_ID);
                    table.ForeignKey(
                        name: "FK_SM_INVENTORY_SM_GRN_SM_GRNGRN_ID",
                        column: x => x.SM_GRNGRN_ID,
                        principalTable: "SM_GRN",
                        principalColumn: "GRN_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_INVENTORY_SM_ITEMS_SM_ITEMSItem_ID",
                        column: x => x.SM_ITEMSItem_ID,
                        principalTable: "SM_ITEMS",
                        principalColumn: "Item_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SM_INVENTORY_DETAILS",
                columns: table => new
                {
                    Inv_Details_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inv_ID = table.Column<int>(type: "int", nullable: false),
                    Expiration_Date = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    Is_Expired = table.Column<bool>(type: "bit", maxLength: 50, nullable: false),
                    Serial_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Is_Used = table.Column<bool>(type: "bit", nullable: false),
                    Patient_ID = table.Column<int>(type: "int", nullable: false),
                    Used_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Used_By = table.Column<int>(type: "int", nullable: false),
                    Is_Lock = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_INVENTORY_DETAILS", x => x.Inv_Details_ID);
                    table.ForeignKey(
                        name: "FK_SM_INVENTORY_DETAILS_SM_INVENTORY_Inv_ID",
                        column: x => x.Inv_ID,
                        principalTable: "SM_INVENTORY",
                        principalColumn: "Inv_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SM_INVENTORY_DETAILS_SM_PATIENTS_Patient_ID",
                        column: x => x.Patient_ID,
                        principalTable: "SM_PATIENTS",
                        principalColumn: "Patient_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SM_INVENTORY_DETAILS_SM_USER_Used_By",
                        column: x => x.Used_By,
                        principalTable: "SM_USER",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SM_DOCTOR_DETAILS_User_ID",
                table: "SM_DOCTOR_DETAILS",
                column: "User_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SM_GRN_SM_SUPPLIERSSupplier_ID",
                table: "SM_GRN",
                column: "SM_SUPPLIERSSupplier_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_GRN_Submit_By",
                table: "SM_GRN",
                column: "Submit_By");

            migrationBuilder.CreateIndex(
                name: "IX_SM_GRN_DETAILS_SM_GRNGRN_ID",
                table: "SM_GRN_DETAILS",
                column: "SM_GRNGRN_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_GRN_DETAILS_SM_ITEMSItem_ID",
                table: "SM_GRN_DETAILS",
                column: "SM_ITEMSItem_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_INVENTORY_SM_GRNGRN_ID",
                table: "SM_INVENTORY",
                column: "SM_GRNGRN_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_INVENTORY_SM_ITEMSItem_ID",
                table: "SM_INVENTORY",
                column: "SM_ITEMSItem_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_INVENTORY_DETAILS_Inv_ID",
                table: "SM_INVENTORY_DETAILS",
                column: "Inv_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SM_INVENTORY_DETAILS_Patient_ID",
                table: "SM_INVENTORY_DETAILS",
                column: "Patient_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_INVENTORY_DETAILS_Used_By",
                table: "SM_INVENTORY_DETAILS",
                column: "Used_By");

            migrationBuilder.CreateIndex(
                name: "IX_SM_ITEMS_SM_CATEGORYItem_Category_ID",
                table: "SM_ITEMS",
                column: "SM_CATEGORYItem_Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_PATIENTS_Requested_By",
                table: "SM_PATIENTS",
                column: "Requested_By");

            migrationBuilder.CreateIndex(
                name: "IX_SM_STOCK_OUT_Requested_By",
                table: "SM_STOCK_OUT",
                column: "Requested_By");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_SM_PREFIXPrefix_ID",
                table: "SM_USER",
                column: "SM_PREFIXPrefix_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_USER_SM_USER_TYPESUser_Type_ID",
                table: "SM_USER",
                column: "SM_USER_TYPESUser_Type_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SM_DOCTOR_DETAILS");

            migrationBuilder.DropTable(
                name: "SM_GRN_DETAILS");

            migrationBuilder.DropTable(
                name: "SM_INVENTORY_DETAILS");

            migrationBuilder.DropTable(
                name: "SM_PATIENT_DETAILS");

            migrationBuilder.DropTable(
                name: "SM_STOCK_OUT");

            migrationBuilder.DropTable(
                name: "SM_INVENTORY");

            migrationBuilder.DropTable(
                name: "SM_PATIENTS");

            migrationBuilder.DropTable(
                name: "SM_GRN");

            migrationBuilder.DropTable(
                name: "SM_ITEMS");

            migrationBuilder.DropTable(
                name: "SM_SUPPLIERS");

            migrationBuilder.DropTable(
                name: "SM_USER");

            migrationBuilder.DropTable(
                name: "SM_CATEGORY");

            migrationBuilder.DropTable(
                name: "SM_PREFIX");

            migrationBuilder.DropTable(
                name: "SM_USER_TYPES");
        }
    }
}
