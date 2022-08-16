/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Не использовать Math.Pow() и аналоги. Решаем строго через цикл
*/
/*for (int i = 1; i <= B; i++)
{
    newA = newA*A;
}

Console.Write($"A в степени В = {newA}");
*/

Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int newA = 1;

int i = 1;

while (i <= B)
{
    newA = newA*A;
    i++;
}

Console.Write($"A в степени В = {newA}");


