using HyperValidator.Models.Settings;
using System;

namespace HyperValidator.Models
{

	/// <summary>
	/// 
	/// </summary>
	public class Console : Entity
	{

		#region PROTECTED PROPERTIES


		private String _root;
		private Database _database;
		private Int32 _index;
		private String _name;
		private Boolean _loaded;

		#endregion PROTECTED PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public String Name
		{
			get => _name;
			set
			{
				if (value == _name) return;
				_name = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the index of this console in the main menu list.
		/// </summary>
		public Int32 Index
		{
			get => _index;
			set
			{
				if (value == _index) return;
				_index = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the database.
		/// </summary>
		public Database Database
		{
			get => _database;
			set
			{
				if (Equals(value, _database)) return;
				_database = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the root.
		/// </summary>
		public String Root
		{
			get => _root;
			set
			{
				if (value == _root) return;
				_root = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the settings.
		/// </summary>
		public ConsoleSettings Settings { get; set; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		public ConsoleStatus Status { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Console"/> is loaded.
		/// </summary>
		public Boolean Loaded
		{
			get => _loaded;
			set
			{
				if (value == _loaded) return;
				_loaded = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

		#region CONSTRUCTORS


		/// <summary>
		/// Initializes a new instance of the <see cref="Console"/> class.
		/// </summary>
		/// <param name="root">The root.</param>
		public Console()
		{
		}


		#endregion CONSTRUCTORS

	}

	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class ConsoleStatus : Entity
	{

		#region PRIVATE PROPERTIES


		private Boolean _rom;
		private Boolean _theme;
		private Boolean _wheelArt;
		private Boolean _video;
		private Boolean _artwork4;
		private Boolean _artwork3;
		private Boolean _artwork2;
		private Boolean _artwork1;


		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Game"/> has a video file.
		/// </summary>
		public Boolean Video
		{
			get => _video;
			set
			{
				if (value == _video) return;
				_video = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Game"/> has a wheel art file.
		/// </summary>
		public Boolean WheelArt
		{
			get => _wheelArt;
			set
			{
				if (value == _wheelArt) return;
				_wheelArt = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Game"/> has a theme.
		/// </summary>
		public Boolean Theme
		{
			get => _theme;
			set
			{
				if (value == _theme) return;
				_theme = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

	}

}
