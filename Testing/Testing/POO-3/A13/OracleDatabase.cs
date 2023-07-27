using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.POO_3.A13
{
	public class OracleDatabase : Database
	{
		public override string ConnectionString { get; set; }

		public override void Connect()
		{
			Console.WriteLine("Connecting to Oracle database.");
		}

		public override void Disconnect()
		{
			Console.WriteLine("Disconnecting from Oracle database.");
		}
	}
}
