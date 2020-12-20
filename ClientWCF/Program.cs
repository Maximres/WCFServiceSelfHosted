using ClientWCF.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClientWCF
{
	class Program
	{
		private const string URI = "http://localhost:8000/ServiceWCF";

		static void Main(string[] args)
		{
			Console.Title = "CLIENT";

			using (var channelFactory = new ChannelFactory<IContractService>(new BasicHttpBinding(), new EndpointAddress(URI)))
			{
				var service = channelFactory.CreateChannel();

				var result = service.Method("test");

				Console.WriteLine($"Result: \"{result}\"");

				Console.WriteLine("Press any key...");
				Console.ReadKey();
			}
		}
	}
}
