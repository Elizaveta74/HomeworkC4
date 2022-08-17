/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов
и выводит их на экран.
Вводим массив через консоль
*/

int totalElements = 8;
// Так как в задании не определен тип для элементов массива,
// то мы выбираем string.
string[] array = new string[totalElements]; 
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент с индексом {i}: ");
    array[i] = Console.ReadLine();
}

Console.WriteLine("*** Вы ввели массив ***");

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Элемент с индексом {i} = {array[i]}");
}

Console.WriteLine("*** Этот же массив - в одну строку. ***");

string finalArrayRepresent = string.Join(" ", array);
Console.WriteLine(finalArrayRepresent);







