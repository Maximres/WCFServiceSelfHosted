using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWCF.Services
{
	[ServiceContract]
	public interface IContractService
	{
		[OperationContract]
		int Method(string s);
	}

	public class Service : IContractService
	{
		public int Method(string s)
		{
			Console.WriteLine("Method called. " + s);

			if (s == "test")
				return 0;

			return 1;
		}
	}
}
