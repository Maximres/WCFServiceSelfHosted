using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClientWCF.Contracts
{

	[ServiceContract]
	public interface IContractService
	{
		[OperationContract]
		int Method(string s);
	}
}
