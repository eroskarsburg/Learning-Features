using System;
using System.Collections.Generic;

namespace Testing.POO_3.A13
{
	public abstract class Database
	{
		public abstract string ConnectionString { get; set; }

		public Database() { }

		public abstract void Connect();
		public abstract void Disconnect();
	}
}
