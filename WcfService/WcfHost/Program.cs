using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host= new ServiceHost(typeof(WcfService.Contract)))
            {
                host.Open();
                Console.WriteLine("Host open.");
                Console.ReadKey();

            }
        }
    }
}
