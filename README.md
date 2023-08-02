# Final_Control_Work

1. В моём программе первоначальный массив введётса с клавиатуры
   Console.WriteLine("Введите слова или цифры через пробел: ");
2. Чтобы сформировать строчный массив создал новый метод и там использовал метод Split
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
3. Потом для проверки каждой строки этого массива создал метод. В этом методе используя функцию string.Leng проверил каждый элемент чтобы выбират меншие чем 3 символа или равны 3 символам.
Из выбранных элементов создал новый массив.
string[] GetStringsLessThan3El(string[] inArrayString)
{
    string[] result = new string[inArrayString.Length];
    for (int i = 0; i < result.Length; i++)
    {
        string temp = inArrayString[i];
        if (temp.Length <= 3)
        {
            result[i] = temp;
        }
    }
    return result;
}
4. Выводил новый массив.
   void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
}
