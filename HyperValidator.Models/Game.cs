using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperValidator.Models
{

	/// <summary>
	/// 
	/// </summary>
	public class Game : Entity
	{

		#region PRIVATE PROPERTIES


		private String _name;
		private String _description;
		private Boolean _indexed;
		private String _image;
		private String _checksum;
		private String _cloneOf;
		private String _manufacturer;
		private Int32 _year;
		private String _genre;
		private String _rating;
		private Boolean _enabled;
		private GameStatus _status;

		#endregion PRIVATE PROPERTIES

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
		/// Gets or sets the description.
		/// </summary>
		public String Description
		{
			get => _description;
			set
			{
				if (value == _description) return;
				_description = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Game"/> is indexed.
		/// </summary>
		public Boolean Indexed
		{
			get => _indexed;
			set
			{
				if (value == _indexed) return;
				_indexed = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the image.
		/// </summary>
		public String Image
		{
			get => _image;
			set
			{
				if (value == _image) return;
				_image = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the checksum.
		/// </summary>
		public String Checksum
		{
			get => _checksum;
			set
			{
				if (value == _checksum) return;
				_checksum = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the clone of.
		/// </summary>
		public String CloneOf
		{
			get => _cloneOf;
			set
			{
				if (value == _cloneOf) return;
				_cloneOf = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the manufacturer.
		/// </summary>
		public String Manufacturer
		{
			get => _manufacturer;
			set
			{
				if (value == _manufacturer) return;
				_manufacturer = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the year.
		/// </summary>
		public Int32 Year
		{
			get => _year;
			set
			{
				if (value == _year) return;
				_year = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the genre.
		/// </summary>
		public String Genre
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
		/// Gets or sets the rating.
		/// </summary>
		public String Rating
		{
			get => _rating;
			set
			{
				if (value == _rating) return;
				_rating = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Game"/> is enabled.
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
		/// Gets or sets the status.
		/// </summary>
		public GameStatus Status
		{
			get => _status;
			set
			{
				if (Equals(value, _status)) return;
				_status = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

    }

	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class GameStatus : Entity
	{

		#region PRIVATE PROPERTIES


		private Boolean? _rom;
		private Boolean? _theme;
		private Boolean? _wheelArt;
		private Boolean? _video;
		private Boolean? _artwork4;
		private Boolean? _artwork3;
		private Boolean? _artwork2;
		private Boolean? _artwork1;
		private Boolean? _background;
		private String _name;
		private Boolean _enabled;

		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Game"/> has an artwork 1 file.
		/// </summary>
		public Boolean? Artwork1
		{
			get => _artwork1;
			set
			{
				if (value == _artwork1) return;
				_artwork1 = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Game"/> has an artwork 2 file.
		/// </summary>
		public Boolean? Artwork2
		{
			get => _artwork2;
			set
			{
				if (value == _artwork2) return;
				_artwork2 = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Game"/> has an artwork 3 file.
		/// </summary>
		public Boolean? Artwork3
		{
			get => _artwork3;
			set
			{
				if (value == _artwork3) return;
				_artwork3 = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Game"/> has an artwork 4 file.
		/// </summary>
		public Boolean? Artwork4
		{
			get => _artwork4;
			set
			{
				if (value == _artwork4) return;
				_artwork4 = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Game"/> has a video file.
		/// </summary>
		public Boolean? Video
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
		public Boolean? WheelArt
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
		public Boolean? Theme
		{
			get => _theme;
			set
			{
				if (value == _theme) return;
				_theme = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Game"/> has a rom.
		/// </summary>
		public Boolean? Rom
		{
			get => _rom;
			set
			{
				if (value == _rom) return;
				_rom = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="GameStatus"/> is background.
		/// </summary>
		public Boolean? Background
		{
			get => _background;
			set
			{
				if (value == _background) return;
				_background = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="GameStatus"/> is enabled.
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


		#endregion PUBLIC ACCESSORS

	}

}
