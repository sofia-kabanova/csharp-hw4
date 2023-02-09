// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов
// и выводит их на экран.
//  Например:
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
Console.Clear();
Console.WriteLine("Введите  длинну массива:");
//  если запрашиваем длинну массива у пользователя
int length = Convert.ToInt32(Console.ReadLine());
// int length = 8; // вводим длинну массива = 8 элементов
if (length <= 0)
{
    Console.WriteLine(value: "Вы ввели неверное значение, перезапустите программу.");
    return;
}
int[] arr = new int[length];
void FillArray(int[] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(min, max); // можно не запрашивать мин и мах
        // arr[i] = rnd.Next(100) - массив заполнится числами от 0 до 100
        // или arr[i] = rnd.Next(10,100) числами от 10 до 100. 
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
Console.WriteLine("Введите диапазон чисел массива:");
Console.Write("Min: ");
int minNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Max: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());
if (maxNumber < minNumber) Console.WriteLine($"Ошибка!");
else
{
    Console.WriteLine($"Массив из {length} чисел: ");
    FillArray(arr, minNumber, maxNumber);
    Console.Write("[ ");
    PrintArray(arr);
    Console.Write("]");
}


