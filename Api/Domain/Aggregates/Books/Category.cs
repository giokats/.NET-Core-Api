using Api.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Aggregates.Books
{
	public class Category : EntityBase<int>
	{
		public string Name { get; set; }
		public ICollection<Book> Books { get; set; }
	}
}
