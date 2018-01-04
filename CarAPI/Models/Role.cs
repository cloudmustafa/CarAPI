using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace CarApi.Models
{
	public class Role
	{
		public Guid Id { get; set; }
		public Guid ConcurrencyStamp { get; set; }
		public string Name { get; set; }
		public string NormalizedName { get; set; }
	}
}
