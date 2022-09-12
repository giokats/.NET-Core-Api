using Api.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Aggregates.Users
{
	public class Role : EntityBase<int>
	{
		public string Name { get; set; }
		public virtual ICollection<User_Role> User_Role { get; set; }

		public Role():base()
		{

		}
	}
}
