using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperValidator.Core.Repositories;
using HyperValidator.Core.Serialization;
using HyperValidator.Models;
using Ninject;
using Console = System.Console;

namespace HyperValidator.Terminal
{
	class Program
	{

		#region PRIVATE PROPERTIES


		private static IKernel Kernel;


		#endregion PRIVATE PROPERTIES


		/// <summary>
		/// Main entry point for this application.
		/// </summary>
		/// <param name="args">The arguments.</param>
		static void Main(String[] args)
		{
			Kernel = new StandardKernel();
			Dependencies.Register(Kernel);

			Banner.Print();


			TestConsoleRepository();


			Console.WriteLine("Bootstrapped Successfully");
			Console.Read();

		}


		/// <summary>
		/// Tests the console repository.
		/// </summary>
		static void TestConsoleRepository()
		{
			var repo = Kernel.Get<IConsoleRepository>();
			var console = repo.Get("Sammy Atomiswave");

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(console.Name.ToUpper());

			foreach (var game in console.Database.Games)
			{
				Console.ForegroundColor = game.Status.Artwork1 ? ConsoleColor.Green : ConsoleColor.Red;
				Console.Write("A1 ");
				Console.ForegroundColor = game.Status.Artwork2 ? ConsoleColor.Green : ConsoleColor.Red;
				Console.Write("A2 ");
				Console.ForegroundColor = game.Status.Artwork3 ? ConsoleColor.Green : ConsoleColor.Red;
				Console.Write("A3 ");
				Console.ForegroundColor = game.Status.Artwork4 ? ConsoleColor.Green : ConsoleColor.Red;
				Console.Write("A4 ");
				Console.ForegroundColor = game.Status.Background ? ConsoleColor.Green : ConsoleColor.Red;
				Console.Write("B ");
				Console.ForegroundColor = game.Status.Rom ? ConsoleColor.Green : ConsoleColor.Red;
				Console.Write("R ");
				Console.ForegroundColor = game.Status.Theme ? ConsoleColor.Green : ConsoleColor.Red;
				Console.Write("T ");
				Console.ForegroundColor = game.Status.Video ? ConsoleColor.Green : ConsoleColor.Red;
				Console.Write("V ");
				Console.ForegroundColor = game.Status.WheelArt ? ConsoleColor.Green : ConsoleColor.Red;
				Console.Write("W ");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine(game.Name);
			}

		}

		/// <summary>
		/// Tests the ini deserializer.
		/// </summary>
		static void TestIniDeserializer()
		{
			var serializer = Kernel.Get<IIniSerializer>();
			var ini = serializer.DeserializeFromFile(@"G:\My Drive\media\games\hyperspin\Settings\Settings.ini");
		}

		/// <summary>
		/// Tests the database deserializer.
		/// </summary>
		static void TestDatabaseDeserializer()
		{
			var serializer = Kernel.Get<IDatabaseSerializer>();
			var database = serializer.DeserializeFromFile(@"G:\My Drive\media\games\hyperspin\Databases\Sega Genesis\Sega Genesis.xml");
		}

	}
}
 