using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// Contains settings for the sounds that are played for this console.
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class Sounds : Entity
	{

		#region PRIVATE PROPERTIES


		private Boolean _gameSounds;
		private Boolean _wheelClick;
		

		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets a value indicating whether [game sounds].
		/// </summary>
		public Boolean GameSounds
		{
			get => _gameSounds;
			set
			{
				if (value == _gameSounds) return;
				_gameSounds = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [wheel click].
		/// </summary>
		public Boolean WheelClick
		{
			get => _wheelClick;
			set
			{
				if (value == _wheelClick) return;
				_wheelClick = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

	}

}
