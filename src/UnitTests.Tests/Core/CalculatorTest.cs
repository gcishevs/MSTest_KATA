using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Core;

namespace UnitTests.Tests.Core
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Test_Add_With_Empty_String()
        {
            //arange
            int expected = 0;



            //act
            Calculator calc = new Calculator();
            var actual = calc.Add("");

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_Add_With_One_Parameter()
        {
            
            //arange
            int parameter = 10;
            var expected = parameter;

            //act
             Calculator calc = new Calculator();
            int actual = calc.Add("10");

            //asert
            
            Assert.AreEqual(expected, actual);
          
        }

        [TestMethod]
        public void Test_Add_With_Two_Parameters()
        {
            //arrange
            int firstSummand = 23;
            int secondSummand = 32;
            int expected = 55;

            //act
            Calculator calc = new Calculator();
            var actual = calc.Add("23,32");

            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Test_Add_With_Incorrect_Delimeter()
        {
            //arrange
            var expected = 0;

            //act
            Calculator calc = new Calculator();
            var actual = calc.Add("23:45");

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
