using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarAPI.Data
{
    interface IUnitOfWork: IDisposable
    {
	    ICarRepository Cars { get; }
		int Complete();
    }
}
