using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HyperValidator.Core.Extensions
{

	/// <summary>
	/// 
	/// </summary>
	public static class XDocumentExtensions
	{

		/// <summary>
		/// Gets a boolean value from an XElement node
		/// </summary>
		/// <param name="document">The <see cref="XDocument"/> being extended by this method</param>
		/// <param name="name">The name of the child node to pull the boolean value from</param>
		/// <returns></returns>
		public static Boolean GetBool(this XDocument document, String name)
		{
			var child = document.Element(XName.Get(name));
			if (child == null)
				return false;
			return (child.Value == "T" || child.Value == "1" || child.Value == "Y");
		}

		/// <summary>
		/// Gets an int value from an XElement node
		/// </summary>
		/// <param name="document">The <see cref="XDocument"/> being extended by this method</param>
		/// <param name="name">The name of the child node to pull the int from</param>
		/// <returns></returns>
		public static Int32 GetInt(this XDocument document, String name)
		{
			var child = document.Element(XName.Get(name));
			Int32 value = 0;
			if (child == null)
				return value;
			Int32.TryParse(child.Value, out value);
			return value;
		}

		/// <summary>
		/// Gets an decimal value from an XElement node
		/// </summary>
		/// <param name="document">The <see cref="XDocument"/> being extended by this method</param>
		/// <param name="name">The name of the child node to pull the decimal from</param>
		/// <returns>Returns a double value from the specified XML node</returns>
		public static Decimal GetDecimal(this XDocument document, String name)
		{
			var child = document.Element(XName.Get(name));
			Decimal value = 0;
			if (child == null)
				return value;
			Decimal.TryParse(child.Value, out value);
			return value;
		}

		/// <summary>
		/// Gets a double value from an XElement node
		/// </summary>
		/// <param name="document">The <see cref="XDocument"/> being extended by this method</param>
		/// <param name="name">The name of the child node to pull the double from</param>
		/// <returns>Returns a double value from the specified XML node</returns>
		public static Double GetDouble(this XDocument document, String name)
		{
			var child = document.Element(XName.Get(name));
			Double value = 0;
			if (child == null)
				return value;
			Double.TryParse(child.Value, out value);
			return value;
		}

		/// <summary>
		/// Gets a string from the specified XML node
		/// </summary>
		/// <param name="document">The <see cref="XDocument"/> being extended by this method</param>
		/// <param name="name">The name of the child node to pull the string from</param>
		/// <returns>Returns a string from the specified XML node</returns>
		public static String GetString(this XDocument document, String name)
		{
			var child = document.Element(XName.Get(name));
			if (child == null)
				return String.Empty;
			return child.Value;
		}

		/// <summary>
		/// Gets the date time from this element.
		/// </summary>
		/// <param name="document">The element.</param>
		/// <param name="name">The child node name containing the date time.</param>
		/// <returns>Returns a nullable date time object parsed from the specified XML node</returns>
		public static DateTime? GetDateTime(this XDocument document, String name)
		{
			var child = document.Element(XName.Get(name));
			if (child == null)
				return null;

			DateTime result;
			if (DateTime.TryParse(child.Value, out result))
				return result;

			return null;
		}


	}

}
