namespace SafeConvert
{
	/// <summary>
	/// This class implements converting from object type to byte type
	/// </summary>
	public class SafeConvertObjToByte : ISafeConvert<object, byte>
	{
		/// <summary>
		/// Converts data from object type to byte type
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="defaultValue">default value of byte data type</param>
		/// <returns>Returns byte data type</returns>
		public byte Convert(object data, byte defaultValue)
		{
			ISafeConvert<string, byte> safeConvert = new SafeConvertStringToByte();
			return safeConvert.Convert(data != null ? data.ToString() : string.Empty, defaultValue);
		}
	}
}
