/* Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами. */

int Question(string text)
{
	Console.Write($"{text} - ");
	string res = Console.ReadLine();
	if (res == "") return 0;
	else
	{
		int num = Convert.ToInt32(res);
		return num;
	}
}

int[,] DoubleArr(int row, int col)
{
	int[,] arr = new int[row, col];

	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i, j] = new Random().Next(0, 10);
			/* arr[i, j] = arr.GetLength(0) * j + i + 1; */
			/* arr[i, j] = arr.GetLength(0) * i + j + 1; */
		}
	}
	return arr;
}
void PrintArr(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write($"{arr[i, j]}\t");
		}
		Console.WriteLine();
	}
}
int[,] arrRes = DoubleArr(Question("Введите размер m: "), Question("Введите размер n: "));
PrintArr(arrRes);


/* 
	Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1; 1) и т.д.Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1 + 9 + 2 = 12 */

double Summ(int[,] arr)
{
	double summNum = 0;
	Console.Write("Сумма элементов главной диагонали: ");

	for (int i = 0; i < arr.GetLength(0); i++)
	{
		if (i != 0) Console.Write(" + ");
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			if (i == j)
			{
				summNum += arr[i, j];
				Console.Write($"{arr[i, j]}");
			}
		}

	}
	Console.Write($" = {summNum}");
	return summNum;
}
Summ(arrRes);