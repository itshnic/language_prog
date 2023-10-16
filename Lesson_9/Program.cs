/* Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5-> "1, 2, 3, 4, 5"
M = 4; N = 8-> "4, 6, 7, 8" */
int Input(string text)
{
	Console.Write($"{text} ");
	return Convert.ToInt32(Console.ReadLine());
}
void Number(int m, int n)
{
	if (m != n)
	{
		Console.Write($"{m}, ");
		Number(m + 1, n);
	}
	else Console.Write($"{n}");
}
int m = Input("От ->");
int n = Input("-> До");
Console.Write($"{n} -> ");
/* Number(m, n);

Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */
/* int SumNum(int N)
{
	if (N == 0) return N;
	return N % 10 + SumNum(N / 10);
}

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
N = SumNum(N);
System.Console.WriteLine(N); */

/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5-> 243(3⁵)
A = 2; B = 3-> 8 */
