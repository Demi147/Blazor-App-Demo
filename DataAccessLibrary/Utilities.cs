using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary
{
    enum Atributes
    {
        test
    }
    public enum BooksAtributes
    {
        Title,
        Price
    }

    public static class Utilities
    {
        //Check if generic list contains an item
        public static bool CheckIfContains<T>(List<T> _list,T _item) where T:TestInterface
        {
            foreach (var item in _list)
            {
                if (item.isEqualTo(_item))
                {
                    return true;
                }
            }

            return false;
        }

    }

    public interface TestInterface
    {
        bool isEqualTo(object _item);
    }
}
