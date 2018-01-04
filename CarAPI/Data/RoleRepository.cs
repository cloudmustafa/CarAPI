using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CarAPI.Data;
using CarAPI.DAL;
using CarAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace CarAPI.Data
{
	public class RoleRepository : Repository<Role>, IRoleRepository
	{
		public RoleRepository(AspNetContext context) : base(context)
		{
		}

		public AspNetContext AspNetContext => Context as AspNetContext;

	}
}
