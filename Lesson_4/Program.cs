
/* TASK - SEMINAR
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 

Решение */

int Input(string content)
{
	Console.WriteLine($"{content}");
	int number = Convert.ToInt32(Console.ReadLine());
	return number;
}

void Length(int input)
{
	int count = 0;
	while (input > 0)
	{
		input /= 10;
		count++;
	}
	Console.WriteLine($"Количество разрядов равно - {count}");
	Console.WriteLine();
}
Length(Input("Введите число - для подсчета разрядов"));

/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120

Решение */

void Composition(int input)
{
	int comp = 1;
	for (int i = 1; i <= input; i++)
	{
		comp *= i;
	};

	Console.Write($"Произведение его чисел -> {comp}");
	Console.WriteLine();
}

Composition(Input("Укажите число"));

/* ______________________________________ */

/* Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] 
 
*/

void ArrBi(int input)
{
	int[] arr = new int[input];
	for (int i = 0; i < input; i++)
	{
		arr[i] = new Random().Next(0, 2);
		Console.Write($"{arr[i]} ");
	};
	Console.WriteLine();
}

ArrBi(Input("Укажите длину массива"));

/* HOME WORK
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

void InDegree(int num, int degree)
{
	double res = Math.Pow(num, degree);
	Console.WriteLine($"Число {num} в степени {degree} = {res}");
	Console.WriteLine();
}
InDegree(Input("Введите число"), Input("Его степень"));

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

void Summ(int input)
{
	int comp = 0;
	for (int i = 1; i <= input; i++)
	{
		comp += i;
	};

	Console.Write($"Сумма его чисел -> {comp}");
	Console.WriteLine();
}

Summ(Input("Укажите число"));


/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

void ArrRandom(int input)
{
	int[] arr = new int[input];

	Console.Write("Массив из 8 символов [ ");
	for (int i = 0; i < input; i++)
	{
		arr[i] = new Random().Next(0, 100);
		Console.Write($"{arr[i]} ");
	};
	Console.Write("]");
}

ArrRandom(8);