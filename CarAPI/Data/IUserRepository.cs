using CarApi.Models;

namespace CarApi.Data
{
    public interface IUserRepository:IRepository<User>
    {
	    //IEnumerable<Car> GetBankAcocuntsWithBalanceGe(decimal balance, int pageIndex, int pageSize=10);
	}
}
