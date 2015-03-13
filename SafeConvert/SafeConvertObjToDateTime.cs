namespace SafeConvert
{
	using System;

	/// <summary>
	/// This class implements converting from object type to DateTime? type
	/// </summary>
	public class SafeConvertObjToDateTime : ISafeConvert<object, DateTime?>
	{
		/// <summary>
		/// Converts data from object type to DateTime? type
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="defaultValue">default value of DateTime? data type</param>
		/// <returns>Returns DateTime? data type</returns>
		public DateTime? Convert(object data, DateTime? defaultValue)
		{
			ISafeConvert<string, DateTime?> safeConvert = new SafeConvertStringToDateTime();
			return safeConvert.Convert(data != null ? data.ToString() : string.Empty, defaultValue);
		}
	}
}
