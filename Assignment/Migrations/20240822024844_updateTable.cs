using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class updateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Topic_TopicId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_Instructor_InstructorId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_InctructorCourse_Course_CourseId",
                table: "InctructorCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_InctructorCourse_Instructor_InstructorId",
                table: "InctructorCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Department_DeptId",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Department_DeptId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Course_CourseId",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Student_StudentId",
                table: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Instructor",
                newName: "Instructors");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Topic",
                newName: "TopicName");

            migrationBuilder.RenameIndex(
                name: "IX_Student_DeptId",
                table: "Students",
                newName: "IX_Students_DeptId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructor_DeptId",
                table: "Instructors",
                newName: "IX_Instructors_DeptId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_TopicId",
                table: "Courses",
                newName: "IX_Courses_TopicId");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Topic",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "10, 10")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "TopicName",
                table: "Topic",
                type: "Varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topic_TopicId",
                table: "Courses",
                column: "TopicId",
                principalTable: "Topic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructors_InstructorId",
                table: "Department",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InctructorCourse_Courses_CourseId",
                table: "InctructorCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InctructorCourse_Instructors_InstructorId",
                table: "InctructorCourse",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Department_DeptId",
                table: "Instructors",
                column: "DeptId",
                principalTable: "Department",
                principalColumn: "DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Courses_CourseId",
                table: "StudentCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Students_StudentId",
                table: "StudentCourse",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Department_DeptId",
                table: "Students",
                column: "DeptId",
                principalTable: "Department",
                principalColumn: "DeptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topic_TopicId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_Instructors_InstructorId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_InctructorCourse_Courses_CourseId",
                table: "InctructorCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_InctructorCourse_Instructors_InstructorId",
                table: "InctructorCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Department_DeptId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Courses_CourseId",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Students_StudentId",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Department_DeptId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "Instructors",
                newName: "Instructor");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameColumn(
                name: "TopicName",
                table: "Topic",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Students_DeptId",
                table: "Student",
                newName: "IX_Student_DeptId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_DeptId",
                table: "Instructor",
                newName: "IX_Instructor_DeptId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_TopicId",
                table: "Course",
                newName: "IX_Course_TopicId");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Topic",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "10, 10");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Topic",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Topic_TopicId",
                table: "Course",
                column: "TopicId",
                principalTable: "Topic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructor_InstructorId",
                table: "Department",
                column: "InstructorId",
                principalTable: "Instructor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InctructorCourse_Course_CourseId",
                table: "InctructorCourse",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InctructorCourse_Instructor_InstructorId",
                table: "InctructorCourse",
                column: "InstructorId",
                principalTable: "Instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Department_DeptId",
                table: "Instructor",
                column: "DeptId",
                principalTable: "Department",
                principalColumn: "DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Department_DeptId",
                table: "Student",
                column: "DeptId",
                principalTable: "Department",
                principalColumn: "DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Course_CourseId",
                table: "StudentCourse",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Student_StudentId",
                table: "StudentCourse",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
