using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class IntroVideoSettings : Entity
	{

		#region PRIVATE PROPERTIES


		private Boolean _stopOnKeyPress;
		private Boolean _useVideo;


		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets a value indicating whether [use video].
		/// </summary>
		public Boolean UseVideo
		{
			get => _useVideo;
			set
			{
				if (value == _useVideo) return;
				_useVideo = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [stop on key press].
		/// </summary>
		public Boolean StopOnKeyPress
		{
			get => _stopOnKeyPress;
			set
			{
				if (value == _stopOnKeyPress) return;
				_stopOnKeyPress = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

	}

}
