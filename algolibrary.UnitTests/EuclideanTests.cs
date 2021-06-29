using algolibrary.EuclideanGCD;
using Xunit;

namespace algolibrary.UnitTests
{
	public class EuclideanTests
	{
		[Theory]
		[InlineData(78, 102, 6)] //6 * 12, 6 * 17, hence 6 is the greatest divisor
		public void GCDTestsUsingEuclideanAlgorithm(int a, int b, int expectedGCD)
		{
			Euclidean gcdTest = new Euclidean();
			var divisor = gcdTest.GCD(a, b);
			Assert.Equal(expectedGCD, divisor);
		}

		[Theory]
		[InlineData(8, 36, 72)] //8 * 9 = 72, 36 * 2 = 72
		[InlineData(10, 12, 60)] //10 * 6 = 60, 12 * 5 = 60
		public void LCMTestsUsingEuclideanAlgorithm(int a, int b, int expectedLCM)
		{
			Euclidean lcmTest = new Euclidean();
			var multiplier = lcmTest.LCM(a, b);
			Assert.Equal(expectedLCM, multiplier);
		}
	}
}
