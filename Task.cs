// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.WriteLine("Введите количество строк");
int numberM = int.Parse(Console.ReadLine()!);

string[] firstArray = CollectNumbers(numberM);

PrintArray(firstArray);

string[] newArray = LessThan3CharArray(firstArray);

PrintArray(newArray);

string[] CollectNumbers(int size)
{
    string[] array = new string[size];
    Console.WriteLine($"Начинайте ввод {size} строк(и)");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine()!;
    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] LessThan3CharArray(string[] array)
{
    int countMoreThan3 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int size = array[i].Length;
        if (size <= 3)
        {
            countMoreThan3++;
        }
    }
    if (countMoreThan3 == 0)
    {
        Console.WriteLine("Нет подходящих строк");
    }

    string[] newArray = new string[countMoreThan3];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int size = array[i].Length;
        if (size <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}