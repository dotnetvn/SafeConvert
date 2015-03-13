namespace SafeConvert
{
	/// <summary>
	/// This class implements converting from object type to any type
	/// </summary>
	/// <typeparam name="T">any type</typeparam>
	public class SafeConvertObjToAny<T> : ISafeConvert<object, T>
	{
		/// <summary>
		/// Converts data from object type to T type
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="defaultValue">default value of T data type</param>
		/// <returns>Returns T data type</returns>
		public T Convert(object data, T defaultValue)
		{
			ISafeConvert<string, T> safeConvert = new SafeConvertStringToAny<T>();
			return safeConvert.Convert(data != null ? data.ToString() : string.Empty, defaultValue);
		}
	}
}
