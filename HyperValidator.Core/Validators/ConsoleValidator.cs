using HyperValidator.Core.Configuration;
using HyperValidator.Core.IO;
using HyperValidator.Core.Logging;
using HyperValidator.Models;
using System;

namespace HyperValidator.Core.Validators
{

	/// <summary>
	/// Responsible for Validating whether certain assets are available for a particular game.
	/// </summary>
	public interface IConsoleValidator
	{

		/// <summary>
		/// Validates the specified consoles assets.
		/// </summary>
		/// <param name="console">The console.</param>
		/// <returns></returns>
		ConsoleStatus Validate(HyperValidator.Models.Console console);

	}

	/// <summary>
	/// Responsible for Validating whether certain assets are available for a particular game.
	/// </summary>
	public class ConsoleValidator : IConsoleValidator
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
		/// Initializes a new instance of the <see cref="ConsoleValidator"/> class.
		/// </summary>
		/// <param name="logger">The logger.</param>
		/// <param name="settings">The settings.</param>
		/// <param name="fileUtility">The file utility.</param>
		/// <param name="directoryUtility">The directory utility.</param>
		/// <param name="pathUtility">The path utility.</param>
		public ConsoleValidator(
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
		/// Validates if this console has a video preview available.
		/// </summary>
		/// <param name="console">The console.</param>
		/// <returns></returns>
		protected Boolean ValidateVideo(HyperValidator.Models.Console console)
		{
			var location = PathUtility.Combine(Settings.HyperSpinRootLocation, "Media\\Main Menu\\Video");
			foreach (var fileType in Settings.VideoFileTypes)
			{
				location = PathUtility.Combine(location, $"{console.Name}.{fileType}");
				if (FileUtility.Exists(location))
					return true;
			}

			return false;
		}

		/// <summary>
		/// Validates if this console has wheel art available.
		/// </summary>
		/// <param name="console">The console.</param>
		/// <returns></returns>
		protected Boolean ValidateWheelArt(HyperValidator.Models.Console console)
		{
			var location = PathUtility.Combine(Settings.HyperSpinRootLocation, "Media\\Main Menu\\Images\\Wheel");
			foreach (var fileType in Settings.ImageFileTypes)
			{
				location = PathUtility.Combine(location, $"{console.Name}.{fileType}");
				if (FileUtility.Exists(location))
					return true;
			}

			return false;
		}

		/// <summary>
		/// Validates if this console has a theme available.
		/// </summary>
		/// <param name="console">The console.</param>
		/// <returns></returns>
		protected Boolean ValidateTheme(HyperValidator.Models.Console console)
		{
			var location = PathUtility.Combine(Settings.HyperSpinRootLocation, "Media\\Main Menu\\Themes");
			foreach (var fileType in Settings.ThemeFileTypes)
			{
				location = PathUtility.Combine(location, $"{console.Name}.{fileType}");
				if (FileUtility.Exists(location))
					return true;
			}

			return false;
		}


		#endregion PROTECTED METHODS

		#region PUBLIC METHODS


		/// <summary>
		/// Validates the specified consoles assets.
		/// </summary>
		/// <param name="console">The console.</param>
		/// <returns></returns>
		public ConsoleStatus Validate(HyperValidator.Models.Console console)
		{
			var status = new ConsoleStatus()
			{
				Video = ValidateVideo(console),
				Theme = ValidateTheme(console),
				WheelArt = ValidateWheelArt(console)
			};
			return status;
		}


		#endregion PUBLIC METHODS

	}

}
