using Lab3;
using NUnit.Framework;

namespace UnitTests
{

    public class Tests
    {
        Triangle triangle = new Triangle();

        [Test]
        public void FirstTest()
        {
            Assert.AreEqual(true, triangle.TriangleCheck(1, 2, 3));
        }

        [Test]
        public void SecondTest()
        {
            Assert.AreEqual(true, triangle.TriangleCheck(25, 25, 25));
        }

        [Test]
        public void ThirdTest()
        {

            Assert.AreEqual(false, triangle.TriangleCheck(10, 0, 2));
        }

        [Test]
        public void FourthTest()
        {

            Assert.AreEqual(true, triangle.TriangleCheck(120, 90, 6));
        }

        [Test]
        public void FifthTest()
        {
            Assert.AreEqual(false, triangle.TriangleCheck(1277, 2147, 231));
        }

        [Test]
        public void SixthTest()
        {

            Assert.AreEqual(false, triangle.TriangleCheck(181135, 164835, 410450));
        }

        [Test]
        public void SevenshTest()
        {

            Assert.AreEqual(false, triangle.TriangleCheck(87, 5, 4));

        }

        [Test]
        public void EghtsTest()
        {

            Assert.AreEqual(false, triangle.TriangleCheck(4, 4, 6));
        }

        [Test]
        public void NinesTest()
        {
            Assert.AreEqual(true, triangle.TriangleCheck(3, 4, 5.001));

        }
        [Test]
        public void TensTest()
        {
            Assert.AreEqual(true, triangle.TriangleCheck(2, 20, 18.00001));
        }
    }
}
