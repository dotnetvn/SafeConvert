namespace SafeConvert
{
	/// <summary>
	/// This class implements converting from string type to double type
	/// </summary>
	public class SafeConvertStringToDouble : ISafeConvert<string, double>
	{
		/// <summary>
		/// Converts data from string type to double type
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="defaultValue">default value of double data type</param>
		/// <returns>Returns double data type</returns>
		public double Convert(string data, double defaultValue)
		{
			if (data != null)
			{
				var s = data.Trim();
				double n;
				if (double.TryParse(s, out n))
				{
					return n;
				}
			}
			return defaultValue;
		}
	}
}
