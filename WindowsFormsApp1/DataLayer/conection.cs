using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataLayer
{
    public class conection
    {
        public static List<cust_act> returnAllCustact()
        {

            using (var context = new dbEntities())
            {
                return context.cust_act.Include(c => c.CUSTOMERS).ToList();
            }
        }

        public static int getMaxID(Expression<Func<CUSTOMERS, int>> max)
        {
            using (var context = new dbEntities())
            {
                return context.CUSTOMERS.Any() ? context.CUSTOMERS.Max(max) : 0;
            }
        }
        public static int getMaxID()
        {
            using (var context = new dbEntities())
            {
                return context.CUSTOMERS.Any() ? context.CUSTOMERS.Max(a => a.SHMO) : 0;
            }
        }
        public static List<T> get<T>(Expression<Func<T, bool>> where = null,
            Expression<Func<T, int>> orderBy = null
            , bool firstOrLirst = true, int? top = null) where T : class
        {
            using (var context = new dbEntities())
            {

                IQueryable<T> result = context.Set<T>();
                if (where != null)
                {
                    result = result.Where(where);
                }

                if (orderBy != null)
                {
                    if (firstOrLirst)
                        result = result.OrderBy(orderBy);
                    else
                        result = result.OrderByDescending(orderBy);
                }

                if (top != null)
                {
                    result = result.Take((int)top);
                }

                return result.ToList();
            }
        }

        public static void insert<T>(T Tentity) where T : class
        {
            using (var context = new dbEntities())
            {
                context.Set<T>().Add(Tentity);
                context.SaveChanges();
            }
        }

        public static void insertEntitySP(string code, string special, string mONAME,
            int? group_rdf, int? vis_rdf, string addre, string tell1, decimal? cred,
            int? check_eteb, int? just_naghdi, int? MaxManFactor, string sharh)
        {
            using (var context = new dbEntities())
            {

                context.USP_alireza_insert_Customer_test(code, special, mONAME,
                    group_rdf, vis_rdf, addre, tell1, cred,
                    check_eteb, just_naghdi, MaxManFactor, sharh);
            }
        }

        public static List<visitors> functionVis(int? visId)
        {
            List<visitors> vis = new List<visitors>();
            using (var context = new dbEntities())
            {
                visitors result = context.visitors.Where(v => v.vis_rdf == visId).FirstOrDefault();
                vis.Add(result);
                if (result.supervisor_rdf != 0)
                {
                    vis.AddRange(functionVis(result.supervisor_rdf));
                }
            }
            return vis;
        }

    }
}
