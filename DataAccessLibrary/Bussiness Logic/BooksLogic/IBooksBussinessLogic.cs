using DataAccessLibrary.Models;
using System.Collections.Generic;

namespace DataAccessLibrary.Bussiness_Logic
{
    public interface IBooksBussinessLogic
    {
        List<Books> FilterAndSort(List<Books> _list, BooksAtributes atribute, bool accending, object _val);
        List<Books> FilterBooks(List<Books> _list, BooksAtributes atribute, object _val);
        List<Books> MultiFilter(List<Books> _list, string _val);
        List<Books> SortBooks(List<Books> _list, BooksAtributes atribute, bool accending);
    }
}