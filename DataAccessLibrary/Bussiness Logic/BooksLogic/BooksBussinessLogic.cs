using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
using System.Linq;

namespace DataAccessLibrary.Bussiness_Logic
{
    public class BooksBussinessLogic : IBooksBussinessLogic
    {
        public List<Books> SortBooks(List<Books> _list, BooksAtributes atribute, bool accending)
        {
            var x = _list;

            var y = new List<Books>();

            switch (atribute)
            {
                case BooksAtributes.BookTitle:
                    if (accending)
                    {
                        x = x.OrderBy(q => q.BookTitle).ToList();
                    }
                    else
                    {
                        x = x.OrderByDescending(q => q.BookTitle).ToList();
                    }
                    break;
                case BooksAtributes.BookEdition:
                    if (accending)
                    {
                        x = x.OrderBy(q => q.BookEdition).ToList();
                    }
                    else
                    {
                        x = x.OrderByDescending(q => q.BookEdition).ToList();
                    }
                    break;
                case BooksAtributes.BookPrice:
                    if (accending)
                    {
                        x = x.OrderBy(q => q.BookPrice).ToList();
                    }
                    else
                    {
                        x = x.OrderByDescending(q => q.BookPrice).ToList();
                    }
                    break;
                case BooksAtributes.ModuleCode:
                    if (accending)
                    {
                        x = x.OrderBy(q => q.ModuleCode).ToList();
                    }
                    else
                    {
                        x = x.OrderByDescending(q => q.ModuleCode).ToList();
                    }
                    break;
                case BooksAtributes.BooksInstitute:
                    if (accending)
                    {
                        x = x.OrderBy(q => q.BooksInstitute).ToList();
                    }
                    else
                    {
                        x = x.OrderByDescending(q => q.BooksInstitute).ToList();
                    }
                    break;
                default:
                    break;
            }

            return x;
        }

        public List<Books> FilterBooks(List<Books> _list, BooksAtributes atribute, object _val)
        {
            var x = _list;

            var y = new List<Books>();

            switch (atribute)
            {
                case BooksAtributes.BookTitle:
                    x = x.Where(q => q.BookTitle.ToLower().Contains(((string)_val).ToLower())).ToList();
                    break;
                case BooksAtributes.BookEdition:
                    x = x.Where(q => q.BookEdition.ToString().Contains((string)_val)).ToList();
                    break;
                case BooksAtributes.BookPrice:
                    try
                    {
                        x = x.Where(q => q.BookPrice < int.Parse((string)_val)).ToList();
                    }
                    catch
                    {
                        break;
                    }
                    break;
                case BooksAtributes.ModuleCode:
                    x = x.Where(q => q.ModuleCode.ToLower().Contains(((string)_val).ToLower())).ToList();
                    break;
                case BooksAtributes.BooksInstitute:
                    x = x.Where(q => q.BooksInstitute.ToLower().Contains(((string)_val).ToLower())).ToList();
                    break;
                default:
                    break;
            }

            return x;
        }

        public List<Books> FilterAndSort(List<Books> _list, BooksAtributes atribute, bool accending, object _val)
        {
            var x = FilterBooks(SortBooks(_list, atribute, accending), atribute, _val);

            return x;
        }

        public List<Books> MultiFilter(List<Books> _list, string _val)
        {
            var temp = new List<Books>();

            foreach (var item in _list)
            {
                if (item.CheckIfContains(_val))
                {
                    temp.Add(item);
                }
            }
            return temp;
        }
    }
}
