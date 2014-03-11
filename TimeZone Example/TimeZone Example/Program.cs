using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime localnow = DateTime.Now;
            Console.WriteLine("{0}-{1}-{2}" ,localnow, localnow.Kind, TimeZone.CurrentTimeZone.StandardName);
            DateTime utcnow=DateTime.UtcNow;
            Console.WriteLine("{0}-{1}", utcnow, utcnow.Kind);
            System.Console.ReadKey();
        }
    }
}
