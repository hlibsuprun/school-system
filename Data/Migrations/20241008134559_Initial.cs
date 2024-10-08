using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "SchoolSystem");

            migrationBuilder.CreateTable(
                name: "Books",
                schema: "SchoolSystem",
                columns: table => new
                {
                    BookID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "SchoolSystem",
                columns: table => new
                {
                    RoleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                schema: "SchoolSystem",
                columns: table => new
                {
                    SubjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "SchoolSystem",
                columns: table => new
                {
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RoleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleID",
                        column: x => x.RoleID,
                        principalSchema: "SchoolSystem",
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "SchoolSystem",
                columns: table => new
                {
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employees_Users_UserID",
                        column: x => x.UserID,
                        principalSchema: "SchoolSystem",
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                schema: "SchoolSystem",
                columns: table => new
                {
                    StudentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Students_Users_UserID",
                        column: x => x.UserID,
                        principalSchema: "SchoolSystem",
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BorrowedBooks",
                schema: "SchoolSystem",
                columns: table => new
                {
                    BorrowID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowedBooks", x => x.BorrowID);
                    table.ForeignKey(
                        name: "FK_BorrowedBooks_Books_BookID",
                        column: x => x.BookID,
                        principalSchema: "SchoolSystem",
                        principalTable: "Books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BorrowedBooks_Students_StudentID",
                        column: x => x.StudentID,
                        principalSchema: "SchoolSystem",
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                schema: "SchoolSystem",
                columns: table => new
                {
                    GradeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Grade1 = table.Column<double>(type: "float", nullable: false),
                    Grade2 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.GradeID);
                    table.ForeignKey(
                        name: "FK_Grades_Students_StudentID",
                        column: x => x.StudentID,
                        principalSchema: "SchoolSystem",
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Grades_Subjects_SubjectID",
                        column: x => x.SubjectID,
                        principalSchema: "SchoolSystem",
                        principalTable: "Subjects",
                        principalColumn: "SubjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "SchoolSystem",
                table: "Books",
                columns: new[] { "BookID", "Title" },
                values: new object[,]
                {
                    { new Guid("6c083fa8-cb9d-4d69-bc25-184ebb7b2b77"), "C# Programming" },
                    { new Guid("be7be3df-b264-4be8-9ce9-66f80f282a53"), "Introduction to Algorithms" }
                });

            migrationBuilder.InsertData(
                schema: "SchoolSystem",
                table: "Roles",
                columns: new[] { "RoleID", "RoleName" },
                values: new object[,]
                {
                    { new Guid("62d8b98a-acca-4729-a23c-99b705000eaa"), "Student" },
                    { new Guid("bf8d0d9b-995a-43a1-abd4-12bbf5ebba0c"), "Employee" }
                });

            migrationBuilder.InsertData(
                schema: "SchoolSystem",
                table: "Subjects",
                columns: new[] { "SubjectID", "SubjectName" },
                values: new object[,]
                {
                    { new Guid("a493c38d-8420-4c81-bc19-9b14002a5d27"), "Programming" },
                    { new Guid("afcd2dc9-c0cd-4c30-a937-84998756aaf9"), "Mathematics" }
                });

            migrationBuilder.InsertData(
                schema: "SchoolSystem",
                table: "Users",
                columns: new[] { "UserID", "FirstName", "LastName", "Password", "RoleID", "Username" },
                values: new object[,]
                {
                    { new Guid("c180c721-e5ea-4567-bf45-fde9df6e7dd7"), "Mark", "Smith", "$2a$10$36YUab3OWA4o/RKL//wfNu4FgfX53x48oTW8mW4E954dI7QW7XOuW", new Guid("bf8d0d9b-995a-43a1-abd4-12bbf5ebba0c"), "employee1" },
                    { new Guid("e2db0d4f-7788-4d63-a9f6-df54ad51090c"), "Jane", "Doe", "$2a$10$6JKvzzfoyntsJjMHmKb99.mho95sbO8L7UEAmJxPZF4e4iKEWwcA6", new Guid("62d8b98a-acca-4729-a23c-99b705000eaa"), "student2" },
                    { new Guid("e6daf130-d329-47b2-9f97-4876135e8ebb"), "John", "Doe", "$2a$10$xRSnvsSMBWEWhJEWBfbBS.p9p1h/wp7zBSlsN0XQQhcx1NxIoQSNy", new Guid("62d8b98a-acca-4729-a23c-99b705000eaa"), "student1" }
                });

            migrationBuilder.InsertData(
                schema: "SchoolSystem",
                table: "Employees",
                columns: new[] { "EmployeeID", "UserID" },
                values: new object[] { new Guid("6ddade5f-aeb6-42d3-a8f6-f1dd9d96755b"), new Guid("c180c721-e5ea-4567-bf45-fde9df6e7dd7") });

            migrationBuilder.InsertData(
                schema: "SchoolSystem",
                table: "Students",
                columns: new[] { "StudentID", "UserID" },
                values: new object[,]
                {
                    { new Guid("3fadc244-5901-4e5e-ab3a-6bdeb30c694d"), new Guid("e2db0d4f-7788-4d63-a9f6-df54ad51090c") },
                    { new Guid("8dbb20e0-cb16-41f5-92a4-9453afbd6e2e"), new Guid("e6daf130-d329-47b2-9f97-4876135e8ebb") }
                });

            migrationBuilder.InsertData(
                schema: "SchoolSystem",
                table: "BorrowedBooks",
                columns: new[] { "BorrowID", "BookID", "StudentID" },
                values: new object[] { new Guid("e1421048-a5b6-4c68-a201-7f3a788d4611"), new Guid("be7be3df-b264-4be8-9ce9-66f80f282a53"), new Guid("8dbb20e0-cb16-41f5-92a4-9453afbd6e2e") });

            migrationBuilder.InsertData(
                schema: "SchoolSystem",
                table: "Grades",
                columns: new[] { "GradeID", "Grade1", "Grade2", "StudentID", "SubjectID" },
                values: new object[,]
                {
                    { new Guid("77bbe20d-d236-4baf-ad1e-0b8087fbc654"), 2.0, 3.5, new Guid("8dbb20e0-cb16-41f5-92a4-9453afbd6e2e"), new Guid("afcd2dc9-c0cd-4c30-a937-84998756aaf9") },
                    { new Guid("f2982cf4-53d2-4b54-a82b-8465997d7891"), 4.5, 0.0, new Guid("8dbb20e0-cb16-41f5-92a4-9453afbd6e2e"), new Guid("afcd2dc9-c0cd-4c30-a937-84998756aaf9") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBooks_BookID",
                schema: "SchoolSystem",
                table: "BorrowedBooks",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBooks_StudentID",
                schema: "SchoolSystem",
                table: "BorrowedBooks",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserID",
                schema: "SchoolSystem",
                table: "Employees",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentID",
                schema: "SchoolSystem",
                table: "Grades",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_SubjectID",
                schema: "SchoolSystem",
                table: "Grades",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserID",
                schema: "SchoolSystem",
                table: "Students",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleID",
                schema: "SchoolSystem",
                table: "Users",
                column: "RoleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BorrowedBooks",
                schema: "SchoolSystem");

            migrationBuilder.DropTable(
                name: "Employees",
                schema: "SchoolSystem");

            migrationBuilder.DropTable(
                name: "Grades",
                schema: "SchoolSystem");

            migrationBuilder.DropTable(
                name: "Books",
                schema: "SchoolSystem");

            migrationBuilder.DropTable(
                name: "Students",
                schema: "SchoolSystem");

            migrationBuilder.DropTable(
                name: "Subjects",
                schema: "SchoolSystem");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "SchoolSystem");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "SchoolSystem");
        }
    }
}
