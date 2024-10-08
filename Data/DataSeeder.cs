using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public static class DataSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            // Roles
            var employeeRoleId = Guid.NewGuid();
            var studentRoleId = Guid.NewGuid();

            modelBuilder.Entity<Role>().HasData(
                new Role { RoleID = employeeRoleId, RoleName = "Employee" },
                new Role { RoleID = studentRoleId, RoleName = "Student" }
            );

            // Users
            var student1UserId = Guid.NewGuid();
            var student2UserId = Guid.NewGuid();
            var employee1UserId = Guid.NewGuid();

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserID = student1UserId,
                    Username = "student1",
                    Password = BCrypt.Net.BCrypt.HashPassword("student1"),
                    FirstName = "John",
                    LastName = "Doe",
                    RoleID = studentRoleId
                },
                new User
                {
                    UserID = student2UserId,
                    Username = "student2",
                    Password = BCrypt.Net.BCrypt.HashPassword("student2"),
                    FirstName = "Jane",
                    LastName = "Doe",
                    RoleID = studentRoleId
                },
                new User
                {
                    UserID = employee1UserId,
                    Username = "employee1",
                    Password = BCrypt.Net.BCrypt.HashPassword("employee1"),
                    FirstName = "Mark",
                    LastName = "Smith",
                    RoleID = employeeRoleId
                }
            );

            // Students
            var student1Id = Guid.NewGuid();
            var student2Id = Guid.NewGuid();

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentID = student1Id, UserID = student1UserId },
                new Student { StudentID = student2Id, UserID = student2UserId }
            );

            // Employees
            var employee1Id = Guid.NewGuid();

            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeID = employee1Id, UserID = employee1UserId }
            );

            // Subjects
            var mathSubjectId = Guid.NewGuid();
            var programmingSubjectId = Guid.NewGuid();

            modelBuilder.Entity<Subject>().HasData(
                new Subject { SubjectID = mathSubjectId, SubjectName = "Mathematics" },
                new Subject { SubjectID = programmingSubjectId, SubjectName = "Programming" }
            );

            // Grades for student1
            var grade1Id = Guid.NewGuid();
            var grade2Id = Guid.NewGuid();

            modelBuilder.Entity<Grade>().HasData(
                new Grade { GradeID = grade1Id, SubjectID = mathSubjectId, StudentID = student1Id, Grade1 = 2, Grade2 = 3.5 },
                new Grade { GradeID = grade2Id, SubjectID = mathSubjectId, StudentID = student1Id, Grade1 = 4.5, Grade2 = 0 }
            );

            // Books
            var book1Id = Guid.NewGuid();
            var book2Id = Guid.NewGuid();

            modelBuilder.Entity<Book>().HasData(
                new Book { BookID = book1Id, Title = "Introduction to Algorithms" },
                new Book { BookID = book2Id, Title = "C# Programming" }
            );

            // Borrowed books for student1
            var borrow1Id = Guid.NewGuid();

            modelBuilder.Entity<BorrowedBook>().HasData(
                new BorrowedBook { BorrowID = borrow1Id, BookID = book1Id, StudentID = student1Id }
            );
        }
    }
}
