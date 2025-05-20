using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AxonAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 5, 20, 11, 44, 46, 423, DateTimeKind.Local).AddTicks(4652), "Kids & Jewelery" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 5, 20, 11, 44, 46, 423, DateTimeKind.Local).AddTicks(4666), "Kids & Grocery" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 5, 20, 11, 44, 46, 423, DateTimeKind.Local).AddTicks(4679), "Kids & Automotive" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 20, 11, 44, 46, 423, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 20, 11, 44, 46, 423, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 20, 11, 44, 46, 423, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 20, 11, 44, 46, 423, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 5, 20, 11, 44, 46, 426, DateTimeKind.Local).AddTicks(6141), "Sıla voluptatem cesurca et adanaya.", "Gidecekmiş." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 5, 20, 11, 44, 46, 426, DateTimeKind.Local).AddTicks(6202), "Teldeki vitae autem odit gördüm.", "Dolore adanaya." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 5, 20, 11, 44, 46, 426, DateTimeKind.Local).AddTicks(6262), "Minima ipsam değirmeni için cesurca.", "Koştum." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 5, 20, 11, 44, 46, 429, DateTimeKind.Local).AddTicks(9293), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 1.531319404013350m, 582.27m, "Unbranded Frozen Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 5, 20, 11, 44, 46, 429, DateTimeKind.Local).AddTicks(9324), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 9.996351461912070m, 515.36m, "Tasty Metal Computer" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 5, 2, 15, 45, 26, 192, DateTimeKind.Local).AddTicks(7634), "Industrial" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 5, 2, 15, 45, 26, 192, DateTimeKind.Local).AddTicks(7676), "Movies & Games" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 5, 2, 15, 45, 26, 192, DateTimeKind.Local).AddTicks(7680), "Games" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 2, 15, 45, 26, 192, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 2, 15, 45, 26, 192, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 2, 15, 45, 26, 192, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 5, 2, 15, 45, 26, 192, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 5, 2, 15, 45, 26, 194, DateTimeKind.Local).AddTicks(4825), "İnventore ipsum anlamsız minima olduğu.", "Cezbelendi." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 5, 2, 15, 45, 26, 194, DateTimeKind.Local).AddTicks(4866), "Deleniti et quis umut minima.", "Koyun accusantium." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 5, 2, 15, 45, 26, 194, DateTimeKind.Local).AddTicks(4893), "Blanditiis dolayı olduğu sed hesap.", "Eos." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 5, 2, 15, 45, 26, 195, DateTimeKind.Local).AddTicks(9472), "The Football Is Good For Training And Recreational Purposes", 3.420360561048440m, 372.51m, "Handmade Frozen Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 5, 2, 15, 45, 26, 195, DateTimeKind.Local).AddTicks(9500), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 4.172967740556580m, 709.94m, "Incredible Rubber Salad" });
        }
    }
}
