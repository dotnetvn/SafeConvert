namespace SafeConvert
{
	using System.Reflection;

	/// <summary>
	/// This class implements converting from string type to short type
	/// </summary>
	public class SafeConvertStringToAny<T> : ISafeConvert<string, T>
	{
		/// <summary>
		/// Converts data from string type to T type
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="defaultValue">default value of T data type</param>
		/// <returns>Returns T data type</returns>
		public T Convert(string data, T defaultValue)
		{
			if (data != null)
			{
				var tryParseMethodInfo = typeof(T).GetMethod("TryParse", BindingFlags.Public | BindingFlags.Static);
				if(tryParseMethodInfo != null)
				{
					var parameters = new object[] { data, null };
					var obj = tryParseMethodInfo.Invoke(null, parameters);
					if(obj is bool && (bool)obj)
					{
						return (T)parameters[1];
					}
				}
			}
			return defaultValue;
		}
	}
}
