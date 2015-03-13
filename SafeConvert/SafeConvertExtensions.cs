namespace SafeConvert
{
	using System;

	/// <summary>
	/// This static class contains all essential things to help to convert data between two different data types.
	/// </summary>
    public static class SafeConvertExtensions
    {
		/// <summary>
		/// Converts data from object type to byte type
		/// </summary>
		/// <param name="obj">input data</param>
		/// <param name="defaultValue">default value of byte data type</param>
		/// <returns>Returns byte data type</returns>
		public static byte ToByte(this object obj, byte defaultValue = 0)
		{
			return new SafeConvertContext<object, byte>(new SafeConvertObjToByte()).Convert(obj, defaultValue);
		}

		/// <summary>
		/// Converts data from string type to byte type
		/// </summary>
		/// <param name="obj">input data</param>
		/// <param name="defaultValue">default value of byte data type</param>
		/// <returns>Returns byte data type</returns>
		public static byte ToByte(this string obj, byte defaultValue = 0)
		{
			return new SafeConvertContext<string, byte>(new SafeConvertObjToByte()).Convert(obj, defaultValue);
		}

		/// <summary>
		/// Converts data from object type to short type
		/// </summary>
		/// <param name="obj">input data</param>
		/// <param name="defaultValue">default value of short data type</param>
		/// <returns>Returns short data type</returns>
		public static short ToShort(this object obj, short defaultValue = 0)
		{
			return new SafeConvertContext<object, short>(new SafeConvertObjToShort()).Convert(obj, defaultValue);
		}

		/// <summary>
		/// Converts data from string type to short type
		/// </summary>
		/// <param name="obj">input data</param>
		/// <param name="defaultValue">default value of short data type</param>
		/// <returns>Returns short data type</returns>
		public static short ToShort(this string obj, short defaultValue = 0)
		{
			return new SafeConvertContext<string, short>(new SafeConvertStringToShort()).Convert(obj, defaultValue);
		}

		/// <summary>
		/// Converts data from object type to integer type
		/// </summary>
		/// <param name="obj">input data</param>
		/// <param name="defaultValue">default value of integer data type</param>
		/// <returns>Returns integer data type</returns>
		public static int ToInt(this object obj, int defaultValue = 0)
		{
			return new SafeConvertContext<object, int>(new SafeConvertObjToInt()).Convert(obj, defaultValue);
		}

		/// <summary>
		/// Converts data from string type to integer type
		/// </summary>
		/// <param name="obj">input data</param>
		/// <param name="defaultValue">default value of integer data type</param>
		/// <returns>Returns integer data type</returns>
		public static int ToInt(this string obj, int defaultValue = 0)
		{
			return new SafeConvertContext<string, int>(new SafeConvertStringToInt()).Convert(obj, defaultValue);
		}

		/// <summary>
		/// Converts data from object type to long type
		/// </summary>
		/// <param name="obj">input data</param>
		/// <param name="defaultValue">default value of long data type</param>
		/// <returns>Returns long data type</returns>
		public static long ToLong(this object obj, long defaultValue = 0)
		{
			return new SafeConvertContext<object, long>(new SafeConvertObjToLong()).Convert(obj, defaultValue);
		}

		/// <summary>
		/// Converts data from string type to long type
		/// </summary>
		/// <param name="obj">input data</param>
		/// <param name="defaultValue">default value of long data type</param>
		/// <returns>Returns long data type</returns>
		public static long ToLong(this string obj, long defaultValue = 0)
		{
			return new SafeConvertContext<string, long>(new SafeConvertStringToLong()).Convert(obj, defaultValue);
		}

		/// <summary>
		/// Converts data from object type to float type
		/// </summary>
		/// <param name="obj">input data</param>
		/// <param name="defaultValue">default value of float data type</param>
		/// <returns>Returns float data type</returns>
		public static float ToFloat(this object obj, float defaultValue = 0)
		{
			return new SafeConvertContext<object, float>(new SafeConvertObjToFloat()).Convert(obj, defaultValue);
		}

		/// <summary>
		/// Converts data from string type to float type
		/// </summary>
		/// <param name="obj">input data</param>
		/// <param name="defaultValue">default value of float data type</param>
		/// <returns>Returns float data type</returns>
		public static float ToFloat(this string obj, float defaultValue = 0)
		{
			return new SafeConvertContext<string, float>(new SafeConvertStringToFloat()).Convert(obj, defaultValue);
		}

		/// <summary>
		/// Converts data from object type to decimal type
		/// </summary>
		/// <param name="obj">input data</param>
		/// <param name="defaultValue">default value of decimal data type</param>
		/// <returns>Returns decimal data type</returns>
		public static decimal ToDecimal(this object obj, decimal defaultValue = 0)
		{
			return new SafeConvertContext<object, decimal>(new SafeConvertObjToDecimal()).Convert(obj, defaultValue);
		}

		/// <summary>
		/// Converts data from string type to decimal type
		/// </summary>
		/// <param name="obj">input data</param>
		/// <param name="defaultValue">default value of decimal data type</param>
		/// <returns>Returns decimal data type</returns>
		public static decimal ToDecimal(this string obj, decimal defaultValue = 0)
		{
			return new SafeConvertContext<string, decimal>(new SafeConvertStringToDecimal()).Convert(obj, defaultValue);
		}

		/// <summary>
		/// Converts data from object type to double type
		/// </summary>
		/// <param name="obj">input data</param>
		/// <param name="defaultValue">default value of double data type</param>
		/// <returns>Returns double data type</returns>
		public static double ToDouble(this object obj, double defaultValue = 0)
		{
			return new SafeConvertContext<object, double>(new SafeConvertObjToDouble()).Convert(obj, defaultValue);
		}

		/// <summary>
		/// Converts data from string type to double type
		/// </summary>
		/// <param name="obj">input data</param>
		/// <param name="defaultValue">default value of double data type</param>
		/// <returns>Returns double data type</returns>
		public static double ToDouble(this string obj, double defaultValue = 0)
		{
			return new SafeConvertContext<string, double>(new SafeConvertObjToDouble()).Convert(obj, defaultValue);
		}

		/// <summary>
		/// Converts data from object type to DateTime type
		/// </summary>
		/// <param name="obj">input data</param>
		/// <param name="defaultValue">default value of DateTime data type</param>
		/// <returns>Returns DateTime data type</returns>
		public static DateTime? ToDateTime(this object obj, DateTime? defaultValue = null)
		{
			return new SafeConvertContext<object, DateTime?>(new SafeConvertObjToDateTime()).Convert(obj, defaultValue);
		}

		/// <summary>
		/// Converts data from string type to DateTime type
		/// </summary>
		/// <param name="obj">input data</param>
		/// <param name="defaultValue">default value of DateTime data type</param>
		/// <returns>Returns DateTime data type</returns>
		public static DateTime? ToDateTime(this string obj, DateTime? defaultValue = null)
		{
			return new SafeConvertContext<string, DateTime?>(new SafeConvertObjToDateTime()).Convert(obj, defaultValue);
		}

		/// <summary>
		/// Converts data from object type to T type
		/// </summary>
		/// <param name="obj">input data</param>
		/// <param name="defaultValue">default value of T data type</param>
		/// <returns>Returns T data type</returns>
		public static T To<T>(this object obj, T defaultValue = default(T))
		{
			return new SafeConvertContext<object, T>(new SafeConvertObjToAny<T>()).Convert(obj, defaultValue);
		}

		/// <summary>
		/// Converts data from string type to T type
		/// </summary>
		/// <param name="obj">input data</param>
		/// <param name="defaultValue">default value of T data type</param>
		/// <returns>Returns T data type</returns>
		public static T To<T>(this string obj, T defaultValue = default(T))
		{
			return new SafeConvertContext<string, T>(new SafeConvertStringToAny<T>()).Convert(obj, defaultValue);
		}
    }
}
