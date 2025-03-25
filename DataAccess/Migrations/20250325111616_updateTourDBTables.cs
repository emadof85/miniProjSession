using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class updateTourDBTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentTransactions_PaymentMethods_PaymentMethodId",
                table: "PaymentTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentTransactions_Payments_PaymentId",
                table: "PaymentTransactions");

            migrationBuilder.DropIndex(
                name: "IX_PaymentTransactions_PaymentId",
                table: "PaymentTransactions");

            migrationBuilder.RenameColumn(
                name: "PaymentMethodId",
                table: "PaymentTransactions",
                newName: "paymentMethodId");

            migrationBuilder.RenameColumn(
                name: "PaymentId",
                table: "PaymentTransactions",
                newName: "paymentId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentTransactions_PaymentMethodId",
                table: "PaymentTransactions",
                newName: "IX_PaymentTransactions_paymentMethodId");

            migrationBuilder.AlterColumn<int>(
                name: "paymentMethodId",
                table: "PaymentTransactions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "paymentId",
                table: "PaymentTransactions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<string>(type: "char(12)", nullable: false),
                    whatsapp = table.Column<string>(type: "char(14)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    hireDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTransactions_paymentId_paymentMethodId_transactionDate",
                table: "PaymentTransactions",
                columns: new[] { "paymentId", "paymentMethodId", "transactionDate" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentTransactions_PaymentMethods_paymentMethodId",
                table: "PaymentTransactions",
                column: "paymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentTransactions_Payments_paymentId",
                table: "PaymentTransactions",
                column: "paymentId",
                principalTable: "Payments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentTransactions_PaymentMethods_paymentMethodId",
                table: "PaymentTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentTransactions_Payments_paymentId",
                table: "PaymentTransactions");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_PaymentTransactions_paymentId_paymentMethodId_transactionDate",
                table: "PaymentTransactions");

            migrationBuilder.RenameColumn(
                name: "paymentMethodId",
                table: "PaymentTransactions",
                newName: "PaymentMethodId");

            migrationBuilder.RenameColumn(
                name: "paymentId",
                table: "PaymentTransactions",
                newName: "PaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentTransactions_paymentMethodId",
                table: "PaymentTransactions",
                newName: "IX_PaymentTransactions_PaymentMethodId");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentMethodId",
                table: "PaymentTransactions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentId",
                table: "PaymentTransactions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTransactions_PaymentId",
                table: "PaymentTransactions",
                column: "PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentTransactions_PaymentMethods_PaymentMethodId",
                table: "PaymentTransactions",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentTransactions_Payments_PaymentId",
                table: "PaymentTransactions",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "id");
        }
    }
}
