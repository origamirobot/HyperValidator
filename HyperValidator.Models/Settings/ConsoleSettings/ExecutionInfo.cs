using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// Contains settings that pertain to executing emulators when launching games.
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class ExecutionInfo : Entity
	{

		#region PRIVATE PROPERTIES


		private String _path;
		private String _romPath;
		private Boolean _useRomPath;
		private String _executable;
		private String _romExtension;
		private String _parameters;
		private Boolean _searchSubFolders;
		private Boolean _isPcGame;
		private WindowState _windowState;
		private Boolean _useHyperLaunch;


		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS

		/// <summary>
		/// Gets or sets the path.
		/// </summary>
		public String Path
		{
			get => _path;
			set
			{
				if (value == _path) return;
				_path = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the rom path.
		/// </summary>
		public String RomPath
		{
			get => _romPath;
			set
			{
				if (value == _romPath) return;
				_romPath = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [use rom path].
		/// </summary>
		public Boolean UseRomPath
		{
			get => _useRomPath;
			set
			{
				if (value == _useRomPath) return;
				_useRomPath = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the executable.
		/// </summary>
		public String Executable
		{
			get => _executable;
			set
			{
				if (value == _executable) return;
				_executable = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the rom extension.
		/// </summary>
		public String RomExtension
		{
			get => _romExtension;
			set
			{
				if (value == _romExtension) return;
				_romExtension = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the parameters.
		/// </summary>
		public String Parameters
		{
			get => _parameters;
			set
			{
				if (value == _parameters) return;
				_parameters = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [search sub folders].
		/// </summary>
		public Boolean SearchSubFolders
		{
			get => _searchSubFolders;
			set
			{
				if (value == _searchSubFolders) return;
				_searchSubFolders = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether this instance is pc game.
		/// </summary>
		public Boolean IsPcGame
		{
			get => _isPcGame;
			set
			{
				if (value == _isPcGame) return;
				_isPcGame = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the state of the window.
		/// </summary>
		public WindowState WindowState
		{
			get => _windowState;
			set
			{
				if (value == _windowState) return;
				_windowState = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [use hyper launch].
		/// </summary>
		public Boolean UseHyperLaunch
		{
			get => _useHyperLaunch;
			set
			{
				if (value == _useHyperLaunch) return;
				_useHyperLaunch = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

	}

}
