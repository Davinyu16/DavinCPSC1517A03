using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using NorthwindSystem.Data;
using NorthwindSystem.DAL;
#endregion

namespace NorthwindSystem.BLL
{
    public class ProductController
    {
        //lookup of data from the database using a non-primary key field
        public List<Product> Products_FindByCategory(int categoryid)
        {
            using (var context = new NorthwindContext())
            {
                //syntax
                //context.Database.SqlQuery<T>("sqlprocname [@parameterid[.@parameterid]]"
                // [, new SqlParameter("parameterid", parametervalue)[,...]]);
                //context.database.sqlquery<T> 
            }
        }
    }
}
