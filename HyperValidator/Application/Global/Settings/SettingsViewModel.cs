using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using HyperValidator.Core.Logging;
using HyperValidator.Core.Repositories;
using HyperValidator.Models;

namespace HyperValidator.Application.Global
{


	/// <summary>
	/// 
	/// </summary>
	public class SettingsViewModel : ValidatorScreen
	{

		#region PRIVATE PROPERTIES


		private HyperSpin _hyperSpin;
		private HyperValidator.Models.Console _selectedConsole;

		#endregion PRIVATE PROPERTIES

		#region PROTECTED PROPERTIES


		/// <summary>
		/// Gets the logger.
		/// </summary>
		protected ILogger Logger { get; private set; }

		/// <summary>
		/// Gets the system repository.
		/// </summary>
		protected ISystemRepository SystemRepository { get; private set; }

		/// <summary>
		/// Gets the console repository.
		/// </summary>
		protected IConsoleRepository ConsoleRepository { get; private set; }


		#endregion PROTECTED PROPERTIES

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets the hyper spin.
		/// </summary>
		public HyperSpin HyperSpin
		{
			get => _hyperSpin;
			private set
			{
				if (Equals(value, _hyperSpin)) return;
				_hyperSpin = value;
				NotifyOfPropertyChange();
			}
		}

		/// <summary>
		/// Gets or sets the selected console.
		/// </summary>
		public HyperValidator.Models.Console SelectedConsole
		{
			get => _selectedConsole;
			set
			{
				if (Equals(value, _selectedConsole)) return;
				_selectedConsole = value;
				NotifyOfPropertyChange();
			}
		}

		#endregion PUBLIC ACCESSORS

		#region CONSTRUCTORS


		/// <summary>
		/// Initializes a new instance of the <see cref="SettingsViewModel" /> class.
		/// </summary>
		/// <param name="logger">The logger.</param>
		/// <param name="systemRepository">The system repository.</param>
		/// <param name="consoleRepository">The console repository.</param>
		public SettingsViewModel(
			ILogger logger, 
			ISystemRepository systemRepository, 
			IConsoleRepository consoleRepository)
		{
			Logger = logger;
			SystemRepository = systemRepository;
			ConsoleRepository = consoleRepository;
		}


		#endregion CONSTRUCTORS

		#region PROTECTED METHODS



		/// <summary>
		/// Called when [view loaded].
		/// </summary>
		/// <param name="view">The view.</param>
		protected override void OnViewLoaded(Object view)
		{
			base.OnViewLoaded(view);
			HyperSpin = SystemRepository.Get();
		}


		#endregion PROTECTED METHODS

		#region PUBLIC METHODS



		/// <summary>
		/// Lookups the console information.
		/// </summary>
		/// <returns></returns>
		public async Task LookupConsoleInfo()
		{
			if (!SelectedConsole.Loaded)
			{
				SelectedConsole = ConsoleRepository.Get(SelectedConsole.Name, false);
				SelectedConsole.Loaded = true;
			}

			await Task.Yield();
		}


		#endregion PUBLIC METHODS

	}

}
