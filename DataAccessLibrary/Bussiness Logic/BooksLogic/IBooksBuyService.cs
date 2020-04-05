using DataAccessLibrary.Models;

namespace DataAccessLibrary.Bussiness_Logic.BooksLogic
{
    public interface IBooksBuyService
    {
        Exchange exchange { get; }

        void addSalesNumber(int _num);
        void addUser(int _num);
        void Flush();
    }
}