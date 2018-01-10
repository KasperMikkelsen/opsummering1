using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
	class Program
	{
        // lambda expressions
		delegate void NumberDelegat();

		static void Message()
		{
			Console.WriteLine("Hello ");
		}
		static void Main(string[] args)
		{
			//NumberDelegat timesTwo = x => x * 2;
			//Console.WriteLine(timesTwo(40));
			//Console.ReadLine
			NumberDelegat del = Message;
			del();

			NumberDelegat del1 = () => Console.WriteLine("World");
			del1();

            // Anonymous Methods
            NumberDelegat del2 = delegate () { Console.WriteLine("Hello world"); };
			del2();
			Console.ReadKey();
		}
	}
}
