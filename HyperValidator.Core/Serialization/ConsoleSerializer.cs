using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperValidator.Core.IO;
using HyperValidator.Core.Logging;
using HyperValidator.Models.Settings;

namespace HyperValidator.Core.Serialization
{

	/// <summary>
	/// 
	/// </summary>
	public interface IConsoleSerializer
	{
		
		/// <summary>
		/// Deserializes from file
		/// </summary>
		/// <param name="location">The location.</param>
		/// <returns></returns>
		ConsoleSettings DeserializeFromFile(String location);

		/// <summary>
		/// Deserializes the specified text into a <see cref="ConsoleSettings"/> object. 
		/// </summary>
		/// <param name="text">The text.</param>
		/// <returns></returns>
		ConsoleSettings Deserialize(String text);

		/// <summary>
		/// Serializes the specified settings back into an INI file.
		/// </summary>
		/// <param name="settings">The settings.</param>
		/// <returns></returns>
		String Serialize(ConsoleSettings settings);

	}

	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HyperValidator.Core.Serialization.IConsoleSerializer" />
	public class ConsoleSerializer : IConsoleSerializer
	{

		#region PROTECTED PROPERTIES


		/// <summary>
		/// Gets the serializer.
		/// </summary>
		protected IIniSerializer Serializer { get; private set; }

		/// <summary>
		/// Gets the file utility.
		/// </summary>
		protected IFileUtility FileUtility { get; private set; }

		/// <summary>
		/// Gets the logger.
		/// </summary>
		protected ILogger Logger { get; private set; }


		#endregion PROTECTED PROPERTIES

		#region CONSTRUCTORS


		/// <summary>
		/// Initializes a new instance of the <see cref="ConsoleSerializer" /> class.
		/// </summary>
		/// <param name="serializer">The serializer.</param>
		/// <param name="fileUtility">The file utility.</param>
		/// <param name="logger">The logger.</param>
		public ConsoleSerializer(
			IIniSerializer serializer, 
			IFileUtility fileUtility, 
			ILogger logger)
		{
			Serializer = serializer;
			FileUtility = fileUtility;
			Logger = logger;
		}


		#endregion CONSTRUCTORS


		/// <summary>
		/// Deserializes from file
		/// </summary>
		/// <param name="location">The location.</param>
		/// <returns></returns>
		/// <exception cref="System.IO.FileNotFoundException"></exception>
		public ConsoleSettings DeserializeFromFile(String location)
		{
			try
			{
				if (!FileUtility.Exists(location))
					throw new FileNotFoundException($"The file does not exist: {location}");

				var text = FileUtility.ReadAllText(location);
				return Deserialize(text);
			}
			catch (Exception ex)
			{
				Logger.Error(ex);
				throw;
			}

		}

