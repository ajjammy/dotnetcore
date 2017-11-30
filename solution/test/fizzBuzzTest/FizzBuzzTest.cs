using System;
using Xunit;

namespace dotnet_core_2x
{
    public class FizzBuzzTest{
 
        [Fact]
        public void Number_1_DisplayText_1()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.Equal(fizzBuzz.GetTextDisplay(1), "1");
        }
    }
}