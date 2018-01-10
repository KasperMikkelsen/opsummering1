using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda2
{
    class Program
    {
        delegate float NumberDelegate(float x, float y, float z);
        static void Main(string[] args)
        {
            
            NumberDelegate addOn = (x, y , z) => x + y + z;
            Console.WriteLine(addOn(2.3f , 3.5f, 4.8f));
            Console.ReadKey();
        }
    }
}
