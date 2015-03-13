namespace SafeConvert
{
	/// <summary>
	/// This class implements converting from object type to short type
	/// </summary>
	public class SafeConvertObjToShort : ISafeConvert<object, short>
	{
		/// <summary>
		/// Converts data from object type to short type
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="defaultValue">default value of short data type</param>
		/// <returns>Returns short data type</returns>
		public short Convert(object data, short defaultValue)
		{
			ISafeConvert<string, short> safeConvert = new SafeConvertStringToShort();
			return safeConvert.Convert(data != null ? data.ToString() : string.Empty, defaultValue);
		}
	}
}
