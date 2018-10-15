using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperValidator.Core.IO;
using HyperValidator.Core.Logging;

namespace HyperValidator.Core.Configuration
{


	/// <summary>
	/// 
	/// </summary>
	public interface IHyperValidatorSettings
	{

		/// <summary>
		/// Gets the log level.
		/// </summary>
		LogLevel LogLevel { get; }

		/// <summary>
		/// Gets the name of the logger.
		/// </summary>
		String LoggerName { get; }

		/// <summary>
		/// Gets or sets the hyper spin root location.
		/// </summary>
		String HyperSpinRootLocation { get;  }

		/// <summary>
		/// Gets or sets the rom location.
		/// </summary>
		String RomLocation { get; }

		/// <summary>
		/// Gets a list of the image file types supported.
		/// </summary>
		List<String> ImageFileTypes { get; }

		/// <summary>
		/// Gets a list of the video file types supported.
		/// </summary>
		List<String> VideoFileTypes { get; }

		/// <summary>
		/// Gets the name of the box art folder. This is usually where the box art appears in a consoles media library. Usually: Artwork1, Artwork2, Artwork3, Artwork4
		/// </summary>
		String BoxArtFolderName { get; }

		/// <summary>
		/// Gets the name of the cartridge art folder. This is usually where the box art appears in a consoles media library. Usually: Artwork1, Artwork2, Artwork3, Artwork4
		/// </summary>
		String CartridgeArtFolderName { get; }

		/// <summary>
		/// Gets the theme file types.
		/// </summary>
		List<String> ThemeFileTypes { get; }

		/// <summary>
		/// Gets the rom file types.
		/// </summary>
		List<String> RomFileTypes { get; }

		/// <summary>
		/// Gets a value indicating whether to validate the artwork 1 file
		/// </summary>
		Boolean ValidateArtwork1 { get; }

		/// <summary>
		/// Gets a value indicating whether to  validate the artwork 2 file
		/// </summary>
		Boolean ValidateArtwork2 { get; }

		/// <summary>
		/// Gets a value indicating whether to  validate the artwork 3 file
		/// </summary>
		Boolean ValidateArtwork3 { get; }

		/// <summary>
		/// Gets a value indicating whether to  validate the artwork 4 file
		/// </summary>
		Boolean ValidateArtwork4 { get; }

		/// <summary>
		/// Gets a value indicating whether to validate the video file
		/// </summary>
		Boolean ValidateVideos { get; }

		/// <summary>
		/// Gets a value indicating whether to validate the background file
		/// </summary>
		Boolean ValidateBackgrounds { get; }

		/// <summary>
		/// Gets a value indicating whether to validate theme file
		/// </summary>
		Boolean ValidateThemes { get; }

		/// <summary>
		/// Gets a value indicating whether to validate the wheel art file
		/// </summary>
		Boolean ValidateWheelArt { get; }

		/// <summary>
		/// Gets a value indicating whether to validate ROMs
		/// </summary>
		Boolean ValidateRoms { get; }
	}

	/// <summary>
	/// 
	/// </summary>
	public class HyperValidatorSettings : BaseConfiguration, IHyperValidatorSettings
	{

		#region CONSTRUCTORS


		/// <summary>
		/// Initializes a new instance of the <see cref="HyperValidatorSettings"/> class.
		/// </summary>
		/// <param name="appSettingsReader">The application settings reader.</param>
		/// <param name="configurationManager">The configuration manager.</param>
		/// <param name="fileUtility">The file utility.</param>
		public HyperValidatorSettings(
			IAppSettingsReader appSettingsReader, 
			IConfigurationManager configurationManager, 
			IFileUtility fileUtility) 
			: base(appSettingsReader, configurationManager, fileUtility)
		{
		}


		#endregion CONSTRUCTORS

		#region PUBLIC ACCESSORS

		
		/// <summary>
		/// Gets or sets the log level.
		/// </summary>
		public LogLevel LogLevel => AppSettingsReader.ReadOptionalEnumAppSetting<LogLevel>(nameof(LogLevel), LogLevel.Debug);

		/// <summary>
		/// Gets or sets the name of the logger.
		/// </summary>
		public String LoggerName => AppSettingsReader.ReadOptionalStringAppSetting(nameof(LoggerName), "HyperValidator");

		/// <summary>
		/// Gets or sets the hyper spin root location.
		/// </summary>
		public String HyperSpinRootLocation => AppSettingsReader.ReadOptionalStringAppSetting(nameof(HyperSpinRootLocation), "G:\\My Drive\\media\\games\\hyperspin");

