/* Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами. */

/* int Question(string text) */
/* {
	Console.Write($"{text} - ");
	string res = Console.ReadLine();
	if (res == "") return 0;
	else
	{
		int num = Convert.ToInt32(res);
		return num;
	}
} */

/* int[,] DoubleArr(int row, int col)
{
	int[,] arr = new int[row, col];

	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i, j] = new Random().Next(0, 10);
			/* arr[i, j] = arr.GetLength(0) * j + i + 1; */
/* arr[i, j] = arr.GetLength(0) * i + j + 1; */
/* }
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
PrintArr(arrRes); */

/* 
	Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1; 1) и т.д.Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1 + 9 + 2 = 12 */

/* double Summ(int[,] arr)
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
Summ(arrRes); */

// Task 1
public class Answer
{
	public static double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
	{
		Console.Write($"m = {m},\tn = {n},\tminLimitRandom  = {minLimitRandom},\tmaxLimitRandom = {maxLimitRandom}");
		Console.WriteLine();
		Console.WriteLine();
		double[,] arr = new double[m, n];
		for (int i = 0; i < arr.GetLength(0); i++)
		{
			for (int j = 0; j < arr.GetLength(1); j++)
			{
				arr[i, j] = new Random().Next(minLimitRandom, maxLimitRandom + 1) + new Random().NextDouble();
			}
		}
		return arr;
	}

	public static void PrintArray(double[,] matrix)
	{
		// Введите свое решение ниже
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				Console.Write($"{matrix[i, j]:f2}\t");
			}
			Console.WriteLine();
		}
	}

	// Не удаляйте и не меняйте метод Main! 
	public static void Main(string[] args)
	{
		int m, n, minLimitRandom, maxLimitRandom;

		if (args.Length >= 4)
		{
			m = int.Parse(args[0]);
			n = int.Parse(args[1]);
			minLimitRandom = int.Parse(args[2]);
			maxLimitRandom = int.Parse(args[3]);

			double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

			// Выберем случайные индексы трех элементов матрицы array
			int row1 = new Random().Next(0, m);
			int col1 = new Random().Next(0, n);
			int row2 = new Random().Next(0, m);
			int col2 = new Random().Next(0, n);
			int row3 = new Random().Next(0, m);
			int col3 = new Random().Next(0, n);

			// Проверяем, являются ли выбранные элементы дробными числами
			bool isFractional1 = (array[row1, col1] % 1) != 0;
			bool isFractional2 = (array[row2, col2] % 1) != 0;
			bool isFractional3 = (array[row3, col3] % 1) != 0;

			// Если два из трех элементов не являются дробными числами, то бросаем исключение
			if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
			{
				Console.WriteLine("Все ок!");
			}
			else
			{
				throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
			}
		}
		else
		{
			m = 3;
			n = 4;
			minLimitRandom = -10;
			maxLimitRandom = 10;

			double[,] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
			PrintArray(result);
		}
	}
}
// Task 3
public class Answer
{
	public static void PrintArray(int[,] matrix)
	{
		// Введите свое решение ниже
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				Console.Write($"{matrix[i, j]}\t");
			}
			Console.WriteLine();
		}

	}

	public static int[,] CreateIncreasingMatrix(int n, int m, int k)
	{
		// Введите свое решение ниже
		int[,] arr = new int[n, m];
		int number = 1;
		for (int i = 0; i < arr.GetLength(0); i++)
		{
			for (int j = 0; j < arr.GetLength(1); j++)
			{
				arr[i, j] = number;
				number += k;
			}
		}
		return arr;

	}

	static void PrintListAvr(double[] list)
	{
		// Введите свое решение ниже
		Console.WriteLine("The averages in columns are:");
		for (int i = 0; i < list.Length; i++)
		{
			Console.Write($"{list[i]:f2}\t");
		}


	}

	static double[] FindAverageInColumns(int[,] matrix)
	{
		// Введите свое решение ниже
		double[] arr = new double[matrix.GetLength(1)];
		for (int i = 0; i < matrix.GetLength(1); i++)
		{
			for (int j = 0; j < matrix.GetLength(0); j++)
			{
				arr[i] += matrix[j, i];
			}
			arr[i] /= matrix.GetLength(0);
		}

		return arr;
	}


	// Не удаляйте и не меняйте метод Main! 
	static public void Main(string[] args)
	{
		int n, m, k;

		if (args.Length >= 3)
		{
			n = int.Parse(args[0]);
			m = int.Parse(args[1]);
			k = int.Parse(args[2]);
		}
		else
		{
			// Здесь вы можете поменять значения для отправки кода на Выполнение
			n = 3;
			m = 4;
			k = 2;
		}

		// Не удаляйте строки ниже
		int[,] result = CreateIncreasingMatrix(n, m, k);
		PrintArray(result);
		PrintListAvr(FindAverageInColumns(result));
	}
}