// <auto-generated />
using Api.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20220912120139_updateDB06")]
    partial class updateDB06
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Api.Domain.Aggregates.Books.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "Book1"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Name = "Book2"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Name = "Book3"
                        });
                });

            modelBuilder.Entity("Api.Domain.Aggregates.Books.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Comic"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Thriller"
                        });
                });

            modelBuilder.Entity("Api.Domain.Aggregates.Users.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Admin2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Master"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Manager"
                        });
                });

            modelBuilder.Entity("Api.Domain.Aggregates.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surename")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Amaan",
                            Surename = "Knox"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Vijay",
                            Surename = "Watts"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Zack",
                            Surename = "Fuentes"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Willis",
                            Surename = "Joseph"
                        });
                });

            modelBuilder.Entity("Api.Domain.Aggregates.Users.User_Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("Users_Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            RoleId = 1,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            RoleId = 2,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            RoleId = 3,
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            RoleId = 4,
                            UserId = 4
                        });
                });

            modelBuilder.Entity("Api.Domain.Aggregates.Books.Book", b =>
                {
                    b.HasOne("Api.Domain.Aggregates.Books.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Api.Domain.Aggregates.Users.User_Role", b =>
                {
                    b.HasOne("Api.Domain.Aggregates.Users.Role", "Role")
                        .WithMany("User_Role")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Domain.Aggregates.Users.User", "User")
                        .WithMany("User_Role")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Api.Domain.Aggregates.Books.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Api.Domain.Aggregates.Users.Role", b =>
                {
                    b.Navigation("User_Role");
                });

            modelBuilder.Entity("Api.Domain.Aggregates.Users.User", b =>
                {
                    b.Navigation("User_Role");
                });
#pragma warning restore 612, 618
        }
    }
}
