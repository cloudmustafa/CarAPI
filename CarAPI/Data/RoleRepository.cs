using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CarApi.Data;
using CarApi.DAL;
using CarApi.Models;
using Microsoft.EntityFrameworkCore;


namespace CarApi.Data
{
	public class RoleRepository : Repository<Role>, IRoleRepository
	{
		public RoleRepository(AspNetContext context) : base(context)
		{
		}

		public AspNetContext AspNetContext => Context as AspNetContext;

	}
}
