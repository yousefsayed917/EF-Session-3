using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class modifyRelation1to1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_InstructorId",
                table: "Departments");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_InstructorId",
                table: "Departments",
                column: "InstructorId",
                unique: true,
                filter: "[InstructorId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_InstructorId",
                table: "Departments");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_InstructorId",
                table: "Departments",
                column: "InstructorId");
        }
    }
}
