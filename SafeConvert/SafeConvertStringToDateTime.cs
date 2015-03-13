namespace SafeConvert
{
	using System;

	/// <summary>
	/// This class implements converting from string type to DateTime? type
	/// </summary>
	public class SafeConvertStringToDateTime : ISafeConvert<string, DateTime?>
	{
		/// <summary>
		/// Converts data from string type to DateTime? type
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="defaultValue">default value of DateTime? data type</param>
		/// <returns>Returns DateTime? data type</returns>
		public DateTime? Convert(string data, DateTime? defaultValue)
		{
			if (data != null)
			{
				var s = data.Trim();
				DateTime dateTime;
				if (DateTime.TryParse(s, out dateTime))
				{
					return dateTime;
				}
			}
			return defaultValue;
		}
	}
}
