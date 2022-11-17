//Задача 25: Напишите цикл, 
//который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
//  Например
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите число A: ");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В (натуральное): ");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb <= 0)
{
    Console.WriteLine("Число В не является натуральным ");
}
else
{
    int Exponentiation(int a, int b)
    {
        int a1 = a;
        for (int i = 2; i <= b; i++)
        {
            a1 = a1 * a;
        }
        return a1;
    }
    int expAb = Exponentiation(numa, numb);
    Console.WriteLine($"{numa} в степени {numb} = {expAb}");
}