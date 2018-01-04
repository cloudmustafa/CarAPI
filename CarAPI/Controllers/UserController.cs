using System;
using System.Collections.Generic;
using CarAPI.Data;
using CarAPI.DAL;
using CarAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace CarAPI.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
	    private readonly UserUnitOfWork _unitOfWork;
		public UserController(AspNetContext context)
	    {
			_unitOfWork = new UserUnitOfWork(context);
		}
        // GET api/User
        [HttpGet]
        [EnableCors("AllowAllOrigins")]
		public IEnumerable<User> GetUsers()
        {
	        return _unitOfWork.Users.GetAll();
        }

        // GET api/User/5
        [HttpGet("{id}")]
        [EnableCors("AllowAllOrigins")]
		public User GetUser(string id)
        {
	        return _unitOfWork.Users.Get(new Guid(id));
		}

        // POST api/User
        [HttpPost]
        [EnableCors("AllowAllOrigins")]
		public void AddUser([FromBody] User user)
        {
	        _unitOfWork.Users.Add(user);
	        _unitOfWork.Complete();
		}

        // PUT api/User/5
        [HttpPut("{id}")]
        [EnableCors("AllowAllOrigins")]
		public void UpdateUser([FromBody] User user)
        {
	        _unitOfWork.Users.Update(user);
			_unitOfWork.Complete();
        }

        // DELETE api/User/5
        [HttpDelete("{id}")]
        [EnableCors("AllowAllOrigins")]
		public void DeleteUser(string id)
        {
	        var account = _unitOfWork.Users.Get(new Guid(id));
			_unitOfWork.Users.Remove(account);
	        _unitOfWork.Complete();
		}
    }
}