using System;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// Contains settings for the wheel thats display when a console is selected.
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class Wheel : Entity
	{

		#region PRIVATE PROPERTIES


		private Decimal _alpha;
		private Decimal _smallAlpha;
		private WheelStyle _style;
		private WheelSpeed _speed;
		private Int32 _pinCenterWidth;
		private Int32 _horizontalWheelY;
		private VerticalWheelPosition _verticalWheelPosition;
		private RotationPoint _yRotation;
		private Int32 _normalLarge;
		private Int32 _normalSmall;
		private Int32 _verticalLarge;
		private Int32 _verticalSmall;
		private Int32 _pinLarge;
		private Int32 _pinSmall;
		private Int32 _horizontalLarge;
		private Int32 _horizontalSmall;
		private Int32 _letterWheelX;
		private Int32 _letterWheelY;
		private Int32 _textWidth;
		private TextFont _textFont;
		private Int32 _smallTextWidth;
		private Int32 _largeTextWidth;
		private Int32 _textStrokeSize;
		private String _textStrokeColor;
		private String _textColor1;
		private String _textColor2;
		private String _textColor3;
		private Int32 _colorRatio;
		private Int32 _shadowDistance;
		private Int32 _shadowAngle;
		private String _shadowColor;
		private Decimal _shadowAlpha;
		private Int32 _shadowBlur;

		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS

		/// <summary>
		/// Gets or sets the alpha.
		/// </summary>
		public Decimal Alpha
		{
			get => _alpha;
			set
			{
				if (value == _alpha) return;
				_alpha = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the small alpha.
		/// </summary>
		public Decimal SmallAlpha
		{
			get => _smallAlpha;
			set
			{
				if (value == _smallAlpha) return;
				_smallAlpha = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the style.
		/// </summary>
		public WheelStyle Style
		{
			get => _style;
			set
			{
				if (value == _style) return;
				_style = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the speed.
		/// </summary>
		public WheelSpeed Speed
		{
			get => _speed;
			set
			{
				if (value == _speed) return;
				_speed = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the width of the pin center.
		/// </summary>
		public Int32 PinCenterWidth
		{
			get => _pinCenterWidth;
			set
			{
				if (value == _pinCenterWidth) return;
				_pinCenterWidth = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the horizontal wheel y.
		/// </summary>
		public Int32 HorizontalWheelY
		{
			get => _horizontalWheelY;
			set
			{
				if (value == _horizontalWheelY) return;
				_horizontalWheelY = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the vertical wheel position.
		/// </summary>
		public VerticalWheelPosition VerticalWheelPosition
		{
			get => _verticalWheelPosition;
			set
			{
				if (value == _verticalWheelPosition) return;
				_verticalWheelPosition = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the y rotation.
		/// </summary>
		public RotationPoint YRotation
		{
			get => _yRotation;
			set
			{
				if (value == _yRotation) return;
				_yRotation = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the normal large.
		/// </summary>
		public Int32 NormalLarge
		{
			get => _normalLarge;
			set
			{
				if (value == _normalLarge) return;
				_normalLarge = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the normal small.
		/// </summary>
		public Int32 NormalSmall
		{
			get => _normalSmall;
			set
			{
				if (value == _normalSmall) return;
				_normalSmall = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the vertical large.
		/// </summary>
		public Int32 VerticalLarge
		{
			get => _verticalLarge;
			set
			{
				if (value == _verticalLarge) return;
				_verticalLarge = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the vertical small.
		/// </summary>
		public Int32 VerticalSmall
		{
			get => _verticalSmall;
			set
			{
				if (value == _verticalSmall) return;
				_verticalSmall = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the pin large.
		/// </summary>
		public Int32 PinLarge
		{
			get => _pinLarge;
			set
			{
				if (value == _pinLarge) return;
				_pinLarge = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the pin small.
		/// </summary>
		public Int32 PinSmall
		{
			get => _pinSmall;
			set
			{
				if (value == _pinSmall) return;
				_pinSmall = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the horizontal large.
		/// </summary>
		public Int32 HorizontalLarge
		{
			get => _horizontalLarge;
			set
			{
				if (value == _horizontalLarge) return;
				_horizontalLarge = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the horizontal small.
		/// </summary>
		public Int32 HorizontalSmall
		{
			get => _horizontalSmall;
			set
			{
				if (value == _horizontalSmall) return;
				_horizontalSmall = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the letter wheel x.
		/// </summary>
		public Int32 LetterWheelX
		{
			get => _letterWheelX;
			set
			{
				if (value == _letterWheelX) return;
				_letterWheelX = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the letter wheel y.
		/// </summary>
		public Int32 LetterWheelY
		{
			get => _letterWheelY;
			set
			{
				if (value == _letterWheelY) return;
				_letterWheelY = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the width of the text.
		/// </summary>
		public Int32 TextWidth
		{
			get => _textWidth;
			set
			{
				if (value == _textWidth) return;
				_textWidth = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the text font.
		/// </summary>
		public TextFont TextFont
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
		/// Gets or sets the width of the small text.
		/// </summary>
		public Int32 SmallTextWidth
		{
			get => _smallTextWidth;
			set
			{
				if (value == _smallTextWidth) return;
				_smallTextWidth = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the width of the large text.
		/// </summary>
		public Int32 LargeTextWidth
		{
			get => _largeTextWidth;
			set
			{
				if (value == _largeTextWidth) return;
				_largeTextWidth = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the size of the text stroke.
		/// </summary>
		public Int32 TextStrokeSize
		{
			get => _textStrokeSize;
			set
			{
				if (value == _textStrokeSize) return;
				_textStrokeSize = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the color of the text stroke.
		/// </summary>
		public String TextStrokeColor
		{
			get => _textStrokeColor;
			set
			{
				if (value == _textStrokeColor) return;
				_textStrokeColor = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the color of the text.
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
		/// Gets or sets the text color3.
		/// </summary>
		public String TextColor3
		{
			get => _textColor3;
			set
			{
				if (value == _textColor3) return;
				_textColor3 = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the color ratio.
		/// </summary>
		public Int32 ColorRatio
		{
			get => _colorRatio;
			set
			{
				if (value == _colorRatio) return;
				_colorRatio = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the shadow distance.
		/// </summary>
		public Int32 ShadowDistance
		{
			get => _shadowDistance;
			set
			{
				if (value == _shadowDistance) return;
				_shadowDistance = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the shadow angle.
		/// </summary>
		public Int32 ShadowAngle
		{
			get => _shadowAngle;
			set
			{
				if (value == _shadowAngle) return;
				_shadowAngle = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the color of the shadow.
		/// </summary>
		public String ShadowColor
		{
			get => _shadowColor;
			set
			{
				if (value == _shadowColor) return;
				_shadowColor = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the shadow alpha.
		/// </summary>
		public Decimal ShadowAlpha
		{
			get => _shadowAlpha;
			set
			{
				if (value == _shadowAlpha) return;
				_shadowAlpha = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the shadow blur.
		/// </summary>
		public Int32 ShadowBlur
		{
			get => _shadowBlur;
			set
			{
				if (value == _shadowBlur) return;
				_shadowBlur = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

	}

}
