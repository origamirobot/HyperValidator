using System;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class HyperLaunchSettings : Entity
	{

		#region PRIVATE PROPERTIES


		private String _lastRom;
		private String _lastSystem;


		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


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
		/// Gets or sets the last rom.
		/// </summary>
		public String LastRom
		{
			get => _lastRom;
			set
			{
				if (value == _lastRom) return;
				_lastRom = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

	}

}
