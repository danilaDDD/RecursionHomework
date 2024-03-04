// Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n.

void Main()
{
    int argM = InputInt("Введите аргумент M: ");
    int argN = InputInt("Введите аргумент N: ");
    System.Console.WriteLine("Значение функции аккермана: " + Akkerman(argM, argN));
}

long Akkerman(long m, long n)
{
    
    if(m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else if(m > 0 && n > 0)
        return Akkerman(m - 1, Akkerman(m, n - 1));
    else
        return n + 1;
    
}

int InputInt(string inputMessage)
{
    System.Console.Write(inputMessage);
    return Convert.ToInt32(System.Console.ReadLine());
}

Main();