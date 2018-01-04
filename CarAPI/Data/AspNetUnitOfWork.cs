using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CarApi.Data;
using CarApi.DAL;

namespace CarAPI.Data
{
    public class AspNetUnitOfWork:IAspNetUnitOfWork
    {
	    private readonly AspNetContext _context;

	    public AspNetUnitOfWork(AspNetContext context)
	    {
		    _context = context;
		    Users = new UserRepository(_context);
		    Roles = new RoleRepository(_context);
		}

	    public void Dispose()
	    {
		   _context.Dispose();
	    }

	    public IUserRepository Users { get; private set; }
	    public IRoleRepository Roles { get; private set; }
		public int Complete()
		{
			return _context.SaveChanges();
		}
    }
}
