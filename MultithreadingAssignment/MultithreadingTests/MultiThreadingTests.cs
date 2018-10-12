using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multithreading;

namespace MultithreadingTests
{
	[TestClass]
	public class PersonTests

	{
		string test1 = "name";
		string test2 = "last";
		string test3 = "1/23/1998";
		int test4 = 10000;
		int test5 = 2400;

		[TestMethod]
		public void PersonCreationTest()
		{

			var tester = new Person
			{
				FirstName = test1,
				LastName = test2,
				Birthday = test3,
				Salary = test4,
				RandNum = test5,
			};
			Assert.AreEqual(tester.FirstName, test1);
			Assert.AreEqual(tester.LastName, test2);
			Assert.AreEqual(tester.Birthday, test3);
			Assert.AreEqual(tester.Salary, test4);
			Assert.AreEqual(tester.RandNum, test5);
		}

		[TestMethod]
		public void PersonFullNameMethod()
		{
			var tester = new Person
			{
				FirstName = test1,
				LastName = test2,
				Birthday = test3,
				Salary = test4,
				RandNum = test5,
			};
			Assert.AreEqual((test1 + " " + test2), tester.FullName().ToString());
		}
	}
}
