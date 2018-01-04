using Microsoft.EntityFrameworkCore;
using CarApi.Models;

namespace CarApi.DAL
{
	public class AspNetContext : DbContext
	{
		public AspNetContext(DbContextOptions options)
			: base(options)
		{
		}

		public DbSet<User> Users { get; set; }

		public DbSet<Role> Roles { get; set; }
	}
}