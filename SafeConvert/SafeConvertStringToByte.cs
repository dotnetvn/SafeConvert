namespace SafeConvert
{
	/// <summary>
	/// This class implements converting from string type to byte type
	/// </summary>
	public class SafeConvertStringToByte : ISafeConvert<string, byte>
	{
		/// <summary>
		/// Converts data from string type to byte type
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="defaultValue">default value of byte data type</param>
		/// <returns>Returns byte data type</returns>
		public byte Convert(string data, byte defaultValue)
		{
			if (data != null)
			{
				var s = data.Trim();
				byte n;
				if (byte.TryParse(s, out n))
				{
					return n;
				}
			}
			return defaultValue;
		}
	}
}
