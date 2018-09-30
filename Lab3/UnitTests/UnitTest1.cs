using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstUnitTest()
        {
            double firstSide = 4, secondSide = 5, thirdSide = 6;
            bool expectedResult = true;
            TestedClass myTestedClass = new TestedClass();
            Assert.AreEqual(expectedResult, myTestedClass.TriangleCheck(firstSide, secondSide, thirdSide));
        }
        [TestMethod]
        public void SecondUnitTest()
        {

            double firstSide = 25, secondSide = 25, thirdSide = 25;
            bool expectedResult = true;
            TestedClass myTestedClass = new TestedClass();
            Assert.AreEqual(expectedResult, myTestedClass.TriangleCheck(firstSide, secondSide, thirdSide));
        }
        [TestMethod]
        public void ThirdUnitTest()
        {

            double firstSide = 1, secondSide = 2, thirdSide = 3;
            bool expectedResult = false;
            TestedClass myTestedClass = new TestedClass();
            Assert.AreEqual(expectedResult, myTestedClass.TriangleCheck(firstSide, secondSide, thirdSide));
        }
        [TestMethod]
        public void FourthUnitTest()
        {

            double firstSide = 120, secondSide = 90, thirdSide = 6;
            bool expectedResult = false;
            TestedClass myTestedClass = new TestedClass();
            Assert.AreEqual(expectedResult, myTestedClass.TriangleCheck(firstSide, secondSide, thirdSide));
        }
        [TestMethod]
        public void FifthUnitTest()
        {

            double firstSide = 1277, secondSide = 2147, thirdSide = 231;
            bool expectedResult = false;
            TestedClass myTestedClass = new TestedClass();
            Assert.AreEqual(expectedResult, myTestedClass.TriangleCheck(firstSide, secondSide, thirdSide));
        }
        [TestMethod]
        public void SixthUnitTest()
        {

            double firstSide = 181135, secondSide = 164835, thirdSide = 410450;
            bool expectedResult = false;
            TestedClass myTestedClass = new TestedClass();
            Assert.AreEqual(expectedResult, myTestedClass.TriangleCheck(firstSide, secondSide, thirdSide));
        }
        [TestMethod]
        public void SevenshUnitTest()
        {

            double firstSide = 87, secondSide = 5, thirdSide = 4;
            bool expectedResult = false;
            TestedClass myTestedClass = new TestedClass();
            Assert.AreEqual(expectedResult, myTestedClass.TriangleCheck(firstSide, secondSide, thirdSide));
        }
        [TestMethod]
        public void EghtsUnitTest()
        {

            double firstSide = 4, secondSide = 4, thirdSide = 6;
            bool expectedResult = true;
            TestedClass myTestedClass = new TestedClass();
            Assert.AreEqual(expectedResult, myTestedClass.TriangleCheck(firstSide, secondSide, thirdSide));
        }
        [TestMethod]
        public void NinesUnitTest()
        {
            double firstSide = 3, secondSide = 4, thirdSide = 5.001;
            bool expectedResult = true;
            TestedClass myTestedClass = new TestedClass();
            Assert.AreEqual(expectedResult, myTestedClass.TriangleCheck(firstSide, secondSide, thirdSide));
        }
        [TestMethod]
        public void TensUnitTest()
        {
            double firstSide = 2, secondSide = 20, thirdSide = 18.00001;
            bool expectedResult = true;
            TestedClass myTestedClass = new TestedClass();
            Assert.AreEqual(expectedResult, myTestedClass.TriangleCheck(firstSide, secondSide, thirdSide));
        }

    }
}
