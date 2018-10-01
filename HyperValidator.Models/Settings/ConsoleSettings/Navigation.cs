using System;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// Contains settings for a particular console that pertain to navigation.
	/// </summary>
	public class Navigation : Entity
	{

		#region PRIVATE PROPERTIES


		private Int32 _gameJump;
		private Boolean _useIndexes;
		private Int32 _jumpTimer;
		private Boolean _removeInfoWheel;
		private Boolean _removeInfoText;
		private Boolean _useLastGame;
		private String _lastGame;
		private Boolean _randomGame;
		private Boolean _startOnFavorites;

		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets the game jump.
		/// </summary>
		public Int32 GameJump
		{
			get => _gameJump;
			set
			{
				if (value == _gameJump) return;
				_gameJump = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [use indexes].
		/// </summary>
		public Boolean UseIndexes
		{
			get => _useIndexes;
			set
			{
				if (value == _useIndexes) return;
				_useIndexes = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the jump timer.
		/// </summary>
		public Int32 JumpTimer
		{
			get => _jumpTimer;
			set
			{
				if (value == _jumpTimer) return;
				_jumpTimer = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [remove information wheel].
		/// </summary>
		public Boolean RemoveInfoWheel
		{
			get => _removeInfoWheel;
			set
			{
				if (value == _removeInfoWheel) return;
				_removeInfoWheel = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [remove information text].
		/// </summary>
		public Boolean RemoveInfoText
		{
			get => _removeInfoText;
			set
			{
				if (value == _removeInfoText) return;
				_removeInfoText = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [use last game].
		/// </summary>
		public Boolean UseLastGame
		{
			get => _useLastGame;
			set
			{
				if (value == _useLastGame) return;
				_useLastGame = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the last game.
		/// </summary>
		public String LastGame
		{
			get => _lastGame;
			set
			{
				if (value == _lastGame) return;
				_lastGame = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [random game].
		/// </summary>
		public Boolean RandomGame
		{
			get => _randomGame;
			set
			{
				if (value == _randomGame) return;
				_randomGame = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [start on favorites].
		/// </summary>
		public Boolean StartOnFavorites
		{
			get => _startOnFavorites;
			set
			{
				if (value == _startOnFavorites) return;
				_startOnFavorites = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

	}

}
