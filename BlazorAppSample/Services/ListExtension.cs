using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BlazorAppSample.Services
{
    internal static class ListExtension
    {
        private static Func<T, object> GetOrderByExpression<T>(string sortColumn)
        {
            Func<T, object>? orderByExpr = null;
            if (!String.IsNullOrEmpty(sortColumn))
            {
                // TickerModel
                Type sponsorResultType = typeof(T);

                if (sponsorResultType.GetProperties().Any(prop => prop.Name == sortColumn))
                {
                    PropertyInfo? pinfo = sponsorResultType.GetProperty(sortColumn);
                    orderByExpr = (data => pinfo.GetValue(data, null));
                }
            }
            return orderByExpr;
        }

        private static List<T> OrderByDir<T>(IEnumerable<T> source, string dir, Func<T, object> OrderByColumn)
        {
            return dir.ToUpper() == "DESCENDING" ? source.OrderByDescending(OrderByColumn).ToList() : source.OrderBy(OrderByColumn).ToList();
        }

        public static List<T> GetSortedList<T>(this List<T> source,string sortname,string direction)
        {
            var orderByExpression = GetOrderByExpression<T>(sortname);

            var data = OrderByDir<T>(source, direction, orderByExpression);
            return data;
        }
    }
}
