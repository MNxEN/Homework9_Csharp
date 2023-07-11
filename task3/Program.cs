// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int PromptInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine();
    int value;
    if (int.TryParse(inputedStr, out value) && value >= 0)
    {
        return value;
    }
    System.Console.WriteLine($"Извините, но '{inputedStr}' не является целым положительным числом");
    return PromptInt("Ведите целое положительно число");
}

int FuncAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return FuncAkkerman(m - 1, 1);
    }
    else
    {
        return FuncAkkerman(m - 1, FuncAkkerman(m, n - 1));
    }
    return 0;
}

int mParam = PromptInt("Введите первый параметр функции Аккермана [m]");
int nParam = PromptInt("Введите второй параметр функции Аккермана [n]");
int result = FuncAkkerman(mParam, nParam);
System.Console.WriteLine($"A({mParam}, {nParam}) = {result}");