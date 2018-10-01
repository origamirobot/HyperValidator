using System;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// Represents the settings in a console settings file for special artwork.
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class SpecialArt : Entity
	{

		#region PRIVATE PROPERTIES


		private Boolean _isDefault;
		private Boolean _isActive;
		private SpecialArtType _specialArtType;
		private Int32 _x;
		private Int32 _y;
		private Decimal _in;
		private Decimal _out;
		private Decimal _length;
		private Decimal _delay;
		private StartLocation _start;
		private AnimationType _animationType;


		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets a value indicating whether this instance is default.
		/// </summary>
		public Boolean IsDefault
		{
			get => _isDefault;
			set
			{
				if (value == _isDefault) return;
				_isDefault = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this instance is active.
		/// </summary>
		public Boolean IsActive
		{
			get => _isActive;
			set
			{
				if (value == _isActive) return;
				_isActive = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the type of the special art.
		/// </summary>
		public SpecialArtType SpecialArtType
		{
			get => _specialArtType;
			set
			{
				if (value == _specialArtType) return;
				_specialArtType = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the x.
		/// </summary>
		public Int32 X
		{
			get => _x;
			set
			{
				if (value == _x) return;
				_x = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the y.
		/// </summary>
		public Int32 Y
		{
			get => _y;
			set
			{
				if (value == _y) return;
				_y = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the in.
		/// </summary>
		public Decimal In
		{
			get => _in;
			set
			{
				if (value == _in) return;
				_in = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the out.
		/// </summary>
		public Decimal Out
		{
			get => _out;
			set
			{
				if (value == _out) return;
				_out = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the length.
		/// </summary>
		public Decimal Length
		{
			get => _length;
			set
			{
				if (value == _length) return;
				_length = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the delay.
		/// </summary>
		public Decimal Delay
		{
			get => _delay;
			set
			{
				if (value == _delay) return;
				_delay = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the start.
		/// </summary>
		public StartLocation Start
		{
			get => _start;
			set
			{
				if (value == _start) return;
				_start = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		public AnimationType AnimationType
		{
			get => _animationType;
			set
			{
				if (value == _animationType) return;
				_animationType = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

	}



}
