// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
void Main()
{
    string[] inputArray = ReadArray("Введите элементы массива через запятую: ");
    PrintArray(inputArray);
}

void PrintArray(string[] inputArray)
{
    PrintItem(inputArray, 0);
    System.Console.WriteLine();
}

void PrintItem(string[] inputArray, int index)
{
    if(index >= inputArray.Length)
        return;

    PrintItem(inputArray, index + 1);
    System.Console.Write(inputArray[index] + "\t");
}

string[] ReadArray(string message)
{
    System.Console.Write(message);
    string inputMsg = System.Console.ReadLine();
    return inputMsg.Split(',');
}

Main();
