//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа
int MaxLength = 3;
string inputLine = ReadData("Введите массив через запятую: ");
string[] arr = SplitArray(inputLine);
PrintData("Исходный массив:");
PrintArray(arr);
string[] shortArray = ShortArray(arr);
PrintData("Новый массив:");
PrintArray(shortArray);

//Метод, считывающий данные, введенные пользователем
string ReadData(string message)
{
    Console.WriteLine(message);
    string line = Console.ReadLine() ?? "0";
    return line;
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

//Метод создания массива из входной строки
string[] SplitArray(string line)
{
    string[] arr = line.Split(",", StringSplitOptions.RemoveEmptyEntries);

    return arr;
}

//Метод собирающий новый массив из строк, длина которых <=3
string[] ShortArray(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= MaxLength)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);
    return result;
}

//Метод печати массива
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}


