using System;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class HiScoreSettings : Entity
	{

		#region PRIVATE PROPERTIES


		private Int32 _delay;
		private Int32 _y;
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
		/// Gets or sets the y.
		/// </summary>
		public Int32 Y
		{
			get => _y;
			set
			{
				if (value == _y) return;
				_y = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the delay.
		/// </summary>
		public Int32 Delay
		{
			get => _delay;
			set
			{
				if (value == _delay) return;
				_delay = value;
				OnPropertyChanged();
			}
		}

		#endregion PUBLIC ACCESSORS

	}

}
