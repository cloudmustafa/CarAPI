﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarApi.Data
{
    interface IUserUnitOfWork: IDisposable
    {
	    IUserRepository Users { get; }
		int Complete();
    }
}