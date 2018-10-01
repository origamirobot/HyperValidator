using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using HyperValidator.Application.Global.Home;
using HyperValidator.Application.Global.MainMenu;
using HyperValidator.Core.Configuration;
using HyperValidator.Models;

namespace HyperValidator.Application.Global.Shell
{


	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="ValidatorScreen" />
	/// <seealso cref="HyperValidator.Application.Global.Shell.IShell" />
	public class ShellViewModel : Conductor<ValidatorScreen>, IShell
	{

		#region PUBLIC ACCESSORS


		/// <summary>
		/// Gets the main menu.
		/// </summary>
		public IMainMenu MainMenu { get; private set; }

		/// <summary>
		/// Gets the settings.
		/// </summary>
		public IHyperValidatorSettings Settings { get; private set; }


		#endregion PUBLIC ACCESSORS

		#region CONSTRUCTORS


		/// <summary>
		/// Initializes a new instance of the <see cref="ShellViewModel" /> class.
		/// </summary>
		/// <param name="mainMenu">The main menu.</param>
		/// <param name="settings">The settings.</param>
		public ShellViewModel(
			IMainMenu mainMenu,
			IHyperValidatorSettings settings)
		{
			MainMenu = mainMenu;
			Settings = settings;
		}



		#endregion CONSTRUCTORS

		#region PROTECTED METHODS


		/// <summary>
		/// Called the first time the page's LayoutUpdated event fires after it is navigated to.
		/// </summary>
		/// <param name="view"></param>
		protected override void OnViewReady(object view)
		{
			base.OnViewReady(view);
			ActivateItem(new HomeViewModel());
		}


		#endregion PROTECTED METHODS


	}

}
