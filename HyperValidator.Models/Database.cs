using System;
using System.Collections.Generic;

namespace HyperValidator.Models
{

	/// <summary>
	/// 
	/// </summary>
	public class Database : Entity
	{

		/// <summary>
		/// Gets or sets the file.
		/// </summary>
		public String File { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public String Name { get; set; }

		/// <summary>
		/// Gets or sets the exporter version.
		/// </summary>
		public String ExporterVersion { get; set; }

		/// <summary>
		/// Gets or sets the list version.
		/// </summary>
		public String ListVersion { get; set; }

		/// <summary>
		/// Gets or sets the last updated.
		/// </summary>
		public DateTime LastUpdated { get; set; }

		/// <summary>
		/// Gets or sets the games.
		/// </summary>
		public List<Game> Games { get; set; }

	}

}
