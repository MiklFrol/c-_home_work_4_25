// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int getUserNumber(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int getADegreeB(int numA, int numB)
{
    int number = 1;
    for( int i = 0; i < numB; i++)
    {
        number = number * numA;
    } 
    return number;
}

int numA = getUserNumber("Введите первое число:");
int numB = getUserNumber("Введите второе число:");
int ADegreeB = getADegreeB(numA, numB);
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine($"{numA} в степени {numB} = {ADegreeB}");
Console.ResetColor();