using CarAPI.DAL;

namespace CarAPI.Data
{
    public class UserUnitOfWork:IUserUnitOfWork
    {
	    private readonly AspNetContext _context;

	    public UserUnitOfWork(AspNetContext context)
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
