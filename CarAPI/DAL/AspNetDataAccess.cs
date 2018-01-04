using System;
using System.Collections.Generic;
using System.Linq;
using CarAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CarAPI.DAL
{
    public class AspNetDataAccess
    {
        private readonly DbContextOptionsBuilder<AspNetContext> _optionsBuilder =
            new DbContextOptionsBuilder<AspNetContext>();

        public AspNetDataAccess()
        {
            _optionsBuilder.UseSqlite("DataSource=App_Data/AspNet.db");
        }

	    public ICollection<User> GetUsers()
	    {
		    using (var context = new AspNetContext(_optionsBuilder.Options))
		    {
			    return context.Users.ToList();
		    }
	    }

	    public User GetUser(Guid id)
	    {
		    using (var context = new AspNetContext(_optionsBuilder.Options))
		    {
			    return context.Users.SingleOrDefault(o => o.Id == id);
		    }
	    }

	    public void AddUser(User user)
	    {
		    using (var context = new AspNetContext(_optionsBuilder.Options))
		    {
			    context.Users.Add(user);
			    context.SaveChanges();
		    }
	    }

	    public void DeleteUser(Guid id)
	    {
		    using (var context = new AspNetContext(_optionsBuilder.Options))
		    {
			    var User = GetUser(id);
			    context.Users.Remove(User);
			    context.SaveChanges();
		    }
	    }

	    public void UpdateUser(User user)
	    {
		    using (var context = new AspNetContext(_optionsBuilder.Options))
		    {
			    context.Users.Update(user);
			    context.SaveChanges();
		    }
	    }

		public ICollection<Role> GetRoles()
        {
            using (var context = new AspNetContext(_optionsBuilder.Options))
            {
                return context.Roles.ToList();
            }
        }

        public Role GetRole(Guid id)
        {
            using (var context = new AspNetContext(_optionsBuilder.Options))
            {
                return context.Roles.SingleOrDefault(o => o.Id == id);
            }
        }

        public void AddRole(Role role)
        {
            using (var context = new AspNetContext(_optionsBuilder.Options))
            {
                context.Roles.Add(role);
                context.SaveChanges();
            }
        }

        public void DeleteRole(Guid id)
        {
            using (var context = new AspNetContext(_optionsBuilder.Options))
            {
                var role = GetRole(id);
                context.Roles.Remove(role);
                context.SaveChanges();
            }
        }

        public void UpdateRole(Role role)
        {
            using (var context = new AspNetContext(_optionsBuilder.Options))
            {
                context.Roles.Update(role);
                context.SaveChanges();
            }
        }
    }
}