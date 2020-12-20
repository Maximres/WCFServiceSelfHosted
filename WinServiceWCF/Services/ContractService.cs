using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WinServiceWCF.Services
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
			Debug.WriteLine("Method called. " + s);

			if (s == "test")
				return 0;

			return 1;
		}
	}
}
