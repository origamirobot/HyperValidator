using System;

namespace HyperValidator.Models.INI
{

	/// <summary>
	/// 
	/// </summary>
	public class IniValue
	{

		/// <summary>
		/// Gets or sets the key.
		/// </summary>
		public String Key { get; set; }

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		public String Value { get; set; }


		/// <summary>
		/// Converts this value to a boolean value.
		/// </summary>
		/// <returns></returns>
		public Boolean ToBoolean()
		{
			Boolean.TryParse(Value, out var result);
			return result;
		}

		/// <summary>
		/// Converts this value to a Int32 value.
		/// </summary>
		/// <returns></returns>
		public Int32 ToInt32()
		{
			Int32.TryParse(Value, out var result);
			return result;
		}
		
		/// <summary>
		/// Converts this value to a Decimal value.
		/// </summary>
		/// <returns></returns>
		public Decimal ToDecimal()
		{
			Decimal.TryParse(Value, out var result);
			return result;
		}
		
		/// <summary>
		/// Converts this value to a Int32 value.
		/// </summary>
		/// <returns></returns>
		public T ToEnum<T>() where T : struct
		{
			Enum.TryParse<T>(Value, out var result);
			return result;
		}


		/// <summary>
		/// Returns a <see cref="System.String" /> that represents this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="System.String" /> that represents this instance.
		/// </returns>
		public override String ToString()
		{
			return $"{Key} = {Value}";
		}


	}

}
