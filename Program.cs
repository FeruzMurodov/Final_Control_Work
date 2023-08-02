/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

Console.WriteLine("Введите слова или цифры через пробел: ");
string[] arrayString = MakeArrayFromString(Console.ReadLine()!);
// PrintArray(arrayString);
string[] result = GetStringsLessThan3El(arrayString);
PrintArray(result);

// Методы:
string[] MakeArrayFromString(string stringOfArray)
{
    string[] words = stringOfArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string[] result = new string[words.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = words[i];
    }
    return result;
}

void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
}

