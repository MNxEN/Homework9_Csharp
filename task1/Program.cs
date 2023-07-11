// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int PromptInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine();
    int value;
    if (int.TryParse(inputedStr, out value))
    {
        return value;
    }
    System.Console.WriteLine($"Извините, но '{inputedStr}' не является целым числом");
    Environment.Exit(0);
    return 0;
}

void DateValidate(int beginNumber, int endNumber)
{
    if (beginNumber < endNumber && endNumber > 1)
    {
        System.Console.WriteLine($"Чётные натуральные числа в промежутке от [{beginNumber}] до [{endNumber}]: ");
        FindEvenNaturalNumber(beginNumber, endNumber);
    }
    else
    {
        System.Console.WriteLine($"Промежуток для чётных натуральных чисел задан некорректно");
    }
}

void FindEvenNaturalNumber(int beginNumber, int endNumber)
{
    if (beginNumber < 1)
    {
        beginNumber = 2;
    }
    if (beginNumber > endNumber)
    {
        return;
    }
    if (beginNumber % 2 != 0)
    {
        beginNumber++;
    }
    System.Console.Write($" {beginNumber} ");
    FindEvenNaturalNumber(beginNumber + 2, endNumber);
}

int beginNumber = PromptInt("Задайте начало числового промежутка");
int endNumber = PromptInt("Задайте конец числового промежутка");
DateValidate(beginNumber, endNumber);
