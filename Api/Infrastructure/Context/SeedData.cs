using Api.Domain.Aggregates.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Infrastructure.Context
{
	public class SeedData
	{
		public void Seed(ApiContext context)
		{
			var users = new List<User>()
			{
				new User
				{
					Name = "Amaan",
					Surename = "Knox",
					User_Role = new List<User_Role>()
					{ new User_Role{ Role = new Role() { Name = "Admin"}} }
				},
				new User
				{
					Name = "Vijay",
					Surename = "Watts",
					User_Role = new List<User_Role>()
					{ new User_Role{ Role = new Role() { Name = "Admin"}} }
				},
				new User
				{
					Name = "Zack",
					Surename = "Fuentes",
					User_Role = new List<User_Role>()
					{ new User_Role{ Role = new Role() { Name = "Master"}} }
				},
				new User
				{
					Name = "Willis",
					Surename = "Joseph",
					User_Role = new List<User_Role>()
					{ new User_Role{ Role = new Role() { Name = "Manager"}} }
				}
			};
			context.Users.AddRange(users);
			context.SaveChanges();
		}
	}
}
