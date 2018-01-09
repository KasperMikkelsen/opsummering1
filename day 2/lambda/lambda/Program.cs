using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    class Program
    {
        delegate int NumberDelegat(int input); 
        static void Main(string[] args)
        {
            NumberDelegat timesTwo = x => x * 2;
            Console.WriteLine(timesTwo(7));
            Console.ReadLine();
            
        }
    }
}
