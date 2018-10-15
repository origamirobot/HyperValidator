using System;
using System.Collections.Generic;
using System.Linq;

namespace HyperValidator.Models.INI
{

	/// <summary>
	/// 
	/// </summary>
	public class IniSection
	{

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public String Name { get; set; }

		/// <summary>
		/// Gets or sets the properties.
		/// </summary>
		public List<IniValue> Properties { get; set; }

		/// <summary>
		/// Gets the <see cref="IniValue"/> with the specified name.
		/// </summary>
		/// <value>
		/// The <see cref="IniValue"/>.
		/// </value>
		/// <param name="name">The name.</param>
		/// <returns></returns>
		public IniValue this[String name]
		{
			get
			{
				var value = Properties.FirstOrDefault(x => x.Key == name);
				if (value == null)
				{

				}
				return value;
			}
		}
		
		/// <summary>
		/// Initializes a new instance of the <see cref="IniSection" /> class.
		/// </summary>
		public IniSection()
		{
			Properties = new List<IniValue>();
		}

		/// <summary>
		/// Returns a <see cref="System.String" /> that represents this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="System.String" /> that represents this instance.
		/// </returns>
		public override String ToString()
		{
			return Name;
		}

	}

}
