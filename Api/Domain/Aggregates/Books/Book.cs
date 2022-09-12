using Api.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Aggregates.Books
{
	public class Book : EntityBase<int>
	{
		public string Name { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }
	}	
}
