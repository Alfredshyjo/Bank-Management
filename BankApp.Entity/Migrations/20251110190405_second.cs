using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BankApp.Entity.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e9291b8-9ea9-4c73-84fb-4b89a0fe5ea5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd744f1a-fd81-4aa4-adc3-0f0e8defef53");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "15e2e88c-d62e-40d0-a8a1-bca8bf39ba31", "b0d991ed-c128-49ad-9f4e-1200b42f0c6e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15e2e88c-d62e-40d0-a8a1-bca8bf39ba31");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0d991ed-c128-49ad-9f4e-1200b42f0c6e");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "tblCustomers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "tblCustomers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "tblCustomers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AccountTypeID",
                table: "tblCustomerApplication",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "tblCustomerApplication",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "tblCustomerApplication",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "tblAccounts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.Sql(@"
        UPDATE tblCustomers 
        SET MobileNumber = CONCAT('TEMP', CAST(CustomerID AS NVARCHAR(10)))
        WHERE MobileNumber = '' OR MobileNumber IS NULL;
    ");

            migrationBuilder.Sql(@"
        UPDATE tblCustomers 
        SET AadharNumber = CONCAT('TEMP', CAST(CustomerID AS NVARCHAR(12)))
        WHERE AadharNumber = '' OR AadharNumber IS NULL;
    ");

            migrationBuilder.Sql(@"
        UPDATE tblCustomers 
        SET PAN = CONCAT('TEMP', CAST(CustomerID AS NVARCHAR(10)))
        WHERE PAN = '' OR PAN IS NULL;
    ");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4f62de41-0d8a-4250-8def-ab419b82c68b", null, "Customer", "CUSTOMER" },
                    { "57eef7fb-2593-480d-ad2c-e2936841d08b", null, "Manager", "MANAGER" },
                    { "dabb5fc5-f4cb-4034-bada-93c422d25e19", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedDate", "MustChangePassword", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e76c8da-4d87-40c9-8312-0ab04ea4c4b2", 0, "078db933-266f-4821-96bc-ce05d4f5c304", "System", new DateTime(2025, 11, 11, 0, 34, 3, 193, DateTimeKind.Local).AddTicks(4204), null, null, "admin@bankapp.com", true, "System Administrator", true, false, false, null, null, null, false, "ADMIN@BANKAPP.COM", "ADMIN", "AQAAAAIAAYagAAAAEFIQI/hIxDhQXA/o3YLmfIM4BIy9HN6M4CVfWkxML+/JGp4imE9A7s7ZtKFTeYObQw==", null, false, "5003be49-df13-458a-a1a9-c4ed97f0d65c", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dabb5fc5-f4cb-4034-bada-93c422d25e19", "8e76c8da-4d87-40c9-8312-0ab04ea4c4b2" });

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomers_AadharNumber",
                table: "tblCustomers",
                column: "AadharNumber",
                unique: true,
                filter: "[IsDeleted]=0");

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomers_MobileNumber",
                table: "tblCustomers",
                column: "MobileNumber",
                unique: true,
                filter: "[IsDeleted]=0");

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomers_PAN",
                table: "tblCustomers",
                column: "PAN",
                unique: true,
                filter: "[IsDeleted]=0");

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomerApplication_AadharNumber",
                table: "tblCustomerApplication",
                column: "AadharNumber");

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomerApplication_MobileNumber",
                table: "tblCustomerApplication",
                column: "MobileNumber");

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomerApplication_PAN",
                table: "tblCustomerApplication",
                column: "PAN");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tblCustomers_AadharNumber",
                table: "tblCustomers");

            migrationBuilder.DropIndex(
                name: "IX_tblCustomers_MobileNumber",
                table: "tblCustomers");

            migrationBuilder.DropIndex(
                name: "IX_tblCustomers_PAN",
                table: "tblCustomers");

            migrationBuilder.DropIndex(
                name: "IX_tblCustomerApplication_AadharNumber",
                table: "tblCustomerApplication");

            migrationBuilder.DropIndex(
                name: "IX_tblCustomerApplication_MobileNumber",
                table: "tblCustomerApplication");

            migrationBuilder.DropIndex(
                name: "IX_tblCustomerApplication_PAN",
                table: "tblCustomerApplication");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f62de41-0d8a-4250-8def-ab419b82c68b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57eef7fb-2593-480d-ad2c-e2936841d08b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dabb5fc5-f4cb-4034-bada-93c422d25e19", "8e76c8da-4d87-40c9-8312-0ab04ea4c4b2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dabb5fc5-f4cb-4034-bada-93c422d25e19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e76c8da-4d87-40c9-8312-0ab04ea4c4b2");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "tblCustomers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "tblCustomers");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "tblCustomers");

            migrationBuilder.DropColumn(
                name: "AccountTypeID",
                table: "tblCustomerApplication");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "tblCustomerApplication");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "tblCustomerApplication");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "tblAccounts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15e2e88c-d62e-40d0-a8a1-bca8bf39ba31", null, "Admin", "ADMIN" },
                    { "3e9291b8-9ea9-4c73-84fb-4b89a0fe5ea5", null, "Manager", "MANAGER" },
                    { "fd744f1a-fd81-4aa4-adc3-0f0e8defef53", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Email", "EmailConfirmed", "FullName", "IsActive", "IsDeleted", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedDate", "MustChangePassword", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b0d991ed-c128-49ad-9f4e-1200b42f0c6e", 0, "ddb8315d-075a-4ef0-b64a-b739d6ad4983", "System", new DateTime(2025, 11, 8, 19, 53, 41, 734, DateTimeKind.Local).AddTicks(6757), null, null, "admin@bankingsystem.com", true, "System Administrator", true, false, false, null, null, null, false, "ADMIN@BANKINGSYSTEM.COM", "ADMIN", "AQAAAAIAAYagAAAAEOWbEH5Z1H2TE0wj1hYZb86jSVMvZfv+qvT/Fe4MVLd8dTaj+9RbTlRfeGyI0NCAtw==", null, false, "b4a95731-c642-4279-a966-d010af134f80", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "15e2e88c-d62e-40d0-a8a1-bca8bf39ba31", "b0d991ed-c128-49ad-9f4e-1200b42f0c6e" });
        }
    }
}
