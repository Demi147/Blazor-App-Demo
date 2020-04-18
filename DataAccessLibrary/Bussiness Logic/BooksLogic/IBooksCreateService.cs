using DataAccessLibrary.Models;
using System;

namespace DataAccessLibrary.Bussiness_Logic.BooksLogic
{
    public interface IBooksCreateService
    {
        Books book { get; }

        void AddAuthor(string _author);
        void AddBookCode(string _code);
        void AddBookDate(DateTime _date);
        void AddBookEdition(int ed);
        void AddBookInstitute(string _in);
        void AddBookLocation(int _loc);
        void AddBookPrice(double _price);
        void AddBookTitle(string _title);
        void AddInfo(Books _model);
        void AddInfo(int _user, string _title, int _edition, double _price, int _loc, string _code, string _institute, DateTime _date, string _author);
        void AddInfo(int _user, string _title, int _edition, double _price, string _code, string _institute, DateTime _date, string _author);
        void addUser(int id);
        void flush();
    }
}