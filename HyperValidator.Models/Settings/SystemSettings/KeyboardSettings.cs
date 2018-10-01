using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// Settings used for keyboard stuff.
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class KeyboardSettings : Entity
	{

		#region PRIVATE PROPERTIES


		private Int32 _keyDelay;


		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS

		/// <summary>
		/// Gets or sets the key delay.
		/// </summary>
		public Int32 KeyDelay
		{
			get => _keyDelay;
			set
			{
				if (value == _keyDelay) return;
				_keyDelay = value;
				OnPropertyChanged();
			}
		}

		#endregion PUBLIC ACCESSORS

	}

}
