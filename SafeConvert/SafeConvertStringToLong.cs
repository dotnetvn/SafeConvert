namespace SafeConvert
{
	/// <summary>
	/// This class implements converting from string type to long type
	/// </summary>
	public class SafeConvertStringToLong : ISafeConvert<string, long>
	{
		/// <summary>
		/// Converts data from string type to long type
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="defaultValue">default value of long data type</param>
		/// <returns>Returns long data type</returns>
		public long Convert(string data, long defaultValue)
		{
			if (data != null)
			{
				var s = data.Trim();
				long n;
				if (long.TryParse(s, out n))
				{
					return n;
				}
			}
			return defaultValue;
		}
	}
}
