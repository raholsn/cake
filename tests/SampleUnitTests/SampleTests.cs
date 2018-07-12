using System;
using Xunit;

namespace SampleUnitTests
{
    public class SampleTests
    {
        [Fact]
        public void Sample_Test_Passing()
        {
            Assert.True(1 == 1);
        }
    }
}
