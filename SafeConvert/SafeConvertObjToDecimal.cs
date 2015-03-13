namespace SafeConvert
{
	/// <summary>
	/// This class implements converting from object type to decimal type
	/// </summary>
	public class SafeConvertObjToDecimal : ISafeConvert<object, decimal>
	{
		/// <summary>
		/// Converts data from object type to decimal type
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="defaultValue">default value of decimal data type</param>
		/// <returns>Returns decimal data type</returns>
		public decimal Convert(object data, decimal defaultValue)
		{
			ISafeConvert<string, decimal> safeConvert = new SafeConvertStringToDecimal();
			return safeConvert.Convert(data != null ? data.ToString() : string.Empty, defaultValue);
		}
	}
}
