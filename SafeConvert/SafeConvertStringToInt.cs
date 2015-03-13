namespace SafeConvert
{
	/// <summary>
	/// This class implements converting from string type to integer type
	/// </summary>
	public class SafeConvertStringToInt : ISafeConvert<string, int>
	{
		/// <summary>
		/// Converts data from string type to integer type
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="defaultValue">default value of integer data type</param>
		/// <returns>Returns integer data type</returns>
		public int Convert(string data, int defaultValue)
		{
			if (data != null)
			{
				var s = data.Trim();
				int n;
				if (int.TryParse(s, out n))
				{
					return n;
				}
			}
			return defaultValue;
		}
	}
}
