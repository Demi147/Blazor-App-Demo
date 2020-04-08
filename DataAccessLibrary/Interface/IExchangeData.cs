using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IExchangeData
    {
        Task<List<Exchange>> Get_AllExchanges();
        Task InsertExchange(Exchange exchange);
    }
}