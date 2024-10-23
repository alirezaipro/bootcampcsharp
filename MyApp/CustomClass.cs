using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class CustomClass
    {
        public async Task Method1()
        {
            Console.WriteLine("Start Method1 proccessing ....");

           await Task.Delay(15000);

            Console.WriteLine("Finish Method1 proccessing ....");
        }

        public async Task<int> Method2()
        {
            Console.WriteLine("Start Method2 proccessing ....");

           await Task.Delay(12000);

            Console.WriteLine("Finish Method2 proccessing ....");

            return 0;
        }
    }
}
