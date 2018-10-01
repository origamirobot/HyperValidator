using System;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// Represents the settings found in a console settings file that dictate how the text shows up on screen.
	/// </summary>
	public class GameText : Entity
	{

		#region PRIVATE PROPERTIES


		private Boolean _active;
		private Boolean _showYear;
		private Boolean _showManufacturer;
		private Boolean _showDescription;
		private String _textColor1;
		private String _textColor2;
		private String _strokeColor;
		private String _textFont;
		private Int32 _text1FontSize;
		private Int32 _text1StrokeSize;
		private Int32 _text1X;
		private Int32 _text1Y;
		private Int32 _text2FontSize;
		private Int32 _text2StrokeSize;
		private Int32 _text2X;
		private Int32 _text2Y;


		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="GameText"/> is active.
		/// </summary>
		public Boolean Active
		{
			get => _active;
			set
			{
				if (value == _active) return;
				_active = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [show year].
		/// </summary>
		public Boolean ShowYear
		{
			get => _showYear;
			set
			{
				if (value == _showYear) return;
				_showYear = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [show manufacturer].
		/// </summary>
		public Boolean ShowManufacturer
		{
			get => _showManufacturer;
			set
			{
				if (value == _showManufacturer) return;
				_showManufacturer = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [show description].
		/// </summary>
		public Boolean ShowDescription
		{
			get => _showDescription;
			set
			{
				if (value == _showDescription) return;
				_showDescription = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the text color1.
		/// </summary>
		public String TextColor1
		{
			get => _textColor1;
			set
			{
				if (value == _textColor1) return;
				_textColor1 = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the text color2.
		/// </summary>
		public String TextColor2
		{
			get => _textColor2;
			set
			{
				if (value == _textColor2) return;
				_textColor2 = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the color of the stroke.
		/// </summary>
		public String StrokeColor
		{
			get => _strokeColor;
			set
			{
				if (value == _strokeColor) return;
				_strokeColor = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the text font.
		/// </summary>
		public String TextFont
		{
			get => _textFont;
			set
			{
				if (value == _textFont) return;
				_textFont = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the size of the Text1 text.
		/// </summary>
		public Int32 Text1FontSize
		{
			get => _text1FontSize;
			set
			{
				if (value == _text1FontSize) return;
				_text1FontSize = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the size of the Text1 stroke.
		/// </summary>
		public Int32 Text1StrokeSize
		{
			get => _text1StrokeSize;
			set
			{
				if (value == _text1StrokeSize) return;
				_text1StrokeSize = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the X coordinate of the Text1 text.
		/// </summary>
		public Int32 Text1X
		{
			get => _text1X;
			set
			{
				if (value == _text1X) return;
				_text1X = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the Y coordinate of the Text1 text.
		/// </summary>
		public Int32 Text1Y
		{
			get => _text1Y;
			set
			{
				if (value == _text1Y) return;
				_text1Y = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the size of the Text2 text.
		/// </summary>
		public Int32 Text2FontSize
		{
			get => _text2FontSize;
			set
			{
				if (value == _text2FontSize) return;
				_text2FontSize = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the size of the Text2 stroke.
		/// </summary>
		public Int32 Text2StrokeSize
		{
			get => _text2StrokeSize;
			set
			{
				if (value == _text2StrokeSize) return;
				_text2StrokeSize = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the X coordinate of the Text2 text.
		/// </summary>
		public Int32 Text2X
		{
			get => _text2X;
			set
			{
				if (value == _text2X) return;
				_text2X = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the Y coordinate of the Text2 text.
		/// </summary>
		public Int32 Text2Y
		{
			get => _text2Y;
			set
			{
				if (value == _text2Y) return;
				_text2Y = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

	}

}
