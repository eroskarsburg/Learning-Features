using System;
using System.Collections.Generic;

namespace Testing.POO_3.A13
{
	public class MySqlDatabase : Database
	{
		public override string ConnectionString { get; set; }

		public override void Connect()
		{
			Console.WriteLine("Connecting to MySql database.");
		}

		public override void Disconnect()
		{
            Console.WriteLine("Disconnecting from MySql database.");
        }
	}
}
