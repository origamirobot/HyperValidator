using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperValidator.Models.Settings;

namespace HyperValidator.Models
{

	/// <summary>
	/// Represents the whole HyperSpin system as a whole.
	/// </summary>
	public class HyperSpin : Entity
	{

		#region PRIVATE PROPERTIES


		private List<Console> _consoles;
		private HyperSpinSettings _settings;


		#endregion PRIVATE PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets or sets the consoles.
		/// </summary>
		public List<HyperValidator.Models.Console> Consoles
		{
			get => _consoles;
			set
			{
				if (Equals(value, _consoles)) return;
				_consoles = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Gets or sets the settings.
		/// </summary>
		public HyperSpinSettings Settings
		{
			get => _settings;
			set
			{
				if (Equals(value, _settings)) return;
				_settings = value;
				OnPropertyChanged();
			}
		}


		#endregion PUBLIC ACCESSORS

		#region CONSTRUCTORS


		/// <summary>
		/// Initializes a new instance of the <see cref="HyperSpin" /> class.
		/// </summary>
		public HyperSpin()
		{
			Consoles = new List<Console>();
			Settings = new HyperSpinSettings();
		}


		#endregion CONSTRUCTORS

	}

}
