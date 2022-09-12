using Microsoft.EntityFrameworkCore;
using Api.Domain.Aggregates.Users;
using Api.Domain.Aggregates.Books;
using System.Reflection;
using AutoMapper;
using System.Collections.Generic;

namespace Api.Infrastructure.Context
{
	public class ApiContext :DbContext
	{
		public ApiContext(DbContextOptions<ApiContext> options) : base(options)
		{
		}
		public DbSet<User> Users { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<User_Role> Users_Roles { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<Category> Categories { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			modelBuilder.Entity<User_Role>()
				.HasOne(u => u.User)
				.WithMany(ur => ur.User_Role)
				.HasForeignKey(ui => ui.UserId);
			modelBuilder.Entity<User_Role>()
				.HasOne(u => u.Role)
				.WithMany(ur => ur.User_Role)
				.HasForeignKey(ui => ui.RoleId);
			modelBuilder.Entity<Category>()
					.HasMany(b => b.Books)
					.WithOne(b => b.Category)
					.HasForeignKey(a => a.CategoryId)
					.OnDelete(DeleteBehavior.Cascade);
			modelBuilder.Entity<User>()
				.HasData(new List<User>()
				{
					new User
					{
						Id = 1,
						Name = "Amaan",
						Surename = "Knox"
					},
					new User
					{
						Id = 2,
						Name = "Vijay",
						Surename = "Watts"
					},
					new User
					{
						Id = 3,
						Name = "Zack",
						Surename = "Fuentes"
					},
					new User
					{
						Id = 4,
						Name = "Willis",
						Surename = "Joseph"
					}
				}); 
			modelBuilder.Entity<Role>()
				.HasData(new List<Role>()
				{
					new Role() { Id = 1, Name = "Admin"},
					new Role() { Id = 2, Name = "Admin2"},
					new Role() {Id = 3, Name = "Master"},
					new Role() { Id = 4, Name = "Manager"}
				});
			modelBuilder.Entity<User_Role>()
				.HasData(new List<User_Role>()
				{ 
					new User_Role(){Id= 1, UserId = 1, RoleId = 1},
					new User_Role(){Id= 2, UserId = 2, RoleId = 1},
					new User_Role(){Id= 3, UserId = 3, RoleId = 2},
					new User_Role(){Id= 4, UserId = 4, RoleId = 3},
					new User_Role(){Id= 5, UserId = 4, RoleId = 4},
				});

			modelBuilder.Entity<Category>()
				.HasData(new List<Category>()
				{
					new Category(){Id = 1, Name = "Comic"},
					new Category(){Id = 2, Name = "Drama"},
					new Category(){Id = 3, Name = "Thriller"},
				});

			modelBuilder.Entity<Book>()
				.HasData(new List<Book>()
				{
					new Book(){Id = 1, Name = "Book1", CategoryId = 1 },
					new Book(){Id = 2, Name = "Book2", CategoryId = 2},
					new Book(){Id = 3, Name = "Book3", CategoryId = 3},
				});
			base.OnModelCreating(modelBuilder);
		}
	}

}
