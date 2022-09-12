using Api.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Aggregates.Users
{
	[Serializable]
	public class User : EntityBase<int>
	{
		public string Name { get; set; }
		public string Surename { get; set; }
		public virtual ICollection<User_Role> User_Role { get; set; }

		public User() : base()
		{
		}
		//public User(string name, string surename)
		//{
		//	Name = name;
		//	Surename = surename;
		//	//User_Role = user_role;
		//}
	}
}
