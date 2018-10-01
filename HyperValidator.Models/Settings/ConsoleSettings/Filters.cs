using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// Contains settings for filters.
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class Filters : Entity
	{
		private Boolean _parentsOnly;
		private Boolean _themesOnly;
		private Boolean _wheelsOnly;

		#region PRIVATE PROPERTIES



		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS

		/// <summary>
		/// Gets or sets a value indicating whether [parents only].
		/// </summary>
		public Boolean ParentsOnly
		{
			get => _parentsOnly;
			set
			{
				if (value == _parentsOnly) return;
				_parentsOnly = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [themes only].
		/// </summary>
		public Boolean ThemesOnly
		{
			get => _themesOnly;
			set
			{
				if (value == _themesOnly) return;
				_themesOnly = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [wheels only].
		/// </summary>
		public Boolean WheelsOnly
		{
			get => _wheelsOnly;
			set
			{
				if (value == _wheelsOnly) return;
				_wheelsOnly = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

	}

}
