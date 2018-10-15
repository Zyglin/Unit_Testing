namespace Lab3
{
    public class Triangle
    {
        public bool TriangleCheck(double firstSideLength, double secondSideLength, double thirdSideLength)
        {
            if ((firstSideLength + secondSideLength > thirdSideLength) && (secondSideLength + thirdSideLength > firstSideLength) && (firstSideLength + thirdSideLength > secondSideLength)) return true;
            else return false;
        }
    }
}
