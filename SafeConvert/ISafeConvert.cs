namespace SafeConvert
{
	/// <summary>
	/// This interface defines the converting between two specified data types together
	/// </summary>
	/// <typeparam name="T1">any type</typeparam>
	/// <typeparam name="T2">any type</typeparam>
	public interface ISafeConvert<in T1, T2>
	{
		/// <summary>
		/// Converts between two specified data types together
		/// </summary>
		/// <param name="data">input data</param>
		/// <param name="defaultValue">default value of destination data type</param>
		/// <returns>Returns destination data type</returns>
		T2 Convert(T1 data, T2 defaultValue);
	}
}
