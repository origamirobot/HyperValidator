using HyperValidator.Core.Configuration;
using HyperValidator.Core.IO;
using HyperValidator.Core.Logging;
using HyperValidator.Models;
using HyperValidator.Core.Extensions;
using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace HyperValidator.Core.Serialization
{


	/// <summary>
	/// 
	/// </summary>
	public interface IDatabaseSerializer
	{


		/// <summary>
		/// Deserializes the specified XML.
		/// </summary>
		/// <param name="text">The text.</param>
		/// <returns></returns>
		Database Deserialize(String text);

		/// <summary>
		/// Deserializes a <see cref="Database"/> from a file.
		/// </summary>
		/// <param name="location">The location of the file.</param>
		/// <returns></returns>
		Database DeserializeFromFile(String location);

		/// <summary>
		/// Serializes the specified database.
		/// </summary>
		/// <param name="database">The database.</param>
		/// <returns></returns>
		String Serialize(Database database);

	}

	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HyperValidator.Core.Serialization.IDatabaseSerializer" />
	public class DatabaseSerializer : IDatabaseSerializer
	{

		#region PROTECTED PROPERTIES


		/// <summary>
		/// Gets the logger.
		/// </summary>
		protected ILogger Logger { get; private set; }

		/// <summary>
		/// Gets the settings.
		/// </summary>
		protected IHyperValidatorSettings Settings { get; private set; }

		/// <summary>
		/// Gets the file utility.
		/// </summary>
		protected IFileUtility FileUtility { get; private set; }


		#endregion PROTECTED PROPERTIES

		#region CONSTRUCTORS


		/// <summary>
		/// Initializes a new instance of the <see cref="DatabaseSerializer" /> class.
		/// </summary>
		/// <param name="logger">The logger.</param>
		/// <param name="settings">The settings.</param>
		/// <param name="fileUtility">The file utility.</param>
		public DatabaseSerializer(
			ILogger logger, 
			IHyperValidatorSettings settings, 
			IFileUtility fileUtility)
		{
			Logger = logger;
			Settings = settings;
			FileUtility = fileUtility;
		}


		#endregion CONSTRUCTORS

		#region PUBLIC ACCESSORS



		/// <summary>
		/// Deserializes the specified XML.
		/// </summary>
		/// <param name="text">The text.</param>
		/// <returns></returns>
		public Database Deserialize(String text)
		{
			try
			{
				var xml = XDocument.Parse(text);
				if (xml.Document == null)
					throw new InvalidOperationException("Couldn't deserialize database file");

				var menu = xml.Document.Element(XName.Get("menu"));
				if(menu == null)
					throw new InvalidOperationException("Couldn't deserialize database file");

				var header = menu.Element(XName.Get("header"));
				if(header == null)
					throw new InvalidOperationException("Couldn't deserialize database file");


				var database = new Database
				{
					ExporterVersion = header.GetString("exporterversion"),
					ListVersion = header.GetString("listversion"),
					LastUpdated = header.GetDateTime("lastlistupdate"),
					Name = header.GetString("listname"),
					Games = new System.Collections.Generic.List<Game>()
				};


				var gamesXml = menu.Elements("game");
				foreach (var gameXml in gamesXml)
				{
					var nameAttrib = gameXml.Attribute(XName.Get("name"))?.Value;
					var indexedAttrib = gameXml.Attribute(XName.Get("index"))?.Value;
					var imageAttrib = gameXml.Attribute(XName.Get("image"))?.Value;

					var game = new Game()
					{
						Name = nameAttrib,
						Indexed = indexedAttrib != null && indexedAttrib == "true",
						Image = imageAttrib,
						Description = gameXml.GetString("description"),
						CloneOf = gameXml.GetString("cloneof"),
						Checksum = gameXml.GetString("crc"),
						Manufacturer = gameXml.GetString("manufacturer"),
						Year = gameXml.GetInt("year"),
						Enabled = gameXml.GetBool("enabled"),
						Genre = gameXml.GetString("genre"),
						Rating = gameXml.GetString("rating")
					};
					database.Games.Add(game);
				}

				Logger.Debug($"Read {database.Games.Count} games from database {database.Name}");

				return database;
			}
			catch (Exception ex)
			{
				Logger.Error(ex);
				throw;
			}
		}

		/// <summary>
		/// Deserializes a <see cref="Database" /> from a file.
		/// </summary>
		/// <param name="location">The location of the file.</param>
		/// <returns></returns>
		public Database DeserializeFromFile(String location)
		{
			try
			{
				if (!FileUtility.Exists(location))
					throw new FileNotFoundException($"The file does not exist: {location}");

				var text = FileUtility.ReadAllText(location);
				var database = Deserialize(text);
				database.File = location;
				return database;
			}
			catch (Exception ex)
			{
				Logger.Error(ex);
				throw;
			}
		}

		/// <summary>
		/// Serializes the specified database.
		/// </summary>
		/// <param name="database">The database.</param>
		/// <returns></returns>
		public String Serialize(Database database)
		{
			throw new NotImplementedException();
		}



		#endregion PUBLIC ACCESSORS

	}

}
