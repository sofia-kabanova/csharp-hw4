// Напишите программу, которая 
// принимает на вход число - пользовательский ввод
// выдает количество цифр в числе
// Например:
// 456->3
// 78->2
// 89126->5
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 0) Console.Write($"Количество цифр в числе {number} -> 1");
else
{
    int Count(int num)
    {
        int i = default;
        for (i = 0; num > 0; i++)
        {
            num /= 10;
        }
        return i;
    }
    if (number < 0)
    {
        int number1 = -number;
        int result = Count(number1);
        Console.Write($"Количество цифр в числе {number} -> {result}");
    }
    else
    {
        int result = Count(number);
        Console.Write($"Количество цифр в числе {number} -> {result}");
    }
}