using TheSchool.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;

namespace TheSchool
{
	class Program
	{
		static List<Reference> References { get; set; } = new List<Reference>();
		class Reference { public int Number { get; set; } }
		struct Value { public int Number { get; set; } }

		static void ChangeNumber(ref Reference obj)
		{
			obj = new Reference() { Number = 44 };
		}

		static void ChangeNumber(ref Value obj)
		{
			obj.Number++;
		}

		static void KillRam()
		{
			for (int j = 0; j < int.MaxValue; j++)
			{
				for (int i = 0; i < int.MaxValue; i++)
				{
					References.Add(new Reference());
				}
			}
			KillRam();
		}

		static void Main(string[] args)
		{
			//KillRam();
			Console.WriteLine(Thread.CurrentThread.Name + "-" + Thread.CurrentThread.ManagedThreadId);

			var x = new Thread(obj => { Console.WriteLine(Thread.CurrentThread.Name + "-" + Thread.CurrentThread.ManagedThreadId); });
			x.Start();

			//var obj = new Reference() { Number = 99 };
			//ChangeNumber(ref obj);

			//var obj2 = new Value() { Number = 99 };
			//ChangeNumber(ref obj2);


			//try
			//{
			//	Throw();
			//}
			//catch (FileNotFoundException e)
			//{
			//	//skfskd
			//}
			//catch(StackOverflowException)
			//{

			//}
			Console.ReadKey();
		}

		private static void Throw()
		{
			try
			{
				File.ReadAllText("C:\\Projects\\Test\\file.txt");
				//Throw2(0);
				//ValidateUserCredentials("username", null);
				return;
			}
			catch (SuperPasswordException e)
			{
				Console.WriteLine($"Super password is invalid: {e.Message}");
			}
			catch (UsernameException e)
			{
				Console.WriteLine($"Username is invalid: {e.Message}");
			}
			catch (PasswordException e)
			{
				Console.WriteLine($"Password is invalid: {e.Message}");
			}
			//catch (Exception e)
			//{
			//	Console.WriteLine($"An unhandled exception occurred: {e.Message}, {e.GetType().Name}");
			//}
			finally
			{
				Console.WriteLine("Finally executed");
			}
		}

		private static void Throw2(int i)
		{
			var x = 8 / i;
		}

		public static void ValidateUserCredentials(string username, string password)
		{
			if (string.IsNullOrEmpty(username)) throw new UsernameException("Invalid username");
			if (string.IsNullOrWhiteSpace(password)) throw new SuperPasswordException("Invalid password");
		}

		class UsernameException : Exception
		{
			public UsernameException(string message)
				: base(message)
			{
			}
		}

		class PasswordException : Exception
		{
			public PasswordException(string message)
				: base(message)
			{
			}
		}

		class SuperPasswordException : PasswordException
		{
			public SuperPasswordException(string message)
				: base(message)
			{
			}
		}
	}
}
