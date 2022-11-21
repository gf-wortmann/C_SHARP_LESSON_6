//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Line L = new Line (5.0, 11.5);
Line M = L.GetLine();

Console.WriteLine($"M.Angular: {M.A()}, M.Displacement: {M.D()} ");


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

    public double A ()
    {
        return angularCoefficient;
    }

    public double D ()
    {
        return displacement;
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
    public void SetLine (Line newLine, int lineNumber)
    {
        Store[lineNumber - 1] = newLine.GetLine();
    }

    public bool AreParallel (int indexOne, int indexTwo)
    {
        return this.Store[indexOne].A() == this.Store[indexTwo].A();
    }

}


