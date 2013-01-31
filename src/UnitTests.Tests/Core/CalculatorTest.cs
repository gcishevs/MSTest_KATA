using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.Core;

namespace UnitTests.Tests.Core
{
    [TestClass]
    public class CalculatorTest
    {

        [TestMethod]
        public void CalculatorTest_Check_If_EmptyString_Return_Zerro()
        {
            //Arrange
            var calc = new Calculator();
            var expected = 0;
            //Act
            var actual = calc.Add("");
            //Actual
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorTest_CheckIfOneParameterReturnsTheParameterValue()
        {
            //Arrange
            var calc = new Calculator();
            var expected = 167;
            //Act
            var actual = calc.Add("167");
            //Actual
            Assert.AreEqual(expected, actual);
        }












        // Первые тесты, не подглядывать!!!!!!!!!!!!!

        //[TestMethod]
        //public void Test_Add_With_Empty_String()
        //{
        //    //arrange
        //    int expected = 0;

        //    //act
        //    Calculator calc = new Calculator();
        //    var actual = calc.Add("");

        //    //assert
        //    Assert.AreEqual(actual, expected);
        //}

        //[TestMethod]
        //public void Test_Add_With_One_Parameter()
        //{
            
        //    //arrange
        //    int parameter = 10;
        //    var expected = parameter;

        //    //act
        //    Calculator calc = new Calculator();
        //    int actual = calc.Add("10");

        //    //asert
        //    Assert.AreEqual(expected, actual);
          
        //}

        //[TestMethod]
        //public void Test_Add_With_Two_Parameters()
        //{
        //    //arrange
        //    int firstSummand = 23;
        //    int secondSummand = 32;
        //    int expected = 55;

        //    //act
        //    Calculator calc = new Calculator();
        //    var actual = calc.Add("23,32");

        //    //assert

        //    Assert.AreEqual(expected, actual);

        //}

        //[TestMethod]
        //public void Test_Add_With_Incorrect_Delimeter()
        //{
        //    //arrange
        //    var expected = 0;

        //    //act
        //    Calculator calc = new Calculator();
        //    var actual = calc.Add("23:45");

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
