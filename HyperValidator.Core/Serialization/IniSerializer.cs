using HyperValidator.Core.Configuration;
using HyperValidator.Core.IO;
using HyperValidator.Core.Logging;
using HyperValidator.Models.INI;
using System;
using System.IO;

namespace HyperValidator.Core.Serialization
{


	/// <summary>
	/// 
	/// </summary>
	public interface IIniSerializer
	{
		
		/// <summary>
		/// Deserializes the specified INI file into an INI object.
		/// </summary>
		/// <param name="location">The location.</param>
		/// <returns></returns>
		IniFile DeserializeFromFile(String location);

		/// <summary>
		/// Deserializes the specified text into an INI file.
		/// </summary>
		/// <param name="text">The text.</param>
		/// <returns></returns>
		IniFile Deserialize(String text);
		
		/// <summary>
		/// Serializes the specified INI object back into text.
		/// </summary>
		/// <param name="file">The file.</param>
		/// <returns></returns>
		String Serialize(IniFile file);
		
	}

	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="HyperValidator.Core.Serialization.IIniSerializer" />
	public class IniSerializer : IIniSerializer
	{

		#region PROTECTED PROPERTIES


		/// <summary>
		/// Gets the file utility.
		/// </summary>
		protected IFileUtility FileUtility { get; private set; }

		/// <summary>
		/// Gets the logger.
		/// </summary>
		protected ILogger Logger { get; private set; }

		/// <summary>
		/// Gets the settings.
		/// </summary>
		protected IHyperValidatorSettings Settings { get; private set; }


		#endregion PROTECTED PROPERTIES

		#region CONSTRUCTORS


		/// <summary>
		/// Initializes a new instance of the <see cref="IniSerializer"/> class.
		/// </summary>
		/// <param name="fileUtility">The file utility.</param>
		/// <param name="logger">The logger.</param>
		/// <param name="settings">The settings.</param>
		public IniSerializer(
			IFileUtility fileUtility,
			ILogger logger,
			IHyperValidatorSettings settings)
		{
			FileUtility = fileUtility;
			Logger = logger;
			Settings = settings;
		}


		#endregion CONSTRUCTORS

		#region PUBLIC METHODS


		/// <summary>
		/// Deserializes the specified INI file into an INI object.
		/// </summary>
		/// <param name="location">The location.</param>
		/// <returns></returns>
		public IniFile DeserializeFromFile(String location)
		{
			try
			{
				if (!FileUtility.Exists(location))
					throw new FileNotFoundException($"The file does not exist: {location}");

				var text = FileUtility.ReadAllText(location);
				return Deserialize(text);
			}
			catch (Exception ex)
			{
				Logger.Error(ex);
				throw;
			}
		}

		/// <summary>
		/// Deserializes the specified text into an INI file.
		/// </summary>
		/// <param name="text">The text.</param>
		/// <returns></returns>
		public IniFile Deserialize(String text)
		{
			try
			{
				var result = new IniFile();
				var rawSections = text.Split(new String [] { "[" }, StringSplitOptions.RemoveEmptyEntries);

				foreach (var rawSection in rawSections)
				{
					var rawProperties = rawSection.Split(new String[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

					var section = new IniSection() { Name = rawProperties[0].TrimEnd(']') };
					for (var i = 1; i < rawProperties.Length; i++)
					{
						var pieces = rawProperties[i].Split('=');
						var key = pieces?[0]?.Trim();
						var val = pieces?[1]?.Trim();
						if (String.IsNullOrEmpty(key) && String.IsNullOrEmpty(val))
							continue;

						section.Properties.Add(new IniValue() {Key = key, Value = val});
					}
					result.Sections.Add(section);
				}
				return result;
			}
			catch (Exception ex)
			{
				Logger.Error(ex);
				throw;
			}
		}

		/// <summary>
		/// Serializes the specified INI object back into text.
		/// </summary>
		/// <param name="file">The file.</param>
		/// <returns></returns>
		public String Serialize(IniFile file)
		{
			try
			{
				throw new NotImplementedException();
			}
			catch (Exception ex)
			{
				Logger.Error(ex);
				throw;
			}
		}


		#endregion PUBLIC METHODS

	}
}
