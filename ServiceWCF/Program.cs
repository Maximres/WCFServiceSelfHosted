using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ServiceWCF.Services;

namespace ServiceWCF
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "SERVER";

			using (var sh = new ServiceHost(typeof(Service)))
			{
				sh.Open();

				Console.WriteLine("Press any key...");
				Console.ReadKey();

				sh.Close();
			}
		}
	}
}
