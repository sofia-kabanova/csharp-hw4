//Задача 25: Напишите цикл, 
//который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
//  Например
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// вариант преподавателя
int Degree(int NumX, int NumY)
{
    int result = 1;
    for (int i = 1; i <= NumY; i++) result *= NumX;
    return result;
}
Console.WriteLine("Введите число A: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В (натуральное): ");
int y = Convert.ToInt32(Console.ReadLine());
int degree = Degree(x, y);
Console.WriteLine($"{x} в степени {y} = {degree}");

