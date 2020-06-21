using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace zad11.Migrations
{
    public partial class AddedValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "1@gmail.com", "1", "1" },
                    { 2, "2@gmail.com", "2", "2" },
                    { 3, "3@gmail.com", "3", "3" }
                });

            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "1", "1", "1" },
                    { 2, "2", "2", "2" },
                    { 3, "3", "3", "3" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "IdPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 21, 20, 22, 41, 585, DateTimeKind.Local).AddTicks(5110), "1", "1" },
                    { 2, new DateTime(2020, 6, 21, 20, 22, 41, 585, DateTimeKind.Local).AddTicks(5110), "2", "2" },
                    { 3, new DateTime(2020, 6, 21, 20, 22, 41, 585, DateTimeKind.Local).AddTicks(5110), "3", "3" }
                });

            migrationBuilder.InsertData(
                table: "Presciptions",
                columns: new[] { "IdPresciption", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[] { 1, new DateTime(2020, 6, 21, 20, 22, 41, 577, DateTimeKind.Local).AddTicks(5105), new DateTime(2020, 8, 10, 20, 22, 41, 582, DateTimeKind.Local).AddTicks(5108), 1, 1 });

            migrationBuilder.InsertData(
                table: "Presciptions",
                columns: new[] { "IdPresciption", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[] { 2, new DateTime(2020, 6, 21, 20, 22, 41, 583, DateTimeKind.Local).AddTicks(5109), new DateTime(2020, 8, 10, 20, 22, 41, 583, DateTimeKind.Local).AddTicks(5109), 2, 2 });

            migrationBuilder.InsertData(
                table: "Presciptions",
                columns: new[] { "IdPresciption", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[] { 3, new DateTime(2020, 6, 21, 20, 22, 41, 583, DateTimeKind.Local).AddTicks(5109), new DateTime(2020, 8, 10, 20, 22, 41, 583, DateTimeKind.Local).AddTicks(5109), 3, 3 });

            migrationBuilder.InsertData(
                table: "Presciption_Medicaments",
                columns: new[] { "IdMedicament", "IdPresciption", "Details", "Dose" },
                values: new object[] { 1, 1, "1", null });

            migrationBuilder.InsertData(
                table: "Presciption_Medicaments",
                columns: new[] { "IdMedicament", "IdPresciption", "Details", "Dose" },
                values: new object[] { 2, 2, "2", null });

            migrationBuilder.InsertData(
                table: "Presciption_Medicaments",
                columns: new[] { "IdMedicament", "IdPresciption", "Details", "Dose" },
                values: new object[] { 3, 3, "3", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Presciption_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPresciption" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Presciption_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPresciption" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Presciption_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPresciption" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Presciptions",
                keyColumn: "IdPresciption",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Presciptions",
                keyColumn: "IdPresciption",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Presciptions",
                keyColumn: "IdPresciption",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 3);
        }
    }
}
