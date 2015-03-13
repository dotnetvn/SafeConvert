namespace SafeConvert
{
	/// <summary>
	/// This class implements converting from string type to float type
	/// </summary>
	public class SafeConvertStringToFloat : ISafeConvert<string, float>
	{
		/// <summary>
		/// Converts data from string type to float type
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="defaultValue">default value of float data type</param>
		/// <returns>Returns float data type</returns>
		public float Convert(string data, float defaultValue)
		{
			if (data != null)
			{
				var s = data.Trim();
				float n;
				if (float.TryParse(s, out n))
				{
					return n;
				}
			}
			return defaultValue;
		}
	}
}
