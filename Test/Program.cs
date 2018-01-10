using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultithreadingApplication
{

	class ThreadCreationProgram
	{

		public static void CallToChildThread()
		{
			Console.WriteLine("Help");
		}

		static void Main(string[] args)
		{
			ThreadStart childref = new ThreadStart(CallToChildThread);
			Console.WriteLine("Me Please");
			Thread childThread = new Thread(childref);
			childThread.Start();
			Console.ReadKey();
		}
	}
}