using Api.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Aggregates.Users
{
	public class User_Role : EntityBase<int>
	{
		public int UserId { get; set; }
		public User User { get; set; }
		public int RoleId { get; set; }
		public Role Role { get; set; }
	}
}
