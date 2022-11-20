//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double [] GetLine (int numberInOrder, int angularCoefficientIndex, int displacementIndex)
{
    double[] result = new double [2];
/// Getting anglat coefficient
    Console.Clear();
    Console.WriteLine($"For Line #{numberInOrder} enter ");
    Console.Write("angular coefficient  ");
    result [0] = double.Parse(Console.ReadLine()!);

/// Getting displaceent    
    Console.WriteLine("");
    Console.Write("displacement  ");
    result [1] = double.Parse(Console.ReadLine()!);
    return result;  
}


bool AreParallel (double angularCoefficientOne, double angularCoefficientTwo)
{
    return (angularCoefficientOne == angularCoefficientTwo);
}



double [] lineOne, lineTwo;
int angularCoefficientIndex = 0;
int displacementIndex = 1;

lineOne = GetLine(1);
lineTwo = GetLine(2);
if (!AreParallel (lineOne[angularCoefficientIndex], lineTwo[angularCoefficientIndex])) 
{

}

//int [] inputNumbers;
//Console.WriteLine($"There were {positiveNumbersCount (getNumbers())} numbers large than zero entered.");
