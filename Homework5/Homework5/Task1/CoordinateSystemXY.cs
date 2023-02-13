namespace Task1;

public class CoordinateSystemXY
{
    private List<Point> dots = new List<Point>();

    public void AddPoint(Point point)
    {
        if (!dots.Contains(point))
        {
            dots.Add(point);
        }
    }

    public static double LengthPoints(Point point1, Point point2)
    {
        var length1 = point1.X - point2.X;
        var length2 = point1.Y - point2.Y;

        return Math.Sqrt(Math.Pow(length1, 2) + Math.Pow(length2, 2));
    }

    public int DotsCount()
    {
        return dots.Count;
    }
}