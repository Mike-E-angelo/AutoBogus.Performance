using AutoBogus.Performance.Model;
using Xunit;

namespace AutoBogus.Performance
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			new AutoFaker<Parent>().Generate();
		}
	}
}
