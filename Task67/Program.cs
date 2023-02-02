// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
Console.WriteLine(SumDigit(number));
}
else Console.WriteLine(SumDigit(number * - 1));

int SumDigit (int num)
{
	if (num == 0 ) return num;
	else return num % 10 + SumDigit (num / 10);
}





















