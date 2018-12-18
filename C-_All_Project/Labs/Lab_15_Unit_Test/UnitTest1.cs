using System;
using Lab_15_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab_15_Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //1 – Constructor. You must test the three cases: creating a fraction with two ints, with one int and with no argument
            //arrange
            //declare and suitably initialise two int: expectedTop and expectedBottom
            int expectedTop = 0;
            int expectedBottom = 1;
       
            //act
            //create a fraction using the above two arguments
            Fraction fraction = new Fraction(expectedTop, expectedBottom);
            int actualTop = fraction.Top;
            int actualBottom = fraction.Bottom;

            //Fraction fraction1 = new Fraction();
            //Fraction fraction2 = new Fraction(actualTop);
            //Fraction fraction3 = new Fraction(actualTop, actualBottom);

            //int actualTop1 = fraction.Top;
            //int actualBottom1 = fraction.Bottom;

            //int actualTop2 = fraction2.Top;
            //int actualBottom2 = fraction2.Bottom;

            //int actualTop3 = fraction3.Top;
            //int actualBottom3 = fraction3.Bottom;

            //assert
            Assert.IsNotNull(fraction, $"Fraction object was not created");
            //compare the expectedTop with the Top property of the above object
            Assert.AreEqual(expectedTop, actualTop, $"Expected {expectedTop} but got {actualTop} instead");
            //compare the expectedBottom with the Bottom property of the above fraction
            Assert.AreEqual(expectedBottom, expectedBottom, $"Expected {expectedBottom} but got {expectedBottom} instead");


            //Assert.AreEqual(expectedBottom, actualBottom1, $"Expected {expectedBottom}, got {actualBottom1} instead");
            //Assert.AreEqual(expectedBottom, actualBottom2, $"Expected {expectedBottom}, got {actualBottom2} instead");
            //Assert.AreEqual(expectedBottom, actualBottom3, $"Expected {expectedBottom}, got {actualBottom3} instead");

        }
        [TestMethod]
        public void ToString()
        {
            //2 – ToString.
            //arrange
            //declare and initialise two ints
            int expectedTop = 0;
            int expectedBottom = 1;
            //declare the variable expectedString that will depend on your ToString() method.
            string expectedString = $"{expectedTop} | {expectedBottom}";
            //act
            //declare and create an object using the above two ints
            Fraction fraction01 = new Fraction(expectedTop, expectedBottom);
            string actualString = fraction01.ToString();
            //assert
            //compare the expectedString variable to the actual output of the ToString() method
            Assert.AreEqual(expectedString, actualString, $"Are not equal");

        }
        [TestMethod]
        public void AddTwoFractions()
        {
            int leftTop = 3; int leftBottom = 5;
            int rightTop = 1; int rightBottom = 2;

            Fraction expectedAddition = new Fraction(11, 10);
            string expectedResult = $"{expectedAddition.Top} | {expectedAddition.Bottom}";

            Fraction leftFraction = new Fraction(leftTop, leftBottom);
            Fraction rightFraction = new Fraction(rightTop, rightBottom);
            Fraction sumFraction = leftFraction + rightFraction;
            string actualResult = sumFraction.ToString();

            //assert - check if thing was succesfull
            Assert.AreEqual(expectedResult, actualResult, $"Expected output: {expectedResult}, actual result: {actualResult}");
        }
        [TestMethod]
        public void SubtractTwoFractions()
        {
            int leftTop = 3; int leftBottom = 5;
            int rightTop = 1; int rightBottom = 2;

            Fraction expectedSubtraction = new Fraction(1, 10);
            string expectedResult = $"{expectedSubtraction.Top} | {expectedSubtraction.Bottom}";

            Fraction leftFraction = new Fraction(leftTop, leftBottom);
            Fraction rightFraction = new Fraction(rightTop, rightBottom);
            Fraction subtractionFraction = leftFraction - rightFraction;
            string actualResult = subtractionFraction.ToString();

            //assert - check if thing was succesfull
            Assert.AreEqual(expectedResult, actualResult, $"Expected output: {expectedResult}, actual result: {actualResult}");
        }
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void SubtractTwoFractionsExpection()
        {
            int leftTop = 1; int leftBottom = 2;
            int rightTop = 3; int rightBottom = 5;

            Fraction expectedResult = new Fraction(1, 10);

            Fraction leftFraction = new Fraction(leftTop, leftBottom);
            Fraction rightFraction = new Fraction(rightTop, rightBottom);


            Fraction actualResult = leftFraction - rightFraction;

            //assert - check if thing was succesfull
            Assert.AreEqual(expectedResult.ToString(), actualResult.ToString(), $"Expected output: {expectedResult}, actual result: {actualResult}");
        }
    }
}
