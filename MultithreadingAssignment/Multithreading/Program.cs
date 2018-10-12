using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.DirectoryServices.AccountManagement;

namespace Multithreading
{
	class Program
	{
		static void Main(string[] args)
		{
			// Shoutout to stack overflow
			UserPrincipal user = UserPrincipal.Current;
			Console.WriteLine($"Hello {user.DisplayName}");

			Random rnd = new Random();
			int time1 = rnd.Next(1000, 3500);
			int time2 = rnd.Next(1000, 3502);
			int time3 = rnd.Next(1000, 3504);



			Person jarJar = new Person
			{
				FirstName = "Jar Jar",
				LastName = "Binks",
				Birthday = "1/12/1252",
				Salary = 12.50,
				RandNum = time1
			};

			Person kenobi = new Person
			{
				FirstName = "Obi-Wan",
				LastName = "Kenobi",
				Birthday = "2/23/1312",
				Salary = 65000,
				RandNum = time2
			};

			Person anikan = new Person
			{
				FirstName = "Anikan",
				LastName = "Skywalker",
				Birthday = "5/16/1566",
				Salary = 45000,
				RandNum = time3
			};

			var thread1 = new Thread(() => kenobi.UploadToDatabase());
			var thread2 = new Thread(() => jarJar.UploadToDatabase());
			var thread3 = new Thread(() => anikan.UploadToDatabase());
			thread1.Start();
			thread2.Start();
			thread3.Start();

			Console.ReadLine();

		}
	}
}
