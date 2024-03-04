// Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.


void Main()
{
    int firstNumber = InputInt("Введите начало последовательности: ");
    int lastNumber = InputInt("Введите окончание последовательности: ");
    PrintNumbers(firstNumber, lastNumber);

}

void PrintNumbers(int number, int lastNumber)
{
    if(number > lastNumber)
        return;
    
    System.Console.Write(number + "\t");
    PrintNumbers(number + 1, lastNumber);
}

int InputInt(string inputMessage)
{
    System.Console.Write(inputMessage);
    return Convert.ToInt32(System.Console.ReadLine());
}

Main();