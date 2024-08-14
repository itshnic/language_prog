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

Number(m, n);
Console.WriteLine();
/* 
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */

int SumNum(int number)
{
	if (number == 0) return number;
	return number % 10 + SumNum(number / 10);
}

int number = Input("Введите число: ");
System.Console.WriteLine(SumNum(number));

/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5-> 243(3⁵)
A = 2; B = 3-> 8 */

int A = Input("Введите число : ");
int B = Input("В какую степень его возвести: ");
int Pow(int A, int B)
{
	return A = (B > 1) ? A *= Pow(A, B - 1) :
	(B == 1) ? A :
	(B == 0) ? 1 : 0;

}
Console.WriteLine(Pow(A, B));

/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
int Numbers(int start, int end)
{
	Console.Write($"{start}, ");
	return start = start > end + 1 ? Numbers(start - 1, end) : end;
}

int start = Input("Напишите значение N");
int end = 1;
Console.Write($"N={start} -> ");
Console.Write(Numbers(start, end));
Console.WriteLine();

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15-> 120
M = 4; N = 8. -> 30 */

int M = Input("Задайте число M = ");
int N = Input("Задайте число N = ");

int SummMN(int m, int n)
{
	return m <= n ? SummMN(m + 1, n) + m : 0;
}

Console.WriteLine($"-> {SummMN(M, N)}");


/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3->A(m, n) = 9
m = 3, n = 2->A(m, n) = 29 */


int oneNumber = Input("Введите первое число  -> ");
int twoNumber = Input("Введите второе число  -> ");

int Akkerman(int oneNumber, int twoNumber)
{
	if (oneNumber == 0)
		return twoNumber + 1;
	else
	if ((oneNumber != 0) && (twoNumber == 0))
		return Akkerman(oneNumber - 1, 1);
	else
		return Akkerman(oneNumber - 1, Akkerman(oneNumber, twoNumber - 1));
}
Console.WriteLine(Akkerman(oneNumber, twoNumber));
