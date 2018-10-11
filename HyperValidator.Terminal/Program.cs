using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using HyperValidator.Core.Configuration;
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
			Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

			start:
			Console.Clear();

			var banner1 = new ConsoleBanner("HYPERSPIN VALIDATOR", "Arial", 8, FontStyle.Bold, 150, 14) { ForeColor = ConsoleColor.Blue, Pallet = new Char[] { '#', '%', 'M', 'V', 'l', ',', '.', ' ' } };
			banner1.Execute();

			var systemRepository = Kernel.Get<ISystemRepository>();
			var hyperSpin = systemRepository.Get();

			var menu = new ConsoleMenuList
			{
				GridWidth = 4,
				ItemWidth = 40,
				BorderStyle = ConsoleBorderStyle.SingleDouble
			};

			foreach (var console in hyperSpin.Consoles)
				menu.Items.Add(new ConsoleListItem(console.Name, console));

			menu.Execute();
			TestConsoleRepository(menu.SelectedItem.Text);
			goto start;
		}

		/// <summary>
		/// Tests the console repository.
		/// </summary>
		/// <param name="consoleName">Name of the console.</param>
		static void TestConsoleRepository(String consoleName)
		{
			try
			{
				refresh:

				Console.Clear();
				new ConsoleBanner(consoleName, "Arial", 8, FontStyle.Bold, 150, 14) {ForeColor = ConsoleColor.Cyan, Pallet = new [] {'#', '%', 'M', 'V', 'l', ',', '.', ' '} }.Execute();
				Console.WriteLine("Validating Console Data");

				var settings = Kernel.Get<IHyperValidatorSettings>();
				var repo = Kernel.Get<IConsoleRepository>();
				var console = repo.Get(consoleName);

				foreach (var game in console.Database.Games)
				{
					if (settings.ValidateArtwork1)
					{
						Console.ForegroundColor = game.Status.Artwork1.HasValue && game.Status.Artwork1.Value ? ConsoleColor.Green : ConsoleColor.Red;
						Console.Write("A1 ");
					}

					if (settings.ValidateArtwork2)
					{
						Console.ForegroundColor = game.Status.Artwork2.HasValue && game.Status.Artwork2.Value ? ConsoleColor.Green : ConsoleColor.Red;
						Console.Write("A2 ");
					}

					if (settings.ValidateArtwork3)
					{
						Console.ForegroundColor = game.Status.Artwork3.HasValue && game.Status.Artwork3.Value ? ConsoleColor.Green : ConsoleColor.Red;
						Console.Write("A3 ");
					}

					if (settings.ValidateArtwork4)
					{
						Console.ForegroundColor = game.Status.Artwork4.HasValue && game.Status.Artwork4.Value ? ConsoleColor.Green : ConsoleColor.Red;
						Console.Write("A4 ");
					}


					if (settings.ValidateBackgrounds)
					{
						Console.ForegroundColor = game.Status.Background.HasValue && game.Status.Background.Value ? ConsoleColor.Green : ConsoleColor.Red;
						Console.Write("B ");
					}

					if (settings.ValidateRoms)
					{
						Console.ForegroundColor = game.Status.Rom.HasValue && game.Status.Rom.Value ? ConsoleColor.Green : ConsoleColor.Red;
						Console.Write("R ");

					}

					if (settings.ValidateThemes)
					{
						Console.ForegroundColor = game.Status.Theme.HasValue && game.Status.Theme.Value ? ConsoleColor.Green : ConsoleColor.Red;
						Console.Write("T ");
					}

					if (settings.ValidateVideos)
					{
						Console.ForegroundColor = game.Status.Video.HasValue && game.Status.Video.Value ? ConsoleColor.Green : ConsoleColor.Red;
						Console.Write("V ");
					}

					if (settings.ValidateWheelArt)
					{
						Console.ForegroundColor = game.Status.WheelArt.HasValue && game.Status.WheelArt.Value ? ConsoleColor.Green : ConsoleColor.Red;
						Console.Write("W ");

					}

					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine(game.Name);
				}

				var menu = new ConsoleMenuList
				{
					GridWidth = 2,
					ItemWidth = 40,
					BorderStyle = ConsoleBorderStyle.SingleDouble
				};

				menu.Items.Add(new ConsoleListItem("Refresh", "Refresh"));
				menu.Items.Add(new ConsoleListItem("Main Menu", "Main Menu"));

				menu.Execute();

				if (menu.SelectedItem.Text == "Refresh")
					goto refresh;

			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("[ERROR] An error occurred while getting validating this console.");
				Console.WriteLine(ex.Message);
				Console.ForegroundColor = ConsoleColor.White;
			}


		}

	}

}
 