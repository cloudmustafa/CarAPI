using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Moq;
using CarAPI.Controllers;
using CarAPI.Data;
using CarAPI.DAL;
using CarAPI.Models;
using Xunit;

namespace CarAPITest
{
	public class UnitTest1
	{
		[Fact(DisplayName = "Index visar en bil")]
		public void Test1()
		{
			// In-memory database only exists while the connection is open
			var connection = new SqliteConnection("DataSource=:memory:");
			connection.Open();
			try
			{
				var options = new DbContextOptionsBuilder<CarApiContext>()
					.UseSqlite(connection)
					.Options;

				// Create the schema in the database
				using (var context = new CarApiContext(options))
				{
					context.Database.EnsureCreated();
				}
				using (var context = new CarApiContext(options))
				{
					var bankId = Guid.NewGuid();
					var transactionId = Guid.NewGuid();
					var Car = new Car() { Id = bankId, VIN = "xxx", RegNr = "ABC123"};
					context.Cars.Add(Car);

					context.SaveChanges();
				}

				using (var context = new CarApiContext(options))
				{
					var bc = new CarController(context);
					var result = bc.GetCars();
					Assert.NotNull(result);
					Assert.Equal(result.Count(), 1);
				}

			}
			finally
			{
				connection.Close();
			}
		}
	}
}
