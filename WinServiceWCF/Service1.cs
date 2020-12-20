using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using WinServiceWCF.Services;

namespace WinServiceWCF
{

	[RunInstaller(true)]
	public class ProgramInstaller : Installer
	{
		private ServiceProcessInstaller process;
		private ServiceInstaller service;

		public ProgramInstaller()
		{
			process = new ServiceProcessInstaller();
			process.Account = ServiceAccount.LocalSystem;

			service = new ServiceInstaller();
			service.ServiceName = "NTServiceWCF";
			service.Description = "SelfHosted WCF NT Service";
			service.StartType = ServiceStartMode.Automatic;

			Installers.Add(process);
			Installers.Add(service);
		}
	}

	public partial class Service1 : ServiceBase
	{
		ServiceHost host = null;

		public Service1()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
			if (host == null)
			{
				host = new ServiceHost(typeof(Service));
				host.Open();
			}
		}

		protected override void OnStop()
		{
			if (host != null)
			{
				host.Close();
			}
		}
	}
}
