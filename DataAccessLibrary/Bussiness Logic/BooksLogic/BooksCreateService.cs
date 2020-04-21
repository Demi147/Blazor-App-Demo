using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using DataAccessLibrary.Models;

namespace DataAccessLibrary.Bussiness_Logic.BooksLogic
{
    public class BooksCreateService : IBooksCreateService
    {
        public Books book { get; private set; } = new Books();

        public void flush()
        {
            book = new Books();
        }

        public void addUser(int id)
        {
            book.UserID = id;
        }
        public void AddAuthor(string _author)
        {
            book.BookAuthor = _author;
        }
        public void AddBookTitle(string _title)
        {
            book.BookTitle = _title;
        }
        public void AddBookEdition(int ed)
        {
            book.BookEdition = ed;
        }
        public void AddBookPrice(double _price)
        {
            book.BookPrice = _price;
        }
        public void AddBookCode(string _code)
        {
            book.ModuleCode = _code;
        }
        public void AddBookInstitute(string _in)
        {
            book.BookInstitute = _in;
        }
        public void AddBookLocation(int _loc)
        {
            book.LocationID = _loc;
        }

        public void AddBookDate(DateTime _date)
        {
            book.DatePosted = _date;
        }
        public void AddBookImage(byte[] _img)
        {
            book.BookImage = _img;
        }
        public void AddInfo(int _user, string _title, string _author, int _edition, double _price, string _code, string _institute, DateTime _date, byte[] _img)
        {
            book.UserID = _user;
            book.BookTitle = _title;
            book.BookAuthor = _author;
            book.BookEdition = _edition;
            book.BookPrice = _price;
            book.ModuleCode = _code;
            book.BookInstitute = _institute;
            book.DatePosted = _date;
            book.BookImage = _img;
        }

        public void AddInfo(int _user, string _title, string _author, int _edition, double _price, int _loc, string _code, string _institute, DateTime _date, byte[] _img)
        {
            book.UserID = _user;
            book.BookTitle = _title;
            book.BookAuthor = _author;
            book.BookEdition = _edition;
            book.BookPrice = _price;
            book.LocationID = _loc;
            book.ModuleCode = _code;
            book.BookInstitute = _institute;
            book.DatePosted = _date;
            book.BookImage = _img;
        }
        public void AddInfo(Books _model)
        {
            book = _model;
        }
    }
}
