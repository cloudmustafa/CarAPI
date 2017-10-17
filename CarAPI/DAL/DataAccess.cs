using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CarAPI.Data;
using CarAPI.Models;

namespace CarAPI.DAL
{
    public class DataAccess
    {
        private readonly DbContextOptionsBuilder<CarApiContext> _optionsBuilder =
            new DbContextOptionsBuilder<CarApiContext>();

        public DataAccess()
        {
            _optionsBuilder.UseSqlite("DataSource=App_Data/Car.db");
        }

	    public ICollection<Car> GetCars()
	    {
		    using (var context = new CarApiContext(_optionsBuilder.Options))
		    {
			    return context.Cars.ToList();
		    }
	    }

	    public Car GetCar(Guid id)
	    {
		    using (var context = new CarApiContext(_optionsBuilder.Options))
		    {
			    return context.Cars.SingleOrDefault(o => o.Id == id);
		    }
	    }

	    public void AddCar(Car Car)
	    {
		    using (var context = new CarApiContext(_optionsBuilder.Options))
		    {
			    context.Cars.Add(Car);
			    context.SaveChanges();
		    }
	    }

	    public void DeleteCar(Guid id)
	    {
		    using (var context = new CarApiContext(_optionsBuilder.Options))
		    {
			    var Car = GetCar(id);
			    context.Cars.Remove(Car);
			    context.SaveChanges();
		    }
	    }

	    public void UpdateCar(Car Car)
	    {
		    using (var context = new CarApiContext(_optionsBuilder.Options))
		    {
			    context.Cars.Update(Car);
			    context.SaveChanges();
		    }
	    }

		public ICollection<Company> GetCompanies()
        {
            using (var context = new CarApiContext(_optionsBuilder.Options))
            {
                return context.Companies.ToList();
            }
        }

        public Company GetCompany(Guid id)
        {
            using (var context = new CarApiContext(_optionsBuilder.Options))
            {
                return context.Companies.SingleOrDefault(o => o.Id == id);
            }
        }

        public void AddCompany(Company Company)
        {
            using (var context = new CarApiContext(_optionsBuilder.Options))
            {
                context.Companies.Add(Company);
                context.SaveChanges();
            }
        }

        public void DeleteCompany(Guid id)
        {
            using (var context = new CarApiContext(_optionsBuilder.Options))
            {
                var Company = GetCompany(id);
                context.Companies.Remove(Company);
                context.SaveChanges();
            }
        }

        public void UpdateCompany(Company Company)
        {
            using (var context = new CarApiContext(_optionsBuilder.Options))
            {
                context.Companies.Update(Company);
                context.SaveChanges();
            }
        }
    }
}