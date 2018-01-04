using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarApi.DAL;
using CarApi.Models;

namespace CarApi.Data
{
	public class UserRepository : Repository<User>, IUserRepository
	{
		public UserRepository(AspNetContext context) : base(context)
		{
		}

		public AspNetContext AspNetContext => Context as AspNetContext;

	}
}
