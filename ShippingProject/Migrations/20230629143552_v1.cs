using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShippingProject.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Governates",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Type_Of_Paids",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_Of_Paids", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Type_Of_Shippings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_Of_Shippings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Regular_Shipping = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Id_Governate = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Governates_Id_Governate",
                        column: x => x.Id_Governate,
                        principalTable: "Governates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Id_city = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branches_Cities_Id_city",
                        column: x => x.Id_city,
                        principalTable: "Cities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Id_Branch = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employees_Branches_Id_Branch",
                        column: x => x.Id_Branch,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "representives",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type_of_discount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    company_percantage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Branch = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id_Governate = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_representives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_representives_Branches_Id_Branch",
                        column: x => x.Id_Branch,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_representives_Governates_Id_Governate",
                        column: x => x.Id_Governate,
                        principalTable: "Governates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Traders",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Per_Rejected_order = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Id_City = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id_Branch = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id_Governate = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Traders_Branches_Id_Branch",
                        column: x => x.Id_Branch,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Traders_Cities_Id_City",
                        column: x => x.Id_City,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Traders_Governates_Id_Governate",
                        column: x => x.Id_Governate,
                        principalTable: "Governates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id_Order = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address_trader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone_trader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_Status = table.Column<bool>(type: "bit", nullable: false),
                    Client_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total_weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    oreder_salary_from_trader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    flag_of_villagee = table.Column<bool>(type: "bit", nullable: false),
                    Village_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Id_City = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Id_Branch = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Id_Governate = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_type_paid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Id_Type_Shipping = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Id_representive = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id_Order);
                    table.ForeignKey(
                        name: "FK_Orders_Branches_Id_Branch",
                        column: x => x.Id_Branch,
                        principalTable: "Branches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Cities_Id_City",
                        column: x => x.Id_City,
                        principalTable: "Cities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Governates_Id_Governate",
                        column: x => x.Id_Governate,
                        principalTable: "Governates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Type_Of_Paids_Id_type_paid",
                        column: x => x.Id_type_paid,
                        principalTable: "Type_Of_Paids",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Type_Of_Shippings_Id_Type_Shipping",
                        column: x => x.Id_Type_Shipping,
                        principalTable: "Type_Of_Shippings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_representives_Id_representive",
                        column: x => x.Id_representive,
                        principalTable: "representives",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Special_Price_Traders",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Id_Trader = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Id_city = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id_Governate = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Special_Price_Traders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Special_Price_Traders_Cities_Id_city",
                        column: x => x.Id_city,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Special_Price_Traders_Governates_Id_Governate",
                        column: x => x.Id_Governate,
                        principalTable: "Governates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Special_Price_Traders_Traders_Id_Trader",
                        column: x => x.Id_Trader,
                        principalTable: "Traders",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Employee_Orders",
                columns: table => new
                {
                    Id_employee = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id_Order = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Orders", x => new { x.Id_employee, x.Id_Order });
                    table.ForeignKey(
                        name: "FK_Employee_Orders_Employees_Id_employee",
                        column: x => x.Id_employee,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Employee_Orders_Orders_Id_Order",
                        column: x => x.Id_Order,
                        principalTable: "Orders",
                        principalColumn: "Id_Order",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Order = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    orderId_Order = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Orders_orderId_Order",
                        column: x => x.orderId_Order,
                        principalTable: "Orders",
                        principalColumn: "Id_Order");
                });

            migrationBuilder.CreateTable(
                name: "Setting_shippings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    village_shipping = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    regular_shipping = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    order_id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting_shippings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Setting_shippings_Orders_order_id",
                        column: x => x.order_id,
                        principalTable: "Orders",
                        principalColumn: "Id_Order",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Setting_Weights",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    weight_shipping = table.Column<double>(type: "float", nullable: false),
                    Extra_weight = table.Column<double>(type: "float", nullable: false),
                    order_id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting_Weights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Setting_Weights_Orders_order_id",
                        column: x => x.order_id,
                        principalTable: "Orders",
                        principalColumn: "Id_Order",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branches_Id_city",
                table: "Branches",
                column: "Id_city");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Id_Governate",
                table: "Cities",
                column: "Id_Governate");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Orders_Id_Order",
                table: "Employee_Orders",
                column: "Id_Order");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Id_Branch",
                table: "Employees",
                column: "Id_Branch");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Id_Branch",
                table: "Orders",
                column: "Id_Branch",
                unique: true,
                filter: "[Id_Branch] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Id_City",
                table: "Orders",
                column: "Id_City",
                unique: true,
                filter: "[Id_City] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Id_Governate",
                table: "Orders",
                column: "Id_Governate",
                unique: true,
                filter: "[Id_Governate] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Id_representive",
                table: "Orders",
                column: "Id_representive");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Id_type_paid",
                table: "Orders",
                column: "Id_type_paid",
                unique: true,
                filter: "[Id_type_paid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Id_Type_Shipping",
                table: "Orders",
                column: "Id_Type_Shipping",
                unique: true,
                filter: "[Id_Type_Shipping] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_orderId_Order",
                table: "Products",
                column: "orderId_Order");

            migrationBuilder.CreateIndex(
                name: "IX_representives_Id_Branch",
                table: "representives",
                column: "Id_Branch");

            migrationBuilder.CreateIndex(
                name: "IX_representives_Id_Governate",
                table: "representives",
                column: "Id_Governate");

            migrationBuilder.CreateIndex(
                name: "IX_Setting_shippings_order_id",
                table: "Setting_shippings",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_Setting_Weights_order_id",
                table: "Setting_Weights",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_Special_Price_Traders_Id_city",
                table: "Special_Price_Traders",
                column: "Id_city");

            migrationBuilder.CreateIndex(
                name: "IX_Special_Price_Traders_Id_Governate",
                table: "Special_Price_Traders",
                column: "Id_Governate");

            migrationBuilder.CreateIndex(
                name: "IX_Special_Price_Traders_Id_Trader",
                table: "Special_Price_Traders",
                column: "Id_Trader");

            migrationBuilder.CreateIndex(
                name: "IX_Traders_Id_Branch",
                table: "Traders",
                column: "Id_Branch");

            migrationBuilder.CreateIndex(
                name: "IX_Traders_Id_City",
                table: "Traders",
                column: "Id_City");

            migrationBuilder.CreateIndex(
                name: "IX_Traders_Id_Governate",
                table: "Traders",
                column: "Id_Governate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee_Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Setting_shippings");

            migrationBuilder.DropTable(
                name: "Setting_Weights");

            migrationBuilder.DropTable(
                name: "Special_Price_Traders");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Traders");

            migrationBuilder.DropTable(
                name: "Type_Of_Paids");

            migrationBuilder.DropTable(
                name: "Type_Of_Shippings");

            migrationBuilder.DropTable(
                name: "representives");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Governates");
        }
    }
}
