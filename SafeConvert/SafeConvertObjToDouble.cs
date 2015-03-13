namespace SafeConvert
{
	/// <summary>
	/// This class implements converting from object type to double type
	/// </summary>
	public class SafeConvertObjToDouble : ISafeConvert<object, double>
	{
		/// <summary>
		/// Converts data from object type to double type
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="defaultValue">default value of double data type</param>
		/// <returns>Returns double data type</returns>
		public double Convert(object data, double defaultValue)
		{
			ISafeConvert<string, double> safeConvert = new SafeConvertStringToDouble();
			return safeConvert.Convert(data != null ? data.ToString() : string.Empty, defaultValue);
		}
	}
}
