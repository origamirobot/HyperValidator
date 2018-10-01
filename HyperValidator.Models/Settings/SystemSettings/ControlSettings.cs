using System;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class ControlSettings : Entity
	{

		#region PRIVATE PROPERTIES


		private Int32 _favorites;
		private Int32 _genre;
		private Int32 _hyperSpin;
		private Int32 _skipDownNumber;
		private Int32 _skipUp;
		private Int32 _skipDown;
		private Int32 _skipUpNumber;
		private Int32 _down;
		private Int32 _up;
		private Int32 _exit;


		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets the start.
		/// </summary>
		public Int32 Start { get; set; }

		/// <summary>
		/// Gets or sets the exit.
		/// </summary>

		public Int32 Exit
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
		public Int32 Up
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
		public Int32 Down
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
		public Int32 SkipUp
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
		public Int32 SkipDown
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
		public Int32 SkipUpNumber
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
		public Int32 SkipDownNumber
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
		public Int32 HyperSpin
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
		public Int32 Genre
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
		public Int32 Favorites
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