		/// <summary>
		/// Deserializes the specified text into a <see cref="ConsoleSettings" /> object.
		/// </summary>
		/// <param name="text">The text.</param>
		/// <returns></returns>
		public ConsoleSettings Deserialize(String text)
		{
			var stopwatch = Stopwatch.StartNew();
			try
			{
				Logger.Debug("Attempting to deserialize a console settings file");

				var settings = new ConsoleSettings();
				var ini = Serializer.Deserialize(text);

				settings.ExecutionInfo = new ExecutionInfo()
				{
					Executable = ini["exe info"]["exe"].Value,
					Path = ini["exe info"]["path"].Value,
					UseRomPath = ini["exe info"]["path"].ToBoolean(),
					IsPcGame = ini["exe info"]["pcgame"].ToBoolean(),
					Parameters = ini["exe info"]["parameters"].Value,
					RomExtension = ini["exe info"]["romextension"].Value,
					RomPath = ini["exe info"]["rompath"].Value,
					SearchSubFolders = ini["exe info"]["searchsubfolders"].ToBoolean(),
					UseHyperLaunch = ini["exe info"]["hyperlaunch"].ToBoolean(),
					WindowState = ini["exe info"]["winstate"].ToEnum<WindowState>()
				};

				settings.Filters = new Filters()
				{
					ParentsOnly = ini["filters"]["parents_only"].ToBoolean(),
					ThemesOnly = ini["filters"]["themes_only"].ToBoolean(),
					WheelsOnly = ini["filters"]["wheels_only"].ToBoolean()
				};

				settings.GameText = new GameText()
				{
					Active = ini["Game Text"]["game_text_active"].ToBoolean(),
					ShowDescription = ini["Game Text"]["show_description"].ToBoolean(),
					ShowManufacturer = ini["Game Text"]["show_manf"].ToBoolean(),
					ShowYear = ini["Game Text"]["show_year"].ToBoolean(),
					StrokeColor = ini["Game Text"]["stroke_color"].Value,
					Text1FontSize = ini["Game Text"]["text1_textsize"].ToInt32(),
					Text1StrokeSize = ini["Game Text"]["text1_strokesize"].ToInt32(),
					Text1X = ini["Game Text"]["text1_x"].ToInt32(),
					Text1Y = ini["Game Text"]["text1_y"].ToInt32(),
					Text2FontSize = ini["Game Text"]["text2_textsize"].ToInt32(),
					Text2StrokeSize = ini["Game Text"]["text2_strokesize"].ToInt32(),
					Text2X = ini["Game Text"]["text2_x"].ToInt32(),
					Text2Y = ini["Game Text"]["text2_y"].ToInt32(),
					TextColor1 = ini["Game Text"]["text_color1"].Value,
					TextColor2 = ini["Game Text"]["text_color2"].Value,
					TextFont = ini["Game Text"]["text_font"].Value,
				};

				settings.Navigation = new Navigation()
				{
					GameJump = ini["navigation"]["game_jump"].ToInt32(),
					UseIndexes = ini["navigation"]["use_indexes"].ToBoolean(),
					JumpTimer = ini["navigation"]["jump_timer"].ToInt32(),
					RemoveInfoWheel = ini["navigation"]["remove_info_wheel"].ToBoolean(),
					RemoveInfoText = ini["navigation"]["remove_info_text"].ToBoolean(),
					UseLastGame = ini["navigation"]["use_last_game"].ToBoolean(),
					LastGame = ini["navigation"]["last_game"].Value,
					RandomGame = ini["navigation"]["random_game"].ToBoolean(),
				};

				settings.Pointer = new Pointer()
				{
					IsAnimated = ini["pointer"]["animated"].ToBoolean(),
					X = ini["pointer"]["x"].ToInt32(),
					Y = ini["pointer"]["y"].ToInt32(),
				};

				settings.Sounds = new Sounds()
				{
					GameSounds = ini["sounds"]["game_sounds"].ToBoolean(),
					WheelClick = ini["sounds"]["wheel_click"].ToBoolean(),

				};


				settings.SpecialArtA = new SpecialArt()
				{
					IsActive = ini["Special Art A"]["active"].ToBoolean(),
					IsDefault = ini["Special Art A"]["default"].ToBoolean(),
					AnimationType = ini["Special Art A"]["type"].ToEnum<AnimationType>(),
					Delay = ini["Special Art A"]["delay"].ToInt32(),
					In = ini["Special Art A"]["in"].ToDecimal(),
					Length = ini["Special Art A"]["length"].ToDecimal(),
					Out = ini["Special Art A"]["out"].ToDecimal(),
					Start = ini["Special Art A"]["start"].ToEnum<StartLocation>(),
					X = ini["Special Art A"]["x"].ToInt32(),
					Y = ini["Special Art A"]["y"].ToInt32(),
					SpecialArtType = SpecialArtType.A,
				};

				settings.SpecialArtB = new SpecialArt()
				{
					IsActive = ini["Special Art B"]["active"].ToBoolean(),
					IsDefault = ini["Special Art B"]["default"].ToBoolean(),
					AnimationType = ini["Special Art B"]["type"].ToEnum<AnimationType>(),
					Delay = ini["Special Art B"]["delay"].ToInt32(),
					In = ini["Special Art B"]["in"].ToDecimal(),
					Length = ini["Special Art B"]["length"].ToDecimal(),
					Out = ini["Special Art B"]["out"].ToDecimal(),
					Start = ini["Special Art B"]["start"].ToEnum<StartLocation>(),
					X = ini["Special Art B"]["x"].ToInt32(),
					Y = ini["Special Art B"]["y"].ToInt32(),
					SpecialArtType = SpecialArtType.B,
				};

				settings.SpecialArtC = new SpecialArt()
				{
					IsActive = ini["Special Art C"]["active"].ToBoolean(),
					IsDefault = false,
					AnimationType = ini["Special Art C"]["type"].ToEnum<AnimationType>(),
					Delay = ini["Special Art C"]["delay"].ToInt32(),
					In = ini["Special Art C"]["in"].ToDecimal(),
					Length = ini["Special Art C"]["length"].ToDecimal(),
					Out = ini["Special Art C"]["out"].ToDecimal(),
					Start = ini["Special Art C"]["start"].ToEnum<StartLocation>(),
					X = ini["Special Art C"]["x"].ToInt32(),
					Y = ini["Special Art C"]["y"].ToInt32(),
					SpecialArtType = SpecialArtType.C,
				};


				settings.Themes = new Themes()
				{
					UseParentVideos = ini["themes"]["use_parent_vids"].ToBoolean(),
					UseParentThemes = ini["themes"]["use_parent_themes"].ToBoolean(),
					AnimateOutDefault = ini["themes"]["animate_out_default"].ToBoolean(),
					ReloadBackground = ini["themes"]["reload_backgrounds"].ToBoolean(),
				};

				settings.Wheel = new Wheel()
				{
					Alpha = ini["wheel"]["alpha"].ToDecimal(),
					SmallAlpha = ini["wheel"]["small_alpha"].ToDecimal(),
					Style = ini["wheel"]["style"].ToEnum<WheelStyle>(),
					Speed = ini["wheel"]["speed"].ToEnum<WheelSpeed>(),
					PinCenterWidth = ini["wheel"]["pin_center_width"].ToInt32(),
					HorizontalWheelY = ini["wheel"]["horz_wheel_y"].ToInt32(),
					VerticalWheelPosition = ini["wheel"]["vert_wheel_position"].ToEnum<VerticalWheelPosition>(),
					YRotation = ini["wheel"]["y_rotation"].ToEnum<RotationPoint>(),
					NormalLarge = ini["wheel"]["norm_large"].ToInt32(),
					NormalSmall = ini["wheel"]["norm_small"].ToInt32(),
					VerticalLarge = ini["wheel"]["vert_large"].ToInt32(),
					VerticalSmall = ini["wheel"]["vert_small"].ToInt32(),
					PinLarge = ini["wheel"]["pin_large"].ToInt32(),
					PinSmall = ini["wheel"]["pin_small"].ToInt32(),
					HorizontalLarge = ini["wheel"]["horz_large"].ToInt32(),
					HorizontalSmall = ini["wheel"]["horz_small"].ToInt32(),
					LetterWheelX = ini["wheel"]["letter_wheel_x"].ToInt32(),
					LetterWheelY = ini["wheel"]["letter_wheel_y"].ToInt32(),
					TextWidth = ini["wheel"]["text_width"].ToInt32(),
					TextFont = ini["wheel"]["text_font"].ToEnum<TextFont>(),
					SmallTextWidth = ini["wheel"]["small_text_width"].ToInt32(),
					LargeTextWidth = ini["wheel"]["large_text_width"].ToInt32(),
					TextStrokeSize = ini["wheel"]["text_stroke_size"].ToInt32(),
					TextStrokeColor = ini["wheel"]["text_stroke_color"].Value,
					TextColor1 = ini["wheel"]["text_color1"].Value,
					TextColor2 = ini["wheel"]["text_color2"].Value,
					TextColor3 = ini["wheel"]["text_color3"].Value,
					ColorRatio = ini["wheel"]["color_ratio"].ToInt32(),
					ShadowDistance = ini["wheel"]["shadow_distance"].ToInt32(),
					ShadowAngle = ini["wheel"]["shadow_angle"].ToInt32(),
					ShadowColor = ini["wheel"]["shadow_color"].Value,
					ShadowAlpha = ini["wheel"]["shadow_alpha"].ToInt32(),
					ShadowBlur = ini["wheel"]["shadow_blur"].ToInt32(),
				};

				settings.VideoDefaults = new VideoDefaults()
				{
					Path = ini["video defaults"]["path"].Value
				};

				return settings;
			}
			catch (Exception ex)
			{
				Logger.Error(ex);
				throw;
			}
			finally
			{
				stopwatch.Stop();
				Logger.Debug($"Console settings file deserialized in {stopwatch.ElapsedMilliseconds}ms");
			}
		}

		/// <summary>
		/// Serializes the specified settings back into an INI file.
		/// </summary>
		/// <param name="settings">The settings.</param>
		/// <returns></returns>
		public String Serialize(ConsoleSettings settings)
		{
			throw new NotImplementedException();
		}

	}

}
