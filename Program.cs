using System;

class Program
{
    static void Main(string[] args)
    {
        double p1x,p1y,p2x,p2y,p3x,p3y;
        p1x = double.Parse(Console.ReadLine());
        p1y = double.Parse(Console.ReadLine());
        p2x = double.Parse(Console.ReadLine());
        p2y = double.Parse(Console.ReadLine());
        p3x = double.Parse(Console.ReadLine());
        p3y = double.Parse(Console.ReadLine());

        Vector2 v_p1 = new Vector2(p1x,p1y);
        Vector2 v_p2 = new Vector2(p2x,p2y);
        Vector2 v_p3 = new Vector2(p3x,p3y);

        Line2 l_p3p1 = new Line2(v_p3,v_p1);
        Line2 l_p2p3 = new Line2(v_p2,v_p3);

        Vector2 ma_p3p1 = v_p1.Magnitude(v_p3,v_p1);
        Vector2 ma_p2p3 = v_p2.Magnitude(v_p2,v_p3);

        Line2 l1 = Line2.Perpendicular(l_p3p1,ma_p3p1);
        Line2 l2 = Line2.Perpendicular(l_p2p3,ma_p2p3);

        Vector2 c_center = Line2.Intersection(l1,l2);

        Console.WriteLine("{0}",Math.Round(c_center.x,5));
        Console.WriteLine("{0}",Math.Round(c_center.y,5));

        double radius = Math.Sqrt(((v_p1.x-c_center.x)*(v_p1.x-c_center.x))+((v_p1.y-c_center.y)*(v_p1.y-c_center.y)));
        Console.WriteLine("{0}",Math.Round(radius,5));
    }
}