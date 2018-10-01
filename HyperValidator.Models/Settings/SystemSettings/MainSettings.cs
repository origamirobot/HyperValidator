using System;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class MainSettings : Entity
	{

		#region PRIVATE PROPERTIES


		private String _hyperLaunchPath;
		private String _lastSystem;
		private String _version;
		private String _exitAction;
		private ExitOption _exitDefault;
		private Boolean _enableExit;
		private Boolean _enableExitMenu;
		private String _singleModeName;
		private MenuMode _menuMode;


		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets the menu mode.
		/// </summary>
		public MenuMode MenuMode
		{
			get => _menuMode;
			set
			{
				if (value == _menuMode) return;
				_menuMode = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the name of the single mode.
		/// </summary>
		public String SingleModeName
		{
			get => _singleModeName;
			set
			{
				if (value == _singleModeName) return;
				_singleModeName = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [enable exit menu].
		/// </summary>
		public Boolean EnableExitMenu
		{
			get => _enableExitMenu;
			set
			{
				if (value == _enableExitMenu) return;
				_enableExitMenu = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [enable exit].
		/// </summary>
		public Boolean EnableExit
		{
			get => _enableExit;
			set
			{
				if (value == _enableExit) return;
				_enableExit = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the exit default.
		/// </summary>
		public ExitOption ExitDefault
		{
			get => _exitDefault;
			set
			{
				if (value == _exitDefault) return;
				_exitDefault = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the exit action.
		/// </summary>
		public String ExitAction
		{
			get => _exitAction;
			set
			{
				if (value == _exitAction) return;
				_exitAction = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the version.
		/// </summary>
		public String Version
		{
			get => _version;
			set
			{
				if (value == _version) return;
				_version = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the last system.
		/// </summary>
		public String LastSystem
		{
			get => _lastSystem;
			set
			{
				if (value == _lastSystem) return;
				_lastSystem = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the hyper launch path.
		/// </summary>
		public String HyperLaunchPath
		{
			get => _hyperLaunchPath;
			set
			{
				if (value == _hyperLaunchPath) return;
				_hyperLaunchPath = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

	}

}
