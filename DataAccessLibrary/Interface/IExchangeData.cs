using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IExchangeData
    {
        Task<List<Exchange>> GetExchanges();
        Task InsertExchange(Exchange exchange);
    }
}