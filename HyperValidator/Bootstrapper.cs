using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using HyperValidator.Application.Global.MainMenu;
using HyperValidator.Application.Global.Shell;
using HyperValidator.Core.Configuration;
using HyperValidator.Core.IO;
using HyperValidator.Core.Logging;
using HyperValidator.Core.Serialization;
using HyperValidator.Models;
using HyperValidator.Properties;
using log4net.Repository.Hierarchy;
using Ninject;

namespace HyperValidator
{

	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="Caliburn.Micro.BootstrapperBase" />
	public class Bootstrapper : BootstrapperBase
	{

		#region PROTECTED PROPERTIES


		/// <summary>
		/// Gets the kernel.
		/// </summary>
		protected IKernel Kernel { get; private set; }


		#endregion PROTECTED PROPERTIES

		#region CONSTRUCTORS


		/// <summary>
		/// Initializes a new instance of the <see cref="Bootstrapper" /> class.
		/// </summary>
		public Bootstrapper()
		{
			Initialize();
		}


		#endregion CONSTRUCTORS

		#region PROTECTED METHODS


		/// <summary>
		/// Override to configure the framework and setup your IoC container.
		/// </summary>
		protected override void Configure()
		{
			Kernel = new StandardKernel();
			base.Configure();

			Kernel.Bind<IShell>().To<ShellViewModel>();
			Kernel.Bind<IMainMenu>().To<MainMenuViewModel>();
			Kernel.Bind<IWindowManager>().To<WindowManager>();
			Kernel.Bind<IEventAggregator>().To<EventAggregator>();
			Kernel.Bind<IAppSettingsReader>().To<CoreAppSettingsReader>();
			Kernel.Bind<IConfigurationManager>().To<ConfigManagerWrapper>();
			Kernel.Bind<IFileUtility>().To<FileUtility>();
			Kernel.Bind<IDirectoryUtility>().To<DirectoryUtility>();
			Kernel.Bind<IPathUtility>().To<PathUtility>();
			Kernel.Bind<IHyperValidatorSettings>().To<HyperValidatorSettings>();

			var settings = Kernel.Get<IHyperValidatorSettings>();
			log4net.Config.XmlConfigurator.Configure();
			var log4NetLogger = log4net.LogManager.GetLogger(settings.LoggerName);
			Kernel.Bind<ILogger>().ToMethod(x => new Log4NetLogger(log4NetLogger, settings)).InSingletonScope();
			Kernel.Bind<IDatabaseSerializer>().To<DatabaseSerializer>();
		}


		#endregion PROTECTED METHODS

		#region DEPENDENCY INJECTION METHODS


		/// <summary>
		/// Override this to provide an IoC specific implementation.
		/// </summary>
		/// <param name="service">The service to locate.</param>
		/// <param name="key">The key to locate.</param>
		/// <returns>
		/// The located service.
		/// </returns>
		/// <exception cref="ArgumentNullException">service</exception>
		protected override Object GetInstance(Type service, String key)
		{
			if (service == null)
				throw new ArgumentNullException(nameof(service));

			return Kernel.Get(service, key);
		}

		/// <summary>
		/// Override this to provide an IoC specific implementation
		/// </summary>
		/// <param name="service">The service to locate.</param>
		/// <returns>
		/// The located services.
		/// </returns>
		protected override IEnumerable<Object> GetAllInstances(Type service)
		{
			return Kernel.GetAll(service);
		}

		/// <summary>
		/// Override this to provide an IoC specific implementation.
		/// </summary>
		/// <param name="instance">The instance to perform injection on.</param>
		protected override void BuildUp(Object instance)
		{
			Kernel.Inject(instance);
		}


		#endregion DEPENDENCY INJECTION METHODS

		#region EVENT HANDLERS


		/// <summary>
		/// Override this to add custom behavior to execute after the application starts.
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The args.</param>
		protected override void OnStartup(Object sender, StartupEventArgs e)
		{
			DisplayRootViewFor<IShell>();
		}

		/// <summary>
		/// Override this to add custom behavior for unhandled exceptions.
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The event args.</param>
		protected override void OnUnhandledException(Object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
		{

#if DEBUG
			MessageBox.Show(e.Exception.ToString());
#endif
			e.Handled = true;
		}

		/// <summary>
		/// Override this to add custom behavior on exit.
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The event args.</param>
		protected override void OnExit(Object sender, EventArgs e)
		{
			var startTime = Process.GetCurrentProcess().StartTime.ToUniversalTime();
			var endTime = DateTime.UtcNow;
			base.OnExit(sender, e);
			Environment.Exit(1);
		}


		#endregion EVENT HANDLERS

	}

}
