﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarApi.Models;

namespace CarApi.Data
{
    public interface ICompanyRepository:IRepository<Company>
    {
	    //IEnumerable<Car> GetBankAcocuntsWithBalanceGe(decimal balance, int pageIndex, int pageSize=10);
	}
}
