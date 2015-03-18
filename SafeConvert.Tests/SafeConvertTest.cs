using System;
using System.Globalization;
using NUnit.Framework;

namespace SafeConvert.Tests
{
	[TestFixture]
    public class SafeConvertTest
    {
		[Test]
		public void ConvertToByte_MinValue_Okay()
		{
			var s = (byte.MinValue).ToString(CultureInfo.InvariantCulture);
			Assert.AreEqual(s.ToByte(), byte.MinValue);
		}

		[Test]
		public void ConvertToByte_OutOfRangeMaxValue_NonOkay()
		{
			var n = (Byte.MaxValue + 1).ToString(CultureInfo.InvariantCulture);
			Assert.AreEqual(n.ToByte(), 0);
		}

		[Test]
		public void ConvertToByte_OutOfRangeMinValue_NonOkay()
		{
			var n = (Byte.MinValue - 1).ToString(CultureInfo.InvariantCulture);
			Assert.AreEqual(n.ToByte(), 0);
		}

		[Test]
		public void ConvertToShort_MinValue_Okay()
		{
			var s = (short.MinValue).ToString();
			Assert.AreEqual(s.ToShort(), short.MinValue);
		}

		[Test]
		public void ConvertToShort_OutOfRangeMaxValue_NonOkay()
		{
			var n = (short.MaxValue + 1).ToString(CultureInfo.InvariantCulture);
			Assert.AreEqual(n.ToShort(), 0);
		}

		[Test]
		public void ConvertToShort_OutOfRangeMinValue_NonOkay()
		{
			var n = (short.MinValue - 1).ToString(CultureInfo.InvariantCulture);
			Assert.AreEqual(n.ToShort(), 0);
		}

		[Test]
		public void ConvertToInt_MinValue_Okay()
		{
			var s = (int.MinValue).ToString(CultureInfo.InvariantCulture);
			Assert.AreEqual(s.ToInt(), int.MinValue);
		}

		[Test]
		public void ConvertToInt_OutOfRangeMaxValue_NonOkay()
		{
			var s = ((long)int.MaxValue + 1).ToString(CultureInfo.InvariantCulture);
			Assert.AreEqual(s.ToInt(), 0);
		}

		[Test]
		public void ConvertToInt_OutOfRangeMinValue_NonOkay()
		{
			var s = ((long)int.MinValue - 1).ToString(CultureInfo.InvariantCulture);
			Assert.AreEqual(s.ToInt(), 0);
		}

		[Test]
		public void ConvertToLong_MinValue_Okay()
		{
			var s = (long.MinValue).ToString(CultureInfo.InvariantCulture);
			Assert.AreEqual(s.ToLong(), long.MinValue);
		}

		[Test]
		public void ConvertToLong_MaxValue_Okay()
		{
			var s = (long.MaxValue).ToString(CultureInfo.InvariantCulture);
			Assert.AreEqual(s.ToLong(), long.MaxValue);
		}

		[Test]
		public void ConvertToFloat_SpecifiedValue_Okay()
		{
			Assert.AreEqual("6.5".ToFloat(), 6.5f);
		}

		[Test]
		public void ConvertToDecimal_SpecifiedValue_Okay()
		{
			Assert.AreEqual("6.5".ToDecimal(), 6.5M);
		}

		[Test]
		public void ConvertToDouble_SpecifiedValue_Okay()
		{
			Assert.AreEqual("6.5".ToDecimal(), 6.5);
		}

		[Test]
		public void ConvertToDateTime_SpecifiedValue_Okay()
		{
			Assert.AreEqual("2014-12-02 11:00:00".ToDateTime(), new DateTime(2014, 12, 2, 11, 0, 0));
		}

		[Test]
		public void ConvertToDateTime_NoValidFormatSpecifiedValue_NonOkay()
		{
			Assert.AreEqual("2014//12//02 11:00:00".ToDateTime(), null);
		}

		[Test]
		public void ConvertToAny_SpecifiedIntegerValue_Okay()
		{
			Assert.AreEqual("20".To<int>(), 20);
		}
    }
}
