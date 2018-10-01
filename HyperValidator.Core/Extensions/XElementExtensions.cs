using System;
using System.Xml.Linq;

namespace HyperValidator.Core.Extensions
{

	/// <summary>
	/// Extension methods for the <see cref="XElement"/> class.
	/// </summary>
	public static class XElementExtensions
	{

		/// <summary>
		/// Gets a boolean value from an XElement node
		/// </summary>
		/// <param name="element">The <see cref="XElement"/> being extended by this method</param>
		/// <param name="name">The name of the child node to pull the boolean value from</param>
		/// <returns></returns>
		public static Boolean GetBool(this XElement element, String name)
		{
			var child = element.Element(XName.Get(name));
			if (child == null)
				return false;
			return (child.Value == "T" || child.Value == "1" || child.Value == "Y" || child.Value.ToLower() == "true");
		}

		/// <summary>
		/// Gets an int value from an XElement node
		/// </summary>
		/// <param name="element">The <see cref="XElement"/> being extended by this method</param>
		/// <param name="name">The name of the child node to pull the int from</param>
		/// <returns></returns>
		public static Boolean? GetNullableBool(this XElement element, String name)
		{
			var child = element.Element(XName.Get(name));
			if (child == null)
				return null;
			return (child.Value == "T" || child.Value == "1" || child.Value == "Y" || child.Value.ToLower() == "true");
		}

		/// <summary>
		/// Gets an int value from an XElement node
		/// </summary>
		/// <param name="element">The <see cref="XElement"/> being extended by this method</param>
		/// <param name="name">The name of the child node to pull the int from</param>
		/// <returns></returns>
		public static Int32 GetInt(this XElement element, String name)
		{
			var child = element.Element(XName.Get(name));
			var value = 0;
			if (child == null)
				return value;
			Int32.TryParse(child.Value, out value);
			return value;
		}

		/// <summary>
		/// Gets an int value from an XElement node
		/// </summary>
		/// <param name="element">The <see cref="XElement"/> being extended by this method</param>
		/// <param name="name">The name of the child node to pull the int from</param>
		/// <returns></returns>
		public static Int32? GetNullableInt(this XElement element, String name)
		{
			var child = element.Element(XName.Get(name));
			if (child == null)
				return null;
			var value = 0;
			Int32.TryParse(child.Value, out value);
			return value;
		}

		/// <summary>
		/// Gets an decimal value from an XElement node
		/// </summary>
		/// <param name="element">The <see cref="XElement"/> being extended by this method</param>
		/// <param name="name">The name of the child node to pull the decimal from</param>
		/// <returns>Returns a double value from the specified XML node</returns>
		public static Decimal GetDecimal(this XElement element, String name)
		{
			var child = element.Element(XName.Get(name));
			Decimal value = 0;
			if (child == null)
				return value;
			Decimal.TryParse(child.Value, out value);
			return value;
		}

		/// <summary>
		/// Gets a double value from an XElement node
		/// </summary>
		/// <param name="element">The <see cref="XElement"/> being extended by this method</param>
		/// <param name="name">The name of the child node to pull the double from</param>
		/// <returns>Returns a double value from the specified XML node</returns>
		public static Double GetDouble(this XElement element, String name)
		{
			var child = element.Element(XName.Get(name));
			Double value = 0;
			if (child == null)
				return value;
			Double.TryParse(child.Value, out value);
			return value;
		}

		/// <summary>
		/// Gets a string from the specified XML node
		/// </summary>
		/// <param name="element">The <see cref="XElement" /> being extended by this method</param>
		/// <param name="name">The name of the child node to pull the string from</param>
		/// <param name="defaultValue">The default value.</param>
		/// <returns>
		/// Returns a string from the specified XML node
		/// </returns>
		public static String GetString(this XElement element, String name, String defaultValue = "")
		{
			var child = element.Element(XName.Get(name));
			return child == null ? String.Empty : child.Value;
		}

		/// <summary>
		/// Gets the date time from this element.
		/// </summary>
		/// <param name="element">The element.</param>
		/// <param name="name">The child node name containing the date time.</param>
		/// <returns>
		/// Returns a nullable date time object parsed from the specified XML node
		/// </returns>
		public static DateTime GetDateTime(this XElement element, String name)
		{
			var child = element.Element(XName.Get(name));
			if (child == null)
				return DateTime.MinValue;

			DateTime result;
			if (DateTime.TryParse(child.Value, out result))
				return result;

			return DateTime.MinValue;
		}

	}

}
