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
		}
	}
	return arr;
}
void PrintArr(int[,] arry)
{
	for (int i = 0; i < arry.GetLength(0); i++)
	{
		for (int j = 0; j < arry.GetLength(1); j++)
		{
			Console.Write($"{arry[i, j]}\t");
		}
		Console.WriteLine();
	}
}
int[,] arrRes = DoubleArr(Question("Введите размер m: "), Question("Введите размер n: "));
PrintArr(arrRes);

/* Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
	arr[i, j] = arr.GetLength(1) * i + j;
}
}

void PrintArr(int[,] arry)
{
for (int i = 0; i < arry.GetLength(0); i++)
{
	for (int j = 0; j < arry.GetLength(1); j++)
	{
		Console.Write($"{arry[i, j]}\t");
	}
	Console.WriteLine();
}

}

PrintArr(arr); */

/* 
	Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1; 1) и т.д.Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1 + 9 + 2 = 12 */

