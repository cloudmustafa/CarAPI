using System;
using System.Collections.Generic;
using CarAPI.Data;
using CarAPI.DAL;
using CarAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarAPI.Controllers
{
    [Route("api/[controller]")]
    public class RoleController : Controller
    {
	    private readonly UserUnitOfWork _unitOfWork;
		public RoleController(AspNetContext context)
	    {
			_unitOfWork = new UserUnitOfWork(context);
		}
        // GET api/Role
        [HttpGet]
        public IEnumerable<Role> GetRoles()
        {
	        return _unitOfWork.Roles.GetAll();
        }

        // GET api/Role/5
        [HttpGet("{id}")]
        public Role GetRole(string id)
        {
	        return _unitOfWork.Roles.Get(new Guid(id));
		}

        // POST api/Role
        [HttpPost]
        public void AddRole([FromBody] Role company)
        {
	        _unitOfWork.Roles.Add(company);
	        _unitOfWork.Complete();
		}

        // PUT api/Role/5
        [HttpPut("{id}")]
        public void UpdateRole([FromBody] Role company)
        {
	        _unitOfWork.Roles.Update(company);
			_unitOfWork.Complete();
        }

        // DELETE api/Role/5
        [HttpDelete("{id}")]
        public void DeleteRole(string id)
        {
	        var account = _unitOfWork.Roles.Get(new Guid(id));
			_unitOfWork.Roles.Remove(account);
	        _unitOfWork.Complete();
		}
    }
}