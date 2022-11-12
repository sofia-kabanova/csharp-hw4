// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов
// и выводит их на экран.
//  Например:
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
Console.Clear();
Console.WriteLine("Введите  длинну массива:");
int size = Convert.ToInt32(Console.ReadLine());
if (size <= 0) Console.WriteLine("Ошибка!");
else
{
    Console.WriteLine("Введите диапазон чисел массива:");
    Console.Write("Min: ");
    int minNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Max: ");
    int maxNumber = Convert.ToInt32(Console.ReadLine());
    if (maxNumber < minNumber) Console.WriteLine("Ошибка!");
    else
    {
        int[] FillArray(int length, int min, int max)
        {
            int[] array = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(min, max);
            }
            return array;
        }
        void PrintNumbers(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1) Console.Write($"{array[i]}, ");
                else Console.Write($"{array[i]} ");
            }
        }
        void PrintArray(int[] array)
        {
            Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1) Console.Write($"{array[i]}, ");
                else Console.Write($"{array[i]} ");
            }
            Console.Write("]");
        }

        // 
        Console.WriteLine($"Массив из {size} чисел: ");
        int[] arr = FillArray(size, minNumber, maxNumber);
        PrintNumbers(arr);
        Console.Write($" - > ");
        PrintArray(arr);
    }
}