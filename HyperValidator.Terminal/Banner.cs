using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperValidator.Terminal
{

	/// <summary>
	/// 
	/// </summary>
	public class Banner
	{

		/// <summary>
		/// Prints the banner to the console.
		/// </summary>
		public static void Print()
		{
		
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(@" _   _                                     ");
			Console.WriteLine(@"| | | |                                    ");
			Console.WriteLine(@"| |_| |_   _ _ __   ___ _ __               ");
			Console.WriteLine(@"|  _  | | | | '_ \ / _ \ '__|              ");
			Console.WriteLine(@"| | | | |_| | |_) |  __/ |                 ");
			Console.WriteLine(@"\_| |_/\__, | .__/ \___|_|                 ");
			Console.WriteLine(@"        __/ | |                            ");
			Console.WriteLine(@"       |___/|_|                            ");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine(@" _   _       _ _     _       _             ");
			Console.WriteLine(@"| | | |     | (_)   | |     | |            ");
			Console.WriteLine(@"| | | | __ _| |_  __| | __ _| |_ ___  _ __ ");
			Console.WriteLine(@"| | | |/ _` | | |/ _` |/ _` | __/ _ \| '__|");
			Console.WriteLine(@"\ \_/ / (_| | | | (_| | (_| | || (_) | |   ");
			Console.WriteLine(@" \___/ \__,_|_|_|\__,_|\__,_|\__\___/|_|   ");
			Console.WriteLine(@"");
			Console.ForegroundColor = ConsoleColor.White;
		}

	}

}
