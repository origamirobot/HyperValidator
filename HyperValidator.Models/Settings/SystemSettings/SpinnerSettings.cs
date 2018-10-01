using System;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// Represents settings for using a spinner control.
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class SpinnerSettings : Entity
	{

		#region PRIVATE PROPERTIES


		private Int32 _sensitivity;
		private Boolean _enabled;
		

		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="SpinnerSettings"/> is enabled.
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
		/// Gets or sets the sensitivity.
		/// </summary>
		public Int32 Sensitivity
		{
			get => _sensitivity;
			set
			{
				if (value == _sensitivity) return;
				_sensitivity = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

	}

}
