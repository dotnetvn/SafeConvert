using System;

namespace SafeConvert
{
	using System.Reflection;

	/// <summary>
	/// This class implements converting from string type to any type
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
				Type[] argTypes = { typeof(string), typeof(T).MakeByRefType() };
				var tryParseMethodInfo = typeof(T).GetMethod("TryParse", argTypes);
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
