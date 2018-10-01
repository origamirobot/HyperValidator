using HyperValidator.Core.Configuration;
using HyperValidator.Core.IO;
using HyperValidator.Core.Logging;
using HyperValidator.Core.Serialization;
using System;

namespace HyperValidator.Core.Repositories
{

	/// <summary>
	/// Responsible for pull all data about a particular console and stuffing it into an object.
	/// </summary>
	/// <seealso cref="HyperValidator.Core.Repositories.IGameRepository" />
	public interface IGameRepository
	{

		/// <summary>
		/// Gets the specified game using it's name as an identifier.
		/// </summary>
		/// <param name="console">The console.</param>
		/// <param name="name">The name of the game to get.</param>
		/// <returns></returns>
		HyperValidator.Models.Game Get(String console, String name);

	}

	/// <summary>
	/// Responsible for pull all data about a particular game and stuffing it into an object.
	/// </summary>
	/// <seealso cref="HyperValidator.Core.Repositories.IGameRepository" />
	public class GameRepository : IGameRepository
	{

		#region PROTECTED PROPERTIES


		/// <summary>
		/// Gets or sets the logger.
		/// </summary>
		protected ILogger Logger { get; private set; }

		/// <summary>
		/// Gets or sets the directory utility.
		/// </summary>
		protected IDirectoryUtility DirectoryUtility { get; private set; }

		/// <summary>
		/// Gets or sets the file utility.
		/// </summary>
		protected IFileUtility FileUtility { get; private set; }

		/// <summary>
		/// Gets or sets the path utility.
		/// </summary>
		protected IPathUtility PathUtility { get; private set; }

		/// <summary>
		/// Gets or sets the console serializer.
		/// </summary>
		protected IConsoleSerializer ConsoleSerializer { get; private set; }

		/// <summary>
		/// Gets the settings.
		/// </summary>
		protected IHyperValidatorSettings Settings { get; private set; }


		#endregion PROTECTED PROPERTIES

		#region CONSTRUCTORS


		/// <summary>
		/// Initializes a new instance of the <see cref="GameRepository"/> class.
		/// </summary>
		/// <param name="settings">The settings.</param>
		/// <param name="logger">The logger.</param>
		/// <param name="directoryUtility">The directory utility.</param>
		/// <param name="fileUtility">The file utility.</param>
		/// <param name="pathUtility">The path utility.</param>
		/// <param name="consoleSerializer">The console serializer.</param>
		public GameRepository(
			IHyperValidatorSettings settings, 
			ILogger logger, 
			IDirectoryUtility directoryUtility, 
			IFileUtility fileUtility, 
			IPathUtility pathUtility, 
			IConsoleSerializer consoleSerializer)
		{
			Settings = settings;
			Logger = logger;
			DirectoryUtility = directoryUtility;
			FileUtility = fileUtility;
			PathUtility = pathUtility;
			ConsoleSerializer = consoleSerializer;
		}


		#endregion CONSTRUCTORS

		#region PUBLIC METHODS


		/// <summary>
		/// Gets the specified console using it's name as an identifier.
		/// </summary>
		/// <param name="console">The console.</param>
		/// <param name="name">The name of the console to get.</param>
		/// <returns></returns>
		public HyperValidator.Models.Game Get(String console, String name)
		{
			var game = new HyperValidator.Models.Game();

			return game;
		}


		#endregion PUBLIC METHODS

	}

}
