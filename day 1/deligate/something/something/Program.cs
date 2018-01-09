using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace something
{
    class Program
    {
        delegate string SayHello(string s);
        static void Main(string[] args)
        {
            SayHello del = Hello;
            Console.WriteLine("Hello");
           
        }
        static string Hello (string s)
        {
            return s;
        }
    }
}
