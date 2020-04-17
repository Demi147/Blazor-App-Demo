using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLibrary.Models;

namespace DataAccessLibrary.Bussiness_Logic.BooksLogic
{
    public class BooksBuyService : IBooksBuyService
    {
        //service varibles
        public Exchange exchange { get; private set; } = new Exchange();

        //steps
        //Add user to exchange
        public void addSalesNumber(int _num)
        {
            exchange.SalesNumber = _num;
        }
        //Add book id to exchange
        public void addUser(int _num)
        {
            exchange.UserID = _num;
        }

        //To reset the Service
        public void Flush()
        {
            exchange = new Exchange();
        }

    }
}
