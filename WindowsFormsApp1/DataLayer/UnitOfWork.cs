using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataLayer
{
   public class UnitOfWork : IDisposable
   {

       private static dbEntities db;

       public UnitOfWork()
       {
           db = new dbEntities();
       }

        private GenericRepository<CUSTOMERS> _grCustomer;

        public GenericRepository<CUSTOMERS> grCustomer
        {
            get
            {
                if (_grCustomer == null)
                    _grCustomer = new GenericRepository<CUSTOMERS>(db);
                return _grCustomer;
            } 
        }

        private GenericRepository<custgroup> _grCustgroup;

        public GenericRepository<custgroup> grCustgroup
        {
            get
            {
                if (_grCustgroup == null)
                    _grCustgroup = new GenericRepository<custgroup>(db);
                return _grCustgroup;
            }
        }

        private GenericRepository<visitors> _grVisitor;

        public GenericRepository<visitors> grVisitor
        {
            get
            {
                if (_grVisitor == null)
                    _grVisitor = new GenericRepository<visitors>(db);
                return _grVisitor;
            }
        }

        public void insertEntitySP(string code, string special, string mONAME,
            int? group_rdf, int? vis_rdf, string addre, string tell1, decimal? cred,
            int? check_eteb, int? just_naghdi, int? MaxManFactor ,string sharh)
        {
            db.USP_alireza_insert_Customer_test(code, special, mONAME,
                group_rdf, vis_rdf, addre, tell1, cred,
                check_eteb, just_naghdi, MaxManFactor, sharh);
        }


        public void Saveing()
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        public void Dispose()
        {
              db.Dispose();
        }
   }
}
