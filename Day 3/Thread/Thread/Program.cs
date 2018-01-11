using System;
using System.Threading;

namespace Program

{

    class MakeingAThread
    {

        static void Main(string[] args)
        {
            ThreadStart t1ref = new ThreadStart(Thread1);
            Thread thread1 = new Thread(t1ref);
            thread1.Start();
            ThreadStart t2ref = new ThreadStart(Thread2);
            Thread thread2 = new Thread(t2ref);
            thread2.Start();
            Console.ReadKey();
        }
        public static void Thread1()
        {
            Console.WriteLine("t1 starts");
        }

        public static void Thread2()
        {
            Console.WriteLine("t2 starts");
        }
    }

}