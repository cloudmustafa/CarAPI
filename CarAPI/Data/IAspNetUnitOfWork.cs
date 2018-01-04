using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarAPI.Data
{
    interface IAspNetUnitOfWork: IDisposable
    {
	    IUserRepository Users { get; }
		int Complete();
    }
}
