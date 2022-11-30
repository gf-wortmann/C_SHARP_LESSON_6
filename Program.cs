//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Line L1 = new Line (5.0, 2.0);
Line L2 = new Line (9.0, 4.0);
Line L3 = new Line (9.0, 2.0);

//Console.WriteLine($"M.Angular: {M.GetAngularCoefficient ()}, M.Displacement: {M.GetDisplacement ()} ");
//Console.WriteLine($"L.Angular: {L.GetAngularCoefficient ()}, L.Displacement: {L.GetDisplacement ()} ");

Geometry Space = new Geometry(L1, L2);
Point intersectionPoint = new Point();

Console.WriteLine($"Seeking the point of intersection of L1 and L2 lines...");
if (!Space.AreParallel())
{
    intersectionPoint = Space.DefineIntersectionPoint();
    intersectionPoint.PrintPoint();
}
else Console.WriteLine($"The lines are parallel, no intersection point here.");

Space.SetLine(L2, 1);
Space.SetLine(L3, 2);
Console.WriteLine($"Seeking the point of intersection of L2 and L3 lines...");
if (!Space.AreParallel())
{
    intersectionPoint = Space.DefineIntersectionPoint();
    intersectionPoint.PrintPoint();
}
else Console.WriteLine($"The lines are parallel, no intersection point here.");


class Line
{
    private double angularCoefficient, displacement;
    
    public Line()
    {
        angularCoefficient  = 0;
        displacement        = 0;
    }

    public Line (double angularCoefficient, double displacement)
    {
        this.angularCoefficient = angularCoefficient;
        this.displacement       = displacement;
    }

    public void SetLine (double angularCoefficient, double displacement)
    {
        this.angularCoefficient = angularCoefficient;
        this.displacement       = displacement;
    }

    public Line GetLine ()
    {
        return this;
    }

    public double GetAngularCoefficient ()
    {
        return angularCoefficient;
    }

    public double GetDisplacement ()
    {
        return displacement;
    }
}

class Point
{
    private double X;
    private double Y;
    bool initialized = false;

    public Point()
    {
        this.X = 0;
        this.Y = 0;
    }

    public Point ( double xCoord, double yCoord)
    {
        this.X = xCoord;
        this.Y = yCoord;
        initialized = true;
    }

    public void SetPoint (double xCoord, double yCoord)
    {
        this.X = xCoord;
        this.Y = yCoord;
        initialized = true;
    }

public void SetXCcoord (double xCoord)
    {
        this.X = xCoord;
        initialized = true;
    }
public void SetYCoord (double yCoord)
    {
        this.Y = yCoord;
        initialized = true;
    }



    public Point GetPoint ()
    {
        if (initialized) return this;
        else return null; //let's see this
    }
    
    public void PrintPoint()
    {
        if (initialized) Console.WriteLine($"Intersection point is X: {this.X}, Y: {this.Y}");
    }
}



class Geometry
{
    private Line [] Store = new Line [2];
    public Geometry ()
    {
        Store [0] = new Line();
        Store [1] = new Line();
    }

    public Geometry (Line L1, Line L2)
    {
        Store [0] = L1;
        Store [1] = L2;
    }
    public void SetLine (Line newLine, int lineNumber)
    {
        Store[lineNumber - 1] = newLine.GetLine();
    }

    public bool AreParallel ()
    {
        return this.Store[0].GetAngularCoefficient() == this.Store[1].GetAngularCoefficient();
    }

    public Point DefineIntersectionPoint ()
    {
        Point intersectionPoint = new Point();
// Kramer formula
    
        double a, b, c, d;

        a = Store [0].GetAngularCoefficient();
        b = Store [1].GetAngularCoefficient();

        c = Store [0].GetDisplacement();
        d = Store [1].GetDisplacement();

        intersectionPoint.SetXCcoord( 
                                 (d - c)
                                 /
                                 (a - b)
                                );

        intersectionPoint.SetYCoord (
                                (a * d - b * c)
                                /                    
                                (a - b)
                                );
        return intersectionPoint;
    }
}


