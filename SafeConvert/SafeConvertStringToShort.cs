namespace SafeConvert
{
	/// <summary>
	/// This class implements converting from string type to short type
	/// </summary>
	public class SafeConvertStringToShort : ISafeConvert<string, short>
	{
		/// <summary>
		/// Converts data from string type to short type
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="defaultValue">default value of short data type</param>
		/// <returns>Returns short data type</returns>
		public short Convert(string data, short defaultValue)
		{
			if (data != null)
			{
				var s = data.Trim();
				short n;
				if (short.TryParse(s, out n))
				{
					return n;
				}
			}
			return defaultValue;
		}
	}
}
