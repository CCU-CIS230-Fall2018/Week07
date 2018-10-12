using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Birthday { get; set; }
		public double Salary { get; set; }
		public int RandNum { get; set; }

		public string FullName()
		{
			return $"{this.FirstName} {this.LastName}";
		}

		// this does not actually upload to database
		// its just to similate a long task
		internal void UploadToDatabase()
		{
			Console.WriteLine($"{this.LastName} Upload Started");
			Thread.Sleep(this.RandNum);
			Console.WriteLine($"{this.FullName().ToString()} has been uploaded!");
			Console.WriteLine($"Completed in {this.RandNum/1000.0} seconds");
		}



	}
}
