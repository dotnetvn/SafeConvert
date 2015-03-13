namespace SafeConvert
{
	/// <summary>
	/// This class implements converting from object type to long type
	/// </summary>
	public class SafeConvertObjToLong : ISafeConvert<object, long>
	{
		/// <summary>
		/// Converts data from object type to long type
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="defaultValue">default value of long data type</param>
		/// <returns>Returns long data type</returns>
		public long Convert(object data, long defaultValue)
		{
			ISafeConvert<string, long> safeConvert = new SafeConvertStringToLong();
			return safeConvert.Convert(data != null ? data.ToString() : string.Empty, defaultValue);
		}
	}
}
