namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// 
	/// </summary>
	public class ConsoleSettings : Entity
	{

		#region PRIVATE PROPERTIES


		private GameText _gameText;
		private SpecialArt _specialArtC;
		private SpecialArt _specialArtB;
		private SpecialArt _specialArtA;
		private Navigation _navigation;
		private Sounds _sounds;
		private VideoDefaults _videoDefaults;
		private Pointer _pointer;
		private Wheel _wheel;
		private Themes _themes;
		private Filters _filters;
		private ExecutionInfo _executionInfo;


		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS

		
		/// <summary>
		/// Gets or sets the execution information.
		/// </summary>
		public ExecutionInfo ExecutionInfo
		{
			get => _executionInfo;
			set
			{
				if (Equals(value, _executionInfo)) return;
				_executionInfo = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the filters.
		/// </summary>
		public Filters Filters
		{
			get => _filters;
			set
			{
				if (Equals(value, _filters)) return;
				_filters = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the themes.
		/// </summary>
		public Themes Themes
		{
			get => _themes;
			set
			{
				if (Equals(value, _themes)) return;
				_themes = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the wheel.
		/// </summary>
		public Wheel Wheel
		{
			get => _wheel;
			set
			{
				if (Equals(value, _wheel)) return;
				_wheel = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the pointer.
		/// </summary>
		public Pointer Pointer
		{
			get => _pointer;
			set
			{
				if (Equals(value, _pointer)) return;
				_pointer = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the video defaults.
		/// </summary>
		public VideoDefaults VideoDefaults
		{
			get => _videoDefaults;
			set
			{
				if (Equals(value, _videoDefaults)) return;
				_videoDefaults = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the sounds.
		/// </summary>
		public Sounds Sounds
		{
			get => _sounds;
			set
			{
				if (Equals(value, _sounds)) return;
				_sounds = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the navigation.
		/// </summary>
		public Navigation Navigation
		{
			get => _navigation;
			set
			{
				if (Equals(value, _navigation)) return;
				_navigation = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the special art a.
		/// </summary>
		public SpecialArt SpecialArtA
		{
			get => _specialArtA;
			set
			{
				if (Equals(value, _specialArtA)) return;
				_specialArtA = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the special art b.
		/// </summary>
		public SpecialArt SpecialArtB
		{
			get => _specialArtB;
			set
			{
				if (Equals(value, _specialArtB)) return;
				_specialArtB = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the special art c.
		/// </summary>
		public SpecialArt SpecialArtC
		{
			get => _specialArtC;
			set
			{
				if (Equals(value, _specialArtC)) return;
				_specialArtC = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the game text.
		/// </summary>
		public GameText GameText
		{
			get => _gameText;
			set
			{
				if (Equals(value, _gameText)) return;
				_gameText = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

	}

}
