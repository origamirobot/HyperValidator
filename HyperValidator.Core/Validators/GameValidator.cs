using HyperValidator.Core.Configuration;
using HyperValidator.Core.IO;
using HyperValidator.Core.Logging;
using HyperValidator.Models;
using System;

namespace HyperValidator.Core.Validators
{

	/// <summary>
	/// Defines a contract that all validators must implement.
	/// Responsible for validating games for content and media.
	/// </summary>
	public interface IGameValidator
	{

		/// <summary>
		/// Validates the specified game and returns it's status.
		/// </summary>
		/// <param name="console">The console.</param>
		/// <param name="game">The game.</param>
		/// <returns></returns>
		GameStatus Validate(HyperValidator.Models.Console console, Game game);

	}


	/// <summary>
	/// Responsible for Validating whether certain assets are available for a particular game.
	/// </summary>
	public class GameValidator : IGameValidator
	{

		#region PROTECTED PROPERTIES


		/// <summary>
		/// Gets the logger.
		/// </summary>
		protected ILogger Logger { get; private set; }

		/// <summary>
		/// Gets the settings.
		/// </summary>
		protected IHyperValidatorSettings Settings { get; private set; }

		/// <summary>
		/// Gets the file utility.
		/// </summary>
		protected IFileUtility FileUtility { get; private set; }

		/// <summary>
		/// Gets the directory utility.
		/// </summary>
		protected IDirectoryUtility DirectoryUtility { get; private set; }

		/// <summary>
		/// Gets the path utility.
		/// </summary>
		protected IPathUtility PathUtility { get; private set; }


		#endregion PROTECTED PROPERTIES

		#region CONSTRUCTORS


		/// <summary>
		/// Initializes a new instance of the <see cref="GameValidator"/> class.
		/// </summary>
		/// <param name="logger">The logger.</param>
		/// <param name="settings">The settings.</param>
		/// <param name="fileUtility">The file utility.</param>
		/// <param name="directoryUtility">The directory utility.</param>
		/// <param name="pathUtility">The path utility.</param>
		public GameValidator(
			ILogger logger, 
			IHyperValidatorSettings settings, 
			IFileUtility fileUtility, 
			IDirectoryUtility directoryUtility, 
			IPathUtility pathUtility)
		{
			Logger = logger;
			Settings = settings;
			FileUtility = fileUtility;
			DirectoryUtility = directoryUtility;
			PathUtility = pathUtility;
		}


		#endregion CONSTRUCTORS

		#region PROTECTED METHODS


		/// <summary>
		/// Validates the Artwork1 folder.
		/// </summary>
		/// <param name="console">The console.</param>
		/// <param name="game">The game.</param>
		/// <returns></returns>
		protected virtual Boolean? ValidateArtwork1(HyperValidator.Models.Console console, Game game)
		{
			if (!Settings.ValidateArtwork1)
				return null;

			var location = PathUtility.Combine(Settings.HyperSpinRootLocation, "Media", console.Name, "Images\\Artwork1");
			foreach (var fileType in Settings.ImageFileTypes)
			{
				var path = PathUtility.Combine(location, $"{game.Name}.{fileType}");
				if (FileUtility.Exists(path))
					return true;
			}

			return false;
		}

		/// <summary>
		/// Validates the Artwork2 folder.
		/// </summary>
		/// <param name="console">The console.</param>
		/// <param name="game">The game.</param>
		/// <returns></returns>
		protected virtual Boolean? ValidateArtwork2(HyperValidator.Models.Console console, Game game)
		{
			if (!Settings.ValidateArtwork2)
				return null;

			var location = PathUtility.Combine(Settings.HyperSpinRootLocation, "Media", console.Name, "Images\\Artwork2");
			foreach (var fileType in Settings.ImageFileTypes)
			{
				var path = PathUtility.Combine(location, $"{game.Name}.{fileType}");
				if (FileUtility.Exists(path))
					return true;
			}

			return false;
		}

		/// <summary>
		/// Validates the Artwork3 folder.
		/// </summary>
		/// <param name="console">The console.</param>
		/// <param name="game">The game.</param>
		/// <returns></returns>
		protected virtual Boolean? ValidateArtwork3(HyperValidator.Models.Console console, Game game)
		{
			if (!Settings.ValidateArtwork3)
				return null;

			var location = PathUtility.Combine(Settings.HyperSpinRootLocation, "Media", console.Name, "Images\\Artwork3");
			foreach (var fileType in Settings.ImageFileTypes)
			{
				var path = PathUtility.Combine(location, $"{game.Name}.{fileType}");
				if (FileUtility.Exists(path))
					return true;
			}

			return false;
		}

