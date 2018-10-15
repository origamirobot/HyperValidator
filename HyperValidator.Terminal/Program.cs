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
		private static IConsoleRepository ConsoleRepository;
		private static ISystemRepository SystemRepository;
		private static IHyperValidatorSettings Settings;
		private static HyperSpin HyperSpin;
		private static HyperValidator.Models.Console CurrentConsole;


		#endregion PRIVATE PROPERTIES


		/// <summary>
		/// Main entry point for this application.
		/// </summary>
		/// <param name="args">The arguments.</param>
		static void Main(String[] args)
		{
			Kernel = new StandardKernel();
			Dependencies.Register(Kernel);
			Initialize();
			Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

			start:
			Console.Clear();

			var banner1 = new ConsoleBanner("HYPERSPIN VALIDATOR", "Arial", 8, FontStyle.Bold, 150, 14) { ForeColor = ConsoleColor.Blue, Pallet = new Char[] { '#', '%', 'M', 'V', 'l', ',', '.', ' ' } };
			banner1.Execute();


			var menu = new ConsoleMenuList { GridWidth = 4, ItemWidth = 40, BorderStyle = ConsoleBorderStyle.SingleDouble };

			foreach (var console in HyperSpin.Consoles)
				menu.Items.Add(new ConsoleListItem(console.Name, console));

			menu.Execute();
			CurrentConsole = menu.SelectedValue as HyperValidator.Models.Console;
			TestConsoleRepository(menu.SelectedItem.Text);
			goto start;
		}

		/// <summary>
		/// Initializes this instance.
		/// </summary>
		static void Initialize()
		{
			SystemRepository = Kernel.Get<ISystemRepository>();
			ConsoleRepository = Kernel.Get<IConsoleRepository>();
			Settings = Kernel.Get<IHyperValidatorSettings>();
			HyperSpin = SystemRepository.Get();
			ConsoleRepository.GameValidated += ConsoleRepository_GameValidated;
			ConsoleRepository.ValidationComplete += ConsoleRepository_ValidationComplete;
		}

		/// <summary>
		/// Fires when a game is validated in a console.
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The e.</param>
		private static void ConsoleRepository_GameValidated(Object sender, GameStatus e)
		{
			Console.WriteLine();
			if (Settings.ValidateArtwork1)
			{
				Console.ForegroundColor = e.Artwork1.HasValue && e.Artwork1.Value ? (e.Enabled ? ConsoleColor.Green : ConsoleColor.DarkGreen) : ( e.Enabled ? ConsoleColor.Red : ConsoleColor.DarkRed);
				Console.Write("A1 ");
			}

			if (Settings.ValidateArtwork2)
			{
				Console.ForegroundColor = e.Artwork2.HasValue && e.Artwork2.Value ? (e.Enabled ? ConsoleColor.Green : ConsoleColor.DarkGreen) : (e.Enabled ? ConsoleColor.Red : ConsoleColor.DarkRed);
				Console.Write("A2 ");
			}

			if (Settings.ValidateArtwork3)
			{
				Console.ForegroundColor = e.Artwork3.HasValue && e.Artwork3.Value ? (e.Enabled ? ConsoleColor.Green : ConsoleColor.DarkGreen) : (e.Enabled ? ConsoleColor.Red : ConsoleColor.DarkRed);
				Console.Write("A3 ");
			}

			if (Settings.ValidateArtwork4)
			{
				Console.ForegroundColor = e.Artwork4.HasValue && e.Artwork4.Value ? (e.Enabled ? ConsoleColor.Green : ConsoleColor.DarkGreen) : (e.Enabled ? ConsoleColor.Red : ConsoleColor.DarkRed);
				Console.Write("A4 ");
			}


			if (Settings.ValidateBackgrounds)
			{
				Console.ForegroundColor = e.Background.HasValue && e.Background.Value ? (e.Enabled ? ConsoleColor.Green : ConsoleColor.DarkGreen) : (e.Enabled ? ConsoleColor.Red : ConsoleColor.DarkRed);
				Console.Write("B ");
			}

			if (Settings.ValidateRoms)
			{
				Console.ForegroundColor = e.Rom.HasValue && e.Rom.Value ? (e.Enabled ? ConsoleColor.Green : ConsoleColor.DarkGreen) : (e.Enabled ? ConsoleColor.Red : ConsoleColor.DarkRed);
				Console.Write("R ");

			}

			if (Settings.ValidateThemes)
			{
				Console.ForegroundColor = e.Theme.HasValue && e.Theme.Value ? (e.Enabled ? ConsoleColor.Green : ConsoleColor.DarkGreen) : (e.Enabled ? ConsoleColor.Red : ConsoleColor.DarkRed);
				Console.Write("T ");
			}

			if (Settings.ValidateVideos)
			{
				Console.ForegroundColor = e.Video.HasValue && e.Video.Value ? (e.Enabled ? ConsoleColor.Green : ConsoleColor.DarkGreen) : (e.Enabled ? ConsoleColor.Red : ConsoleColor.DarkRed);
				Console.Write("V ");
			}

			if (Settings.ValidateWheelArt)
			{
				Console.ForegroundColor = e.WheelArt.HasValue && e.WheelArt.Value ? (e.Enabled ? ConsoleColor.Green : ConsoleColor.DarkGreen) : (e.Enabled ? ConsoleColor.Red : ConsoleColor.DarkRed);
				Console.Write("W ");

			}

			Console.ForegroundColor = e.Enabled ? ConsoleColor.White : ConsoleColor.DarkGray;
			Console.Write(e.Name);

		}

		/// <summary>
		/// Handles the ValidationComplete event of the ConsoleRepository control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private static void ConsoleRepository_ValidationComplete(Object sender, EventArgs e)
		{
			Console.WriteLine();
			var menu = new ConsoleMenuList { GridWidth = 2, ItemWidth = 14, BorderStyle = ConsoleBorderStyle.SingleDouble };

			menu.Items.Add(new ConsoleListItem("Refresh", "Refresh"));
			menu.Items.Add(new ConsoleListItem("Main Menu", "Main Menu"));

			menu.Execute();


			if (menu.SelectedItem.Text == "Refresh")
				TestConsoleRepository(CurrentConsole.Name);
		}

		/// <summary>
		/// Tests the console repository.
		/// </summary>
		/// <param name="consoleName">Name of the console.</param>
		static void TestConsoleRepository(String consoleName)
		{
			try
			{
				Console.Clear();
				new ConsoleBanner(consoleName, "Arial", 8, FontStyle.Bold, 150, 14) {ForeColor = ConsoleColor.Cyan, Pallet = new [] {'#', '%', 'M', 'V', 'l', ',', '.', ' '} }.Execute();
				Console.WriteLine("Validating Console Data");


				var console = ConsoleRepository.Get(consoleName);

			}
			catch (Exception ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("[ERROR] An error occurred while getting validating this console.");
				Console.WriteLine(ex.Message);
				Console.ForegroundColor = ConsoleColor.White;

				var menu = new ConsoleMenuList { GridWidth = 2, ItemWidth = 14, BorderStyle = ConsoleBorderStyle.SingleDouble };
				menu.Items.Add(new ConsoleListItem("Refresh", "Refresh"));
				menu.Items.Add(new ConsoleListItem("Main Menu", "Main Menu"));
				menu.Execute();
				if (menu.SelectedItem.Text == "Refresh")
					TestConsoleRepository(CurrentConsole.Name);

			}


		}

	}

}
 