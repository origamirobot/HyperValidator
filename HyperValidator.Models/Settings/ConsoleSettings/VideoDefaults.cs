using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperValidator.Models.Settings
{

	/// <summary>
	/// Contains default video settings for this console.
	/// </summary>
	/// <seealso cref="HyperValidator.Models.Entity" />
	public class VideoDefaults : Entity
	{

		#region PRIVATE PROPERTIES


		private String _path;


		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets the path.
		/// </summary>
		public String Path
		{
			get => _path;
			set
			{
				if (value == _path) return;
				_path = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

	}

}
