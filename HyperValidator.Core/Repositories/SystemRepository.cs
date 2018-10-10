using HyperValidator.Core.Configuration;
using HyperValidator.Core.IO;
using HyperValidator.Core.Logging;
using HyperValidator.Core.Serialization;
using System;
using System.Xml.Linq;
using HyperValidator.Models;
using HyperValidator.Models.Settings;

namespace HyperValidator.Core.Repositories
{

	/// <summary>
	/// Responsible for pulling all the data about this hyperspin system and stuffing it into an object.
	/// </summary>
	/// <seealso cref="HyperValidator.Core.Repositories.ISystemRepository" />
	public interface ISystemRepository
	{

		/// <summary>
		/// Gets the the settings for the hyperspin system.
		/// </summary>
		/// <returns></returns>
		HyperSpin Get();

	}

	/// <summary>
	/// Responsible for pulling all the data about this hyperspin system and stuffing it into an object.
	/// </summary>
	/// <seealso cref="HyperValidator.Core.Repositories.ISystemRepository" />
	public class SystemRepository : ISystemRepository
	{

		#region PROTECTED PROPERTIES


		/// <summary>
		/// Gets or sets the logger.
		/// </summary>
		protected ILogger Logger { get; private set; }

		/// <summary>
		/// Gets or sets the directory utility.
		/// </summary>
		protected IDirectoryUtility DirectoryUtility { get; private set; }

		/// <summary>
		/// Gets or sets the file utility.
		/// </summary>
		protected IFileUtility FileUtility { get; private set; }

		/// <summary>
		/// Gets or sets the path utility.
		/// </summary>
		protected IPathUtility PathUtility { get; private set; }

		/// <summary>
		/// Gets the settings.
		/// </summary>
		protected IHyperValidatorSettings Settings { get; private set; }

		/// <summary>
		/// Gets the console repository.
		/// </summary>
		protected IConsoleRepository ConsoleRepository { get; private set; }


		#endregion PROTECTED PROPERTIES

		#region CONSTRUCTORS


		/// <summary>
		/// Initializes a new instance of the <see cref="SystemRepository" /> class.
		/// </summary>
		/// <param name="settings">The settings.</param>
		/// <param name="logger">The logger.</param>
		/// <param name="directoryUtility">The directory utility.</param>
		/// <param name="fileUtility">The file utility.</param>
		/// <param name="pathUtility">The path utility.</param>
		/// <param name="consoleRepository">The console repository.</param>
		public SystemRepository(
			IHyperValidatorSettings settings, 
			ILogger logger, 
			IDirectoryUtility directoryUtility, 
			IFileUtility fileUtility, 
			IPathUtility pathUtility, 
			IConsoleRepository consoleRepository)
		{
			Settings = settings;
			Logger = logger;
			DirectoryUtility = directoryUtility;
			FileUtility = fileUtility;
			PathUtility = pathUtility;
			ConsoleRepository = consoleRepository;
		}


		#endregion CONSTRUCTORS

		#region PUBLIC METHODS


		/// <summary>
		/// Gets the the settings for the hyperspin system.
		/// </summary>
		/// <returns></returns>
		public HyperSpin Get()
		{
			var hyperspin = new HyperSpin();

			var databasePath = PathUtility.Combine(Settings.HyperSpinRootLocation, "Databases\\Main Menu\\Main Menu.xml");
			var xml = FileUtility.ReadAllText(databasePath);
			var database = XDocument.Parse(xml);

			var menu = database.Document.Element(XName.Get("menu"));

			foreach (var item in menu.Elements())
			{
				var name = item.Attribute(XName.Get("name")).Value;
				var console = new HyperValidator.Models.Console()
				{
					Name = name
				};
				hyperspin.Consoles.Add(console);
			}
			return hyperspin;
		}


		#endregion PUBLIC METHODS

	}

}
