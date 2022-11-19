//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int positiveNumbersCount( int[] input )
{
    int result = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if ( input[i] > 0 ) result++;
    }
    return result;
}

int [] getNumbers ()
{
    int [] result = {0};
    int inputNumber = 0;
    int i = 0;

    do{
        Console.Write($"Input a number (empty is the end of input): ");
        string input = Console.ReadLine()!;
        if (input != "") inputNumber = int.Parse(input); else break;
        Array.Resize (ref result, i + 1);
        result [i] = inputNumber;
        i++;
    } while (true);
    return result;
}

int [] inputNumbers;
Console.WriteLine($"There were {positiveNumbersCount (getNumbers())} numbers large than zero entered.");
