using System;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// Represents settings that start up programs on application start and exit.
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class ProgramSettings : Entity
	{

		#region PRIVATE PROPERTIES


		private WindowState _windowState;
		private String _workingDirectory;
		private String _parameters;
		private String _executable;
		private Boolean _hideCursor;


		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets a value indicating whether [hide cursor].
		/// </summary>
		public Boolean HideCursor
		{
			get => _hideCursor;
			set
			{
				if (value == _hideCursor) return;
				_hideCursor = value;
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
		/// Gets or sets the working directory.
		/// </summary>
		public String WorkingDirectory
		{
			get => _workingDirectory;
			set
			{
				if (value == _workingDirectory) return;
				_workingDirectory = value;
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


		#endregion PUBLIC ACCESSORS

	}

}
