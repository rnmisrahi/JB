using ModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public static class Repository
    {
        #region Force C# compiler to include EntityFramework.SqlServer.dll in the bin folder

        private static Type _dependency;

        static Repository()
        {
            _dependency = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
        }

        #endregion

        public static IEnumerable<Category> GetCategories()
        {
            NorthwindEntities context = new NorthwindEntities();
            return context.Categories;
        }
    }
}
