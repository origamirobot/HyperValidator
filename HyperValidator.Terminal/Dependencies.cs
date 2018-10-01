using HyperValidator.Core.Configuration;
using HyperValidator.Core.IO;
using HyperValidator.Core.Logging;
using HyperValidator.Core.Repositories;
using HyperValidator.Core.Serialization;
using HyperValidator.Core.Validators;
using Ninject;

namespace HyperValidator.Terminal
{

	/// <summary>
	/// 
	/// </summary>
	public static class Dependencies
	{

		/// <summary>
		/// Registers all the needed dependencies with the specified Ninject kernel.
		/// </summary>
		/// <param name="kernel">The kernel.</param>
		public static void Register(IKernel kernel)
		{
			kernel.Bind<IAppSettingsReader>().To<CoreAppSettingsReader>();
			kernel.Bind<IConfigurationManager>().To<ConfigManagerWrapper>();
			kernel.Bind<IFileUtility>().To<FileUtility>();
			kernel.Bind<IDirectoryUtility>().To<DirectoryUtility>();
			kernel.Bind<IPathUtility>().To<PathUtility>();
			kernel.Bind<IHyperValidatorSettings>().To<HyperValidatorSettings>();

			var settings = kernel.Get<IHyperValidatorSettings>();
			log4net.Config.XmlConfigurator.Configure();
			var log4NetLogger = log4net.LogManager.GetLogger(settings.LoggerName);
			kernel.Bind<ILogger>().ToMethod(x => new Log4NetLogger(log4NetLogger, settings)).InSingletonScope();

			kernel.Bind<IConsoleSerializer>().To<ConsoleSerializer>();
			kernel.Bind<IDatabaseSerializer>().To<DatabaseSerializer>();
			kernel.Bind<IIniSerializer>().To<IniSerializer>();
			kernel.Bind<IGameValidator>().To<GameValidator>();
			kernel.Bind<IConsoleValidator>().To<ConsoleValidator>();
			kernel.Bind<IConsoleRepository>().To<ConsoleRepository>();
			kernel.Bind<ISystemRepository>().To<SystemRepository>();

		}


	}

}
