namespace SafeConvert
{
	/// <summary>
	/// This class implements converting from string type to decimal type
	/// </summary>
	public class SafeConvertStringToDecimal : ISafeConvert<string, decimal>
	{
		/// <summary>
		/// Converts data from string type to decimal type
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="defaultValue">default value of decimal data type</param>
		/// <returns>Returns decimal data type</returns>
		public decimal Convert(string data, decimal defaultValue)
		{
			if (data != null)
			{
				var s = data.Trim();
				decimal n;
				if (decimal.TryParse(s, out n))
				{
					return n;
				}
			}
			return defaultValue;
		}
	}
}
