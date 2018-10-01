using System;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class AttractModeSettings : Entity
	{

		#region PRIVATE PROPERTIES


		private Boolean _waitForVideo;
		private Boolean _hyperSpin;
		private Int32 _maxSpinTime;
		private Int32 _time;
		private Boolean _isActive;


		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets a value indicating whether this instance is active.
		/// </summary>
		public Boolean IsActive
		{
			get => _isActive;
			set
			{
				if (value == _isActive) return;
				_isActive = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the time.
		/// </summary>
		public Int32 Time
		{
			get => _time;
			set
			{
				if (value == _time) return;
				_time = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the maximum spin time.
		/// </summary>
		public Int32 MaxSpinTime
		{
			get => _maxSpinTime;
			set
			{
				if (value == _maxSpinTime) return;
				_maxSpinTime = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [hyper spin].
		/// </summary>
		public Boolean HyperSpin
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
		/// Gets or sets a value indicating whether [wait for video].
		/// </summary>
		public Boolean WaitForVideo
		{
			get => _waitForVideo;
			set
			{
				if (value == _waitForVideo) return;
				_waitForVideo = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

	}

}
