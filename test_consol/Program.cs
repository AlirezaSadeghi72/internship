using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_consol
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var ali = new Atiran2Entities();

            var asa = ali.alireza_test.Max(new Func<alireza_test, int?>(test => test.Id));

        }
    }
}
