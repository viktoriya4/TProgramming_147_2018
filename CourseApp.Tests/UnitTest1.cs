using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var res = Program.summ(2,7);
            Assert.Equal(9,res);

        }

        [Fact]
        public void Test2()
        {
            var res = Program.summ(-2,7);
            Assert.Equal(5,res);

        }

        [Fact]
        public void TestMySimple()
        {
            var res = Program.myCalc(0,0, 0);
            Assert.Equal(0,res);

        }
    }
}
