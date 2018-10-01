using System;
using System.Collections.Generic;
using System.Linq;

namespace HyperValidator.Models.INI
{

	/// <summary>
	/// 
	/// </summary>
	public class IniFile
	{

		/// <summary>
		/// Gets or sets the sections.
		/// </summary>
		public List<IniSection> Sections { get; set; }

		/// <summary>
		/// Gets the <see cref="IniSection"/> with the specified name.
		/// </summary>
		/// <value>
		/// The <see cref="IniSection"/>.
		/// </value>
		/// <param name="name">The name.</param>
		/// <returns></returns>
		public IniSection this[String name]
		{
			get
			{
				var section = Sections.FirstOrDefault(x => x.Name == name);
				return section;
			}
		}
		
		/// <summary>
		/// Initializes a new instance of the <see cref="IniFile" /> class.
		/// </summary>
		public IniFile()
		{
			Sections = new List<IniSection>();
		}

	}

}
