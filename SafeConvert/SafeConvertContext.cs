namespace SafeConvert
{
	/// <summary>
	/// This class implements as a wrapper for all implements of the safe convert
	/// </summary>
	/// <typeparam name="T1">any type</typeparam>
	/// <typeparam name="T2">any type</typeparam>
	public class SafeConvertContext<T1, T2>
	{
		/// <summary>
		/// Gets or sets the _safeConvert field. This field contains the implement of the specified safe convert
		/// </summary>
		private readonly ISafeConvert<T1, T2> _safeConvert;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SafeConvert.SafeConvertContext"/> class by the specified safe convert.
		/// </summary>
		/// <param name="safeConvert">specified safe convert</param>
		public SafeConvertContext(ISafeConvert<T1, T2> safeConvert)
		{
			_safeConvert = safeConvert;
		}

		/// <summary>
		/// Converts data from specified type to another specified type
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="defaultValue">default value of T2 data type</param>
		/// <returns>Returns T2 data type</returns>
		public T2 Convert(T1 data, T2 defaultValue)
		{
			return _safeConvert.Convert(data, defaultValue);
		}
	}
}
