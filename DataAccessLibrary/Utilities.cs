using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary
{
    public static class Utilities
    {
        //Check if generic list contains an item
        public static bool CheckIfContains<T>(List<T> _list,T _item) where T:TestInterface
        {

            return false;
        }
    }

    public interface TestInterface
    {
        
    }
}
