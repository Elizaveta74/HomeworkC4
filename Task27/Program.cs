/*
Задача 27: Напишите программу, которая принимает на вход
число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число: ");
string initialNumber = Console.ReadLine();

int totalSum = 0;
int operationSucceeded = 1; //Если все нормально в цикле, то будет 1, если нет - 0.

for (int i = 0; i < initialNumber.Length; i++)
{
    // Нам нужна строковая переменная для конверсии,
    // поэтому конвертируем значение с типом char, в string, 
    // получается строка из одного элемента, которую мы передает в TryParse. 
    string oneDigit = $"{initialNumber[i]}"; 
    
    if (int.TryParse(oneDigit, out int oneDigitAsNumber))
    {
        totalSum = totalSum + oneDigitAsNumber;
    } 
    else
    {
        Console.WriteLine($"В введенном вами числе встречен нечисловой символ: {oneDigit}");
        operationSucceeded = 0;
        break;
    }
}

if (operationSucceeded == 1)
{
    Console.WriteLine($"Сумма = {totalSum}");
}
else
{
    Console.WriteLine("Во время подсчета суммы произошла ошибка, связанная с вводом нечислового символа");
}


