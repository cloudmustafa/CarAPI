using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace CarAPI.Models
{
	public class User
	{
		public Guid Id { get; set; }
		public int AccessFailedCount { get; set; }
		public Guid ConcurrencyStamp { get; set; }
		public string Email { get; set; }
		public bool EmailConfirmed { get; set; }
		public bool LockoutEnabled { get; set; }
		public string LockoutEnd { get; set; }
		public string NormalizedEmail { get; set; }
		public string NormalizedUserName { get; set; }
		public string PasswordHash { get; set; }
		public string PhoneNumber { get; set; }
		public bool PhoneNumberConfirmed { get; set; }
		public Guid SecurityStamp { get; set; }
		public bool TwoFactorEnabled { get; set; }
		public string UserName { get; set; }

	}
}
