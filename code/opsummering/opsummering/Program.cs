using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opsummering
{
    class Program
    {
        public static int userInput;

        static void Main(string[] args)
        {
            Character character;


            character = new Character("charater");

            Console.WriteLine(character.Person());

            bool loop = true;

            while(loop)
            {
                try
                {
                    userInput = int.Parse(Console.ReadLine().ToLower().Trim());
                }
                catch
                {

                }
                if (userInput == 1)
                {
                    Console.WriteLine("Here is a list of everything about your charecter");
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("This is the end");
                    loop = false;
                }
            }



            Console.ReadLine();
        }
    }
}
