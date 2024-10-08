﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.Book", b =>
                {
                    b.Property<Guid>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("BookID");

                    b.ToTable("Books", "SchoolSystem");

                    b.HasData(
                        new
                        {
                            BookID = new Guid("be7be3df-b264-4be8-9ce9-66f80f282a53"),
                            Title = "Introduction to Algorithms"
                        },
                        new
                        {
                            BookID = new Guid("6c083fa8-cb9d-4d69-bc25-184ebb7b2b77"),
                            Title = "C# Programming"
                        });
                });

            modelBuilder.Entity("Core.Entities.BorrowedBook", b =>
                {
                    b.Property<Guid>("BorrowID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BorrowID");

                    b.HasIndex("BookID");

                    b.HasIndex("StudentID");

                    b.ToTable("BorrowedBooks", "SchoolSystem");

                    b.HasData(
                        new
                        {
                            BorrowID = new Guid("e1421048-a5b6-4c68-a201-7f3a788d4611"),
                            BookID = new Guid("be7be3df-b264-4be8-9ce9-66f80f282a53"),
                            StudentID = new Guid("8dbb20e0-cb16-41f5-92a4-9453afbd6e2e")
                        });
                });

            modelBuilder.Entity("Core.Entities.Employee", b =>
                {
                    b.Property<Guid>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EmployeeID");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("Employees", "SchoolSystem");

                    b.HasData(
                        new
                        {
                            EmployeeID = new Guid("6ddade5f-aeb6-42d3-a8f6-f1dd9d96755b"),
                            UserID = new Guid("c180c721-e5ea-4567-bf45-fde9df6e7dd7")
                        });
                });

            modelBuilder.Entity("Core.Entities.Grade", b =>
                {
                    b.Property<Guid>("GradeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Grade1")
                        .HasColumnType("float");

                    b.Property<double>("Grade2")
                        .HasColumnType("float");

                    b.Property<Guid>("StudentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GradeID");

                    b.HasIndex("StudentID");

                    b.HasIndex("SubjectID");

                    b.ToTable("Grades", "SchoolSystem");

                    b.HasData(
                        new
                        {
                            GradeID = new Guid("77bbe20d-d236-4baf-ad1e-0b8087fbc654"),
                            Grade1 = 2.0,
                            Grade2 = 3.5,
                            StudentID = new Guid("8dbb20e0-cb16-41f5-92a4-9453afbd6e2e"),
                            SubjectID = new Guid("afcd2dc9-c0cd-4c30-a937-84998756aaf9")
                        },
                        new
                        {
                            GradeID = new Guid("f2982cf4-53d2-4b54-a82b-8465997d7891"),
                            Grade1 = 4.5,
                            Grade2 = 0.0,
                            StudentID = new Guid("8dbb20e0-cb16-41f5-92a4-9453afbd6e2e"),
                            SubjectID = new Guid("afcd2dc9-c0cd-4c30-a937-84998756aaf9")
                        });
                });

            modelBuilder.Entity("Core.Entities.Role", b =>
                {
                    b.Property<Guid>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles", "SchoolSystem");

                    b.HasData(
                        new
                        {
                            RoleID = new Guid("bf8d0d9b-995a-43a1-abd4-12bbf5ebba0c"),
                            RoleName = "Employee"
                        },
                        new
                        {
                            RoleID = new Guid("62d8b98a-acca-4729-a23c-99b705000eaa"),
                            RoleName = "Student"
                        });
                });

            modelBuilder.Entity("Core.Entities.Student", b =>
                {
                    b.Property<Guid>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StudentID");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("Students", "SchoolSystem");

                    b.HasData(
                        new
                        {
                            StudentID = new Guid("8dbb20e0-cb16-41f5-92a4-9453afbd6e2e"),
                            UserID = new Guid("e6daf130-d329-47b2-9f97-4876135e8ebb")
                        },
                        new
                        {
                            StudentID = new Guid("3fadc244-5901-4e5e-ab3a-6bdeb30c694d"),
                            UserID = new Guid("e2db0d4f-7788-4d63-a9f6-df54ad51090c")
                        });
                });

            modelBuilder.Entity("Core.Entities.Subject", b =>
                {
                    b.Property<Guid>("SubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SubjectID");

                    b.ToTable("Subjects", "SchoolSystem");

                    b.HasData(
                        new
                        {
                            SubjectID = new Guid("afcd2dc9-c0cd-4c30-a937-84998756aaf9"),
                            SubjectName = "Mathematics"
                        },
                        new
                        {
                            SubjectID = new Guid("a493c38d-8420-4c81-bc19-9b14002a5d27"),
                            SubjectName = "Programming"
                        });
                });

            modelBuilder.Entity("Core.Entities.User", b =>
                {
                    b.Property<Guid>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<Guid>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserID");

                    b.HasIndex("RoleID");

                    b.ToTable("Users", "SchoolSystem");

                    b.HasData(
                        new
                        {
                            UserID = new Guid("e6daf130-d329-47b2-9f97-4876135e8ebb"),
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "$2a$10$xRSnvsSMBWEWhJEWBfbBS.p9p1h/wp7zBSlsN0XQQhcx1NxIoQSNy",
                            RoleID = new Guid("62d8b98a-acca-4729-a23c-99b705000eaa"),
                            Username = "student1"
                        },
                        new
                        {
                            UserID = new Guid("e2db0d4f-7788-4d63-a9f6-df54ad51090c"),
                            FirstName = "Jane",
                            LastName = "Doe",
                            Password = "$2a$10$6JKvzzfoyntsJjMHmKb99.mho95sbO8L7UEAmJxPZF4e4iKEWwcA6",
                            RoleID = new Guid("62d8b98a-acca-4729-a23c-99b705000eaa"),
                            Username = "student2"
                        },
                        new
                        {
                            UserID = new Guid("c180c721-e5ea-4567-bf45-fde9df6e7dd7"),
                            FirstName = "Mark",
                            LastName = "Smith",
                            Password = "$2a$10$36YUab3OWA4o/RKL//wfNu4FgfX53x48oTW8mW4E954dI7QW7XOuW",
                            RoleID = new Guid("bf8d0d9b-995a-43a1-abd4-12bbf5ebba0c"),
                            Username = "employee1"
                        });
                });

            modelBuilder.Entity("Core.Entities.BorrowedBook", b =>
                {
                    b.HasOne("Core.Entities.Book", "Book")
                        .WithMany("BorrowedBooks")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Student", "Student")
                        .WithMany("BorrowedBooks")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Core.Entities.Employee", b =>
                {
                    b.HasOne("Core.Entities.User", "User")
                        .WithOne("Employee")
                        .HasForeignKey("Core.Entities.Employee", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Entities.Grade", b =>
                {
                    b.HasOne("Core.Entities.Student", "Student")
                        .WithMany("Grades")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Subject", "Subject")
                        .WithMany("Grades")
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Core.Entities.Student", b =>
                {
                    b.HasOne("Core.Entities.User", "User")
                        .WithOne("Student")
                        .HasForeignKey("Core.Entities.Student", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Entities.User", b =>
                {
                    b.HasOne("Core.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Core.Entities.Book", b =>
                {
                    b.Navigation("BorrowedBooks");
                });

            modelBuilder.Entity("Core.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Core.Entities.Student", b =>
                {
                    b.Navigation("BorrowedBooks");

                    b.Navigation("Grades");
                });

            modelBuilder.Entity("Core.Entities.Subject", b =>
                {
                    b.Navigation("Grades");
                });

            modelBuilder.Entity("Core.Entities.User", b =>
                {
                    b.Navigation("Employee")
                        .IsRequired();

                    b.Navigation("Student")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
