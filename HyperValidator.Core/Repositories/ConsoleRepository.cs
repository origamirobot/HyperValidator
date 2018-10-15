using HyperValidator.Core.Configuration;
using HyperValidator.Core.IO;
using HyperValidator.Core.Logging;
using HyperValidator.Core.Serialization;
using HyperValidator.Core.Validators;
using System;
using HyperValidator.Models;

namespace HyperValidator.Core.Repositories
{

	/// <summary>
	/// Responsible for pull all data about a particular console and stuffing it into an object.
	/// </summary>
	/// <seealso cref="HyperValidator.Core.Repositories.IConsoleRepository" />
	public interface IConsoleRepository
	{

		/// <summary>
		/// Gets the specified console using it's name as an identifier.
		/// </summary>
		/// <param name="name">The name of the console to get.</param>
		/// <param name="validate">if set to <c>true</c> [validate].</param>
		/// <returns></returns>
		HyperValidator.Models.Console Get(String name, Boolean validate = false);

		/// <summary>
		/// Occurs when a game is validated.
		/// </summary>
		event EventHandler<GameStatus> GameValidated;

		/// <summary>
		/// Occurs when [validation complete].
		/// </summary>
		event EventHandler ValidationComplete;

	}

	/// <summary>
	/// Responsible for pull all data about a particular console and stuffing it into an object.
	/// </summary>
	/// <seealso cref="HyperValidator.Core.Repositories.IConsoleRepository" />
	public class ConsoleRepository : IConsoleRepository
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
		/// Gets the database serializer.
		/// </summary>
		protected IDatabaseSerializer DatabaseSerializer { get; private set; }

		/// <summary>
		/// Gets the settings.
		/// </summary>
		protected IHyperValidatorSettings Settings { get; private set; }

		/// <summary>
		/// Gets the game validator.
		/// </summary>
		protected IGameValidator GameValidator { get; private set; }

		/// <summary>
		/// Gets the console validator.
		/// </summary>
		protected IConsoleValidator ConsoleValidator { get; private set; }



		#endregion PROTECTED PROPERTIES

		#region CONSTRUCTORS


		/// <summary>
		/// Initializes a new instance of the <see cref="ConsoleRepository" /> class.
		/// </summary>
		/// <param name="settings">The settings.</param>
		/// <param name="logger">The logger.</param>
		/// <param name="directoryUtility">The directory utility.</param>
		/// <param name="fileUtility">The file utility.</param>
		/// <param name="pathUtility">The path utility.</param>
		/// <param name="consoleSerializer">The console serializer.</param>
		/// <param name="databaseSerializer">The database serializer.</param>
		/// <param name="gameValidator">The game validator.</param>
		/// <param name="consoleValidator">The console validator.</param>
		public ConsoleRepository(
			IHyperValidatorSettings settings, 
			ILogger logger, 
			IDirectoryUtility directoryUtility, 
			IFileUtility fileUtility, 
			IPathUtility pathUtility, 
			IConsoleSerializer consoleSerializer, 
			IDatabaseSerializer databaseSerializer, 
			IGameValidator gameValidator, 
			IConsoleValidator consoleValidator)
		{
			Settings = settings;
			Logger = logger;
			DirectoryUtility = directoryUtility;
			FileUtility = fileUtility;
			PathUtility = pathUtility;
			ConsoleSerializer = consoleSerializer;
			DatabaseSerializer = databaseSerializer;
			GameValidator = gameValidator;
			ConsoleValidator = consoleValidator;
		}


		#endregion CONSTRUCTORS

		#region PROTECTED METHODS


		/// <summary>
		/// Called when [game validated].
		/// </summary>
		/// <param name="status">The status.</param>
		protected virtual void OnGameValidated(GameStatus status)
		{
			this.GameValidated?.Invoke(this, status);
		}

		/// <summary>
		/// Called when [validation complete].
		/// </summary>
		protected virtual void OnValidationComplete()
		{
			this.ValidationComplete?.Invoke(this, EventArgs.Empty);
		}



		#endregion PROTECTED METHODS

		#region PUBLIC METHODS


		/// <summary>
		/// Gets the specified console using it's name as an identifier.
		/// </summary>
		/// <param name="name">The name of the console to get.</param>
		/// <param name="validate">if set to <c>true</c> [validate].</param>
		/// <returns></returns>
		/// <exception cref="Exception"></exception>
		public HyperValidator.Models.Console Get(String name, Boolean validate = false)
		{
			var console = new HyperValidator.Models.Console() { Name = name };

			var databasePath = PathUtility.Combine(Settings.HyperSpinRootLocation, "databases", console.Name, $"{console.Name}.xml");
			var database = DatabaseSerializer.DeserializeFromFile(databasePath);
			console.Database = database;

			var settingsPath = PathUtility.Combine(Settings.HyperSpinRootLocation, "settings", $"{console.Name}.ini");
			if (!FileUtility.Exists(settingsPath))
				throw new Exception($"Failed to find settings file for {name}");

			var settings = ConsoleSerializer.DeserializeFromFile(settingsPath);
			console.Settings = settings;

			console.Status = ConsoleValidator.Validate(console);

			if (validate)
			{
				foreach (var game in console.Database.Games)
				{
					var status = GameValidator.Validate(console, game);
					OnGameValidated(status);
					game.Status = status;
				}
				OnValidationComplete();
			}

			return console;
		}


		#endregion PUBLIC METHODS


		#region PUBLIC EVENTS


		/// <summary>
		/// Occurs when a game is validated.
		/// </summary>
		public event EventHandler<GameStatus> GameValidated;

		/// <summary>
		/// Occurs when [validation complete].
		/// </summary>
		public event EventHandler ValidationComplete;


		#endregion PUBLIC EVENTS


	}

}