		/// <summary>
		/// Gets or sets the rom location.
		/// </summary>
		public String RomLocation => AppSettingsReader.ReadOptionalStringAppSetting(nameof(RomLocation), "G:\\My Drive\\media\\games\\roms");

		/// <summary>
		/// Gets a list of the image file types supported.
		/// </summary>
		public List<String> ImageFileTypes
		{
			get
			{
				var value = AppSettingsReader.ReadOptionalStringAppSetting(nameof(ImageFileTypes), "png,jpg,bmp,jpeg,gif");
				var list = value.Split(',');
				return new List<String>(list);
			}
		}

		/// <summary>
		/// Gets a list of the video file types supported.
		/// </summary>
		public List<String> VideoFileTypes
		{
			get
			{
				var value = AppSettingsReader.ReadOptionalStringAppSetting(nameof(VideoFileTypes), "flv,mpg,avi,mp4,m4v");
				var list = value.Split(',');
				return new List<String>(list);
			}
		}

		/// <summary>
		/// Gets the theme file types.
		/// </summary>
		public List<String> ThemeFileTypes
		{
			get
			{
				var value = AppSettingsReader.ReadOptionalStringAppSetting(nameof(ThemeFileTypes), "zip");
				var list = value.Split(',');
				return new List<String>(list);
			}
		}

		/// <summary>
		/// Gets the rom file types.
		/// </summary>
		public List<String> RomFileTypes
		{
			get
			{
				var value = AppSettingsReader.ReadOptionalStringAppSetting(nameof(RomFileTypes), "smc,zip,7z,gba,nes,gb,a52,iso,bin,cpr,rom");
				var list = value.Split(',');
				return new List<String>(list);
			}
		}

		/// <summary>
		/// Gets the name of the box art folder. This is usually where the box art appears in a consoles media library. Usually: Artwork1, Artwork2, Artwork3, Artwork4
		/// </summary>
		public String BoxArtFolderName => AppSettingsReader.ReadOptionalStringAppSetting(nameof(BoxArtFolderName), "Artwork1");

		/// <summary>
		/// Gets the name of the cartridge art folder. This is usually where the box art appears in a consoles media library. Usually: Artwork1, Artwork2, Artwork3, Artwork4
		/// </summary>
		public String CartridgeArtFolderName => AppSettingsReader.ReadOptionalStringAppSetting(nameof(CartridgeArtFolderName), "Artwork2");




		#region THINGS TO VALIDATE


		/// <summary>
		/// Gets a value indicating whether to validate the artwork 1 file
		/// </summary>
		public Boolean ValidateArtwork1 => AppSettingsReader.ReadOptionalBooleanAppSetting(nameof(ValidateArtwork1), true);

		/// <summary>
		/// Gets a value indicating whether to  validate the artwork 2 file
		/// </summary>
		public Boolean ValidateArtwork2 => AppSettingsReader.ReadOptionalBooleanAppSetting(nameof(ValidateArtwork2), true);

		/// <summary>
		/// Gets a value indicating whether to  validate the artwork 3 file
		/// </summary>
		public Boolean ValidateArtwork3 => AppSettingsReader.ReadOptionalBooleanAppSetting(nameof(ValidateArtwork3), true);

		/// <summary>
		/// Gets a value indicating whether to  validate the artwork 4 file
		/// </summary>
		public Boolean ValidateArtwork4 => AppSettingsReader.ReadOptionalBooleanAppSetting(nameof(ValidateArtwork4), true);

		/// <summary>
		/// Gets a value indicating whether to validate the video file
		/// </summary>
		public Boolean ValidateVideos => AppSettingsReader.ReadOptionalBooleanAppSetting(nameof(ValidateVideos), true);

		/// <summary>
		/// Gets a value indicating whether to validate the background file
		/// </summary>
		public Boolean ValidateBackgrounds => AppSettingsReader.ReadOptionalBooleanAppSetting(nameof(ValidateBackgrounds), true);
		/// <summary>
		/// Gets a value indicating whether to validate theme file
		/// </summary>
		public Boolean ValidateThemes => AppSettingsReader.ReadOptionalBooleanAppSetting(nameof(ValidateThemes), true);

		/// <summary>
		/// Gets a value indicating whether to validate the wheel art file
		/// </summary>
		public Boolean ValidateWheelArt => AppSettingsReader.ReadOptionalBooleanAppSetting(nameof(ValidateWheelArt), true);
		/// <summary>
		/// Gets a value indicating whether to validate ROMs
		/// </summary>
		public Boolean ValidateRoms => AppSettingsReader.ReadOptionalBooleanAppSetting(nameof(ValidateRoms), true);



		#endregion THINGS TO VALIDATE


		#endregion PUBLIC ACCESSORS


	}

}
