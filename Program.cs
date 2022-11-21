//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)




double [] GetLine (int numberInOrder, int angularCoefficientIndex, int displacementIndex)
{
    double[] result = new double [2];
/// Getting angular coefficient
    Console.Clear();
    Console.WriteLine($"For Line #{numberInOrder} enter ");
    Console.Write("angular coefficient:  ");
    result [0] = double.Parse(Console.ReadLine()!);

/// Getting displaceent    
    Console.WriteLine("");
    Console.Write("and displacement:  ");
    result [1] = double.Parse(Console.ReadLine()!);

///returning line data    
    return result;  
}


bool AreParallel (double angularCoefficientOne, double angularCoefficientTwo)
{
    return (angularCoefficientOne == angularCoefficientTwo);
}

double [] GetIntersectionPoint ( double [] lineOne, double [] lineTwo)
{
    double [] Point = new double [2];
    int angularCoefficientIndex = 0;
    int displacementIndex = 1;
    // Kramer formula
    
    double a, b, c, d;
    a = lineOne [0];
    b = lineTwo [0];
    c = lineOne [1];
    d = lineTwo [1];

//    Console.WriteLine($"a = {a}. b = {b}, c = {c}, d = {d}");

    Point[angularCoefficientIndex] = 
                                    (d - c)
                                    /
                                    (a - b);
    Point[displacementIndex] = 
                            (a * d - b * c)
                            /                    
                            (a - b);

//    Console.WriteLine($"!Point is on: {Point[0]}, {Point[1]}");
    return Point;
}


double [] lineOne, lineTwo, intersectionPoint = new double[2];
int angularCoefficientIndex = 0;
int displacementIndex = 1;

lineOne = GetLine(1, angularCoefficientIndex, displacementIndex);
lineTwo = GetLine(2, angularCoefficientIndex, displacementIndex);

if (!AreParallel (lineOne[angularCoefficientIndex], lineTwo[angularCoefficientIndex])) 
{
    intersectionPoint = GetIntersectionPoint (lineOne, lineTwo);
    Console.WriteLine($"Point of intersection is on: {intersectionPoint[0]:f2}, {intersectionPoint[1]:f2}");
} else
{
    Console.WriteLine($"Lines are parallel, they haven't any intersection");
}


//int [] inputNumbers;
//Console.WriteLine($"There were {positiveNumbersCount (getNumbers())} numbers large than zero entered.");
