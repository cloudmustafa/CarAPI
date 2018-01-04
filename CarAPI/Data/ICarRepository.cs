using CarAPI.Models;

namespace CarAPI.Data
{
    public interface ICarRepository:IRepository<Car>
    {
	    //IEnumerable<Car> GetBankAcocuntsWithBalanceGe(decimal balance, int pageIndex, int pageSize=10);
	}
}
