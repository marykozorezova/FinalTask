PrintData("Введите массив через пробел:");
string str = ReadData();
string[] array = Solution(str.Split(' '));
PrintData("Mассив, длина которого меньше либо равнa 3 символа:");
PrintArray(array);

// Метод читает данные от пользователя
string ReadData()
{
    return Console.ReadLine() ?? "0";
}


// Метод выводит данные на печать
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод печатает начальный массив
void PrintArray(string[] arr)

   
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.Write(arr[arr.Length - 1]);
    }
   
// Метод добавляет строку в массив
string[] AddToArray(string[] arr, string item)
{
    if (arr.Length == 0)
    {
        return new string[] { item };
    }
    string[] arrResult = new string[arr.Length + 1];
    arr.CopyTo(arrResult, 0);
    arrResult[arr.Length] = item;
    return arrResult;
}

// Метод из имеющегося массива формирует массив, длина которого меньше либо равнa 3 символа
string[] Solution(string[] arr)
{
    string[] arrNew = new string[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (string.IsNullOrEmpty(arr[i]))
            continue;
        if (arr[i].Length - 1 < 3) arrNew = AddToArray(arrNew, arr[i]);

    }
    return arrNew;
}
