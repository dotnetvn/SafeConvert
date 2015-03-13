namespace SafeConvert
{
	/// <summary>
	/// This class implements converting from object type to integer type
	/// </summary>
	public class SafeConvertObjToInt : ISafeConvert<object, int>
	{
		/// <summary>
		/// Converts data from object type to integer type
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="defaultValue">default value of integer data type</param>
		/// <returns>Returns integer data type</returns>
		public int Convert(object data, int defaultValue)
		{
			ISafeConvert<string, int> safeConvert = new SafeConvertStringToInt();
			return safeConvert.Convert(data != null ? data.ToString() : string.Empty, defaultValue);
		}
	}
}
