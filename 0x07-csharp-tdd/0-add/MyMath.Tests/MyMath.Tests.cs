using NUnit.Framework;

namespace MyMath.Tests
{
	[TestFixture]
	public class OperationsTests
	{
		[Test]
		public void AddTest1()
		{
			int input_a = 5;
			int input_b = 6;

			int output = Operations.Add(input_a, input_b);

			Assert.AreEqual(input_a + input_b, output);
		}
	}
}