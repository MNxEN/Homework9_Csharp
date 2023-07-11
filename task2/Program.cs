// Задача 2: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

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
        System.Console.Write($"Сумма натуральных чисел в промежутке от [{beginNumber}] до [{endNumber}] -> ");
        FindEvenNaturalNumber(beginNumber, endNumber);
    }
    else
    {
        System.Console.WriteLine($"Промежуток натуральных чисел задан некорректно");
    }
}

void FindEvenNaturalNumber(int beginNumber, int endNumber, int sum = 0)
{
    if (beginNumber < 1)
    {
        beginNumber = 1;
    }
    
    if (beginNumber > endNumber)
    {
        System.Console.Write(sum);
        return;
    }
    sum += beginNumber;
    FindEvenNaturalNumber(beginNumber + 1, endNumber, sum);
}

int beginNumber = PromptInt("Задайте начало числового промежутка");
int endNumber = PromptInt("Задайте конец числового промежутка");
DateValidate(beginNumber, endNumber);