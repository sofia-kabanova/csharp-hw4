//Задача 27: Напишите программу, которая 
// принимает на вход число 
// и выдаёт сумму цифр в числе.
// Например:
// 452 -> 11
// 82 -> 10
// 012 -> 12
Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = default;
if (number < 0) number1 = -number;
else number1 = number;
int SumNumbers(int num)
{
    int sum = default;
    for (int i = 0; num > 0; i++)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
int sumNumbers = SumNumbers(number1);
Console.WriteLine($"Сумма цифр в числе {number} = {sumNumbers}");
