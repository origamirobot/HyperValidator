using System;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class SoundSettings : Entity
	{

		#region PRIVATE PROPERTIES


		private Int32 _interfaceVolume;
		private Int32 _wheelVolume;
		private Int32 _videoVolume;
		private Int32 _masterVolume;


		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS

		/// <summary>
		/// Gets or sets the master volume.
		/// </summary>
		public Int32 MasterVolume
		{
			get => _masterVolume;
			set
			{
				if (value == _masterVolume) return;
				_masterVolume = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the video volume.
		/// </summary>
		public Int32 VideoVolume
		{
			get => _videoVolume;
			set
			{
				if (value == _videoVolume) return;
				_videoVolume = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the wheel volume.
		/// </summary>
		public Int32 WheelVolume
		{
			get => _wheelVolume;
			set
			{
				if (value == _wheelVolume) return;
				_wheelVolume = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the interface volume.
		/// </summary>
		public Int32 InterfaceVolume
		{
			get => _interfaceVolume;
			set
			{
				if (value == _interfaceVolume) return;
				_interfaceVolume = value;
				OnPropertyChanged();
			}
		}

		#endregion PUBLIC ACCESSORS

	}

}
