string[] NewArray(string[] arr)
{
    int length = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) length += 1;
    }
    string[] newArr = new string[length];
    for (int i = 0, j = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}

Console.Write("Сколько строк Вы собираетсать ввести? ");
int num = Convert.ToInt32(Console.ReadLine());
string[] array = new string[num];
for (int i = 0; i < num; i++)
{
    Console.Write($"Введите строку номер {i + 1}: ");
    array[i] = Console.ReadLine();
}

Console.WriteLine("Исходный массив: [" + string.Join(", ", array) + "]");
string[] newArray = NewArray(array);
Console.WriteLine("Новый массив: [" + string.Join(", ", newArray) + "]");
