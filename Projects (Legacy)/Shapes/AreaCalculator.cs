namespace Shapes
{
    public class AreaCalculator
    {
        public static float Area(float length, float width, float width2)
        {
            return length * (width + width2)/2;
        }

        public static float Area(float length, float width)
        {
            return Area(length, width, width);
        }

        public static float Area(float sideLength)
        {
            return Area(sideLength, sideLength);
        }
    }
}
