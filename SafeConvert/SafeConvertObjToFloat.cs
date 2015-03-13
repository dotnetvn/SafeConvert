namespace SafeConvert
{
	/// <summary>
	/// This class implements converting from object type to float type
	/// </summary>
	public class SafeConvertObjToFloat : ISafeConvert<object, float>
	{
		/// <summary>
		/// Converts data from object type to float type
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="defaultValue">default value of float data type</param>
		/// <returns>Returns float data type</returns>
		public float Convert(object data, float defaultValue)
		{
			ISafeConvert<string, float> safeConvert = new SafeConvertStringToFloat();
			return safeConvert.Convert(data != null ? data.ToString() : string.Empty, defaultValue);
		}
	}
}
