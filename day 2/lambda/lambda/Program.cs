using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda2
{
    class Program
    {
        delegate int NumberDelegate(int input);
        static void Main(string[] args)
        {

            NumberDelegate timesTwo = (x => x * 2);
            Console.WriteLine(timesTwo(7));
            Console.ReadLine();
        }
    }
}
