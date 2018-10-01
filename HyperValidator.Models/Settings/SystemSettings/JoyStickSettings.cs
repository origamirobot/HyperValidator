using System;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// Represents settings that are used with a joy stick control.
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class JoyStickSettings : Entity
	{

		#region PRIVATE PROPERTIES


		private JoyStickButton _favorites;
		private JoyStickButton _genre;
		private JoyStickButton _hyperSpin;
		private JoyStickButton _skipDownNumber;
		private JoyStickButton _skipUpNumber;
		private JoyStickButton _skipDown;
		private JoyStickButton _skipUp;
		private JoyStickButton _down;
		private JoyStickButton _up;
		private JoyStickButton _exit;
		private JoyStickButton _start;
		private Int32 _threshold;
		private Int32 _joy;
		private Boolean _enabled;


		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="JoyStickSettings"/> is enabled.
		/// </summary>
		public Boolean Enabled
		{
			get => _enabled;
			set
			{
				if (value == _enabled) return;
				_enabled = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the joy.
		/// </summary>
		public Int32 Joy
		{
			get => _joy;
			set
			{
				if (value == _joy) return;
				_joy = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the threshold.
		/// </summary>
		public Int32 Threshold
		{
			get => _threshold;
			set
			{
				if (value == _threshold) return;
				_threshold = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the start.
		/// </summary>
		public JoyStickButton Start
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
		/// Gets or sets the exit.
		/// </summary>
		public JoyStickButton Exit
		{
			get => _exit;
			set
			{
				if (value == _exit) return;
				_exit = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets up.
		/// </summary>
		public JoyStickButton Up
		{
			get => _up;
			set
			{
				if (value == _up) return;
				_up = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets down.
		/// </summary>
		public JoyStickButton Down
		{
			get => _down;
			set
			{
				if (value == _down) return;
				_down = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the skip up.
		/// </summary>
		public JoyStickButton SkipUp
		{
			get => _skipUp;
			set
			{
				if (value == _skipUp) return;
				_skipUp = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the skip down.
		/// </summary>
		public JoyStickButton SkipDown
		{
			get => _skipDown;
			set
			{
				if (value == _skipDown) return;
				_skipDown = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the skip up number.
		/// </summary>
		public JoyStickButton SkipUpNumber
		{
			get => _skipUpNumber;
			set
			{
				if (value == _skipUpNumber) return;
				_skipUpNumber = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the skip down number.
		/// </summary>
		public JoyStickButton SkipDownNumber
		{
			get => _skipDownNumber;
			set
			{
				if (value == _skipDownNumber) return;
				_skipDownNumber = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the hyper spin.
		/// </summary>
		public JoyStickButton HyperSpin
		{
			get => _hyperSpin;
			set
			{
				if (value == _hyperSpin) return;
				_hyperSpin = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the genre.
		/// </summary>
		public JoyStickButton Genre
		{
			get => _genre;
			set
			{
				if (value == _genre) return;
				_genre = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the favorites.
		/// </summary>
		public JoyStickButton Favorites
		{
			get => _favorites;
			set
			{
				if (value == _favorites) return;
				_favorites = value;
				OnPropertyChanged();
			}
		}

		#endregion PUBLIC ACCESSORS

	}

}
