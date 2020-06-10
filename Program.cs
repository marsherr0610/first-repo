using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a=int.Parse(Console.ReadLine());

            for (a = 1; a <= 20; a++)
            {
                if((a / 10 + a % 10 )== 5 || (a / 10 + a % 10) == 7 || (a / 10 + a % 10) == 11)
                Console.WriteLine(a);   
            }
        }
    }
}