		/// <summary>
		/// Validates the Artwork4 folder.
		/// </summary>
		/// <param name="console">The console.</param>
		/// <param name="game">The game.</param>
		/// <returns></returns>
		protected virtual Boolean? ValidateArtwork4(HyperValidator.Models.Console console, Game game)
		{
			if (!Settings.ValidateArtwork4)
				return null;

			var location = PathUtility.Combine(Settings.HyperSpinRootLocation, "Media", console.Name, "Images\\Artwork4");
			foreach (var fileType in Settings.ImageFileTypes)
			{
				var path = PathUtility.Combine(location, $"{game.Name}.{fileType}");
				if (FileUtility.Exists(path))
					return true;
			}

			return false;
		}

		/// <summary>
		/// Validates the Video folder.
		/// </summary>
		/// <param name="console">The console.</param>
		/// <param name="game">The game.</param>
		/// <returns></returns>
		protected virtual Boolean? ValidateVideo(HyperValidator.Models.Console console, Game game)
		{
			if (!Settings.ValidateVideos)
				return null;

			foreach (var fileType in Settings.VideoFileTypes)
			{
				var location = PathUtility.Combine(Settings.HyperSpinRootLocation, "Media", console.Name, "Video");
				location = PathUtility.Combine(location, $"{game.Name}.{fileType}");
				if (FileUtility.Exists(location))
					return true;
			}

			return false;
		}

		/// <summary>
		/// Validates the Video folder.
		/// </summary>
		/// <param name="console">The console.</param>
		/// <param name="game">The game.</param>
		/// <returns></returns>
		protected virtual Boolean? ValidateTheme(HyperValidator.Models.Console console, Game game)
		{
			if (!Settings.ValidateThemes)
				return null;

			foreach (var fileType in Settings.ThemeFileTypes)
			{
				var location = PathUtility.Combine(Settings.HyperSpinRootLocation, "Media", console.Name, "Themes");
				location = PathUtility.Combine(location, $"{game.Name}.{fileType}");
				if (FileUtility.Exists(location))
					return true;
			}

			return false;
		}

		/// <summary>
		/// Validates the wheel art folder.
		/// </summary>
		/// <param name="console">The console.</param>
		/// <param name="game">The game.</param>
		/// <returns></returns>
		protected virtual Boolean? ValidateWheelArt(HyperValidator.Models.Console console, Game game)
		{
			if (!Settings.ValidateWheelArt)
				return null;

			foreach (var fileType in Settings.ImageFileTypes)
			{
				var location = PathUtility.Combine(Settings.HyperSpinRootLocation, "Media", console.Name, "Images\\Wheel");
				location = PathUtility.Combine(location, $"{game.Name}.{fileType}");
				if (FileUtility.Exists(location))
					return true;
			}

			return false;
		}

		/// <summary>
		/// Validates the background folder.
		/// </summary>
		/// <param name="console">The console.</param>
		/// <param name="game">The game.</param>
		/// <returns></returns>
		protected virtual Boolean? ValidateBackground(HyperValidator.Models.Console console, Game game)
		{
			if (!Settings.ValidateBackgrounds)
				return null;

			foreach (var fileType in Settings.ImageFileTypes)
			{
				var location = PathUtility.Combine(Settings.HyperSpinRootLocation, "Media", console.Name, "Images\\Backgrounds");
				location = PathUtility.Combine(location, $"{game.Name}.{fileType}");
				if (FileUtility.Exists(location))
					return true;
			}

			return false;
		}

		/// <summary>
		/// Validates the rom.
		/// </summary>
		/// <param name="console">The console.</param>
		/// <param name="game">The game.</param>
		/// <returns></returns>
		protected virtual Boolean? ValidateRom(HyperValidator.Models.Console console, Game game)
		{
			if (!Settings.ValidateRoms)
				return null;

			foreach (var fileType in Settings.RomFileTypes)
			{
				var location = PathUtility.Combine(Settings.RomLocation, console.Name);
				location = PathUtility.Combine(location, $"{game.Name}.{fileType}");
				if (FileUtility.Exists(location))
					return true;
			}

			return false;
		}



		#endregion PROTECTED METHODS

		#region PUBLIC METHODS


		/// <summary>
		/// Validates all of the assets associated with a game in Hyperspin.
		/// </summary>
		/// <param name="console">The console.</param>
		/// <param name="game">The game.</param>
		/// <returns></returns>
		public GameStatus Validate(HyperValidator.Models.Console console, Game game)
		{
			var status = new GameStatus()
			{
				Artwork1 = ValidateArtwork1(console, game),
				Artwork2 = ValidateArtwork2(console, game),
				Artwork3 = ValidateArtwork3(console, game),
				Artwork4 = ValidateArtwork4(console, game),
				Rom = ValidateRom(console, game),
				Theme = ValidateTheme(console, game),
				Video = ValidateVideo(console, game),
				WheelArt = ValidateWheelArt(console, game),
				Background = ValidateBackground(console, game)
			};
			return status;
		}


		#endregion PUBLIC METHODS

	}

}
