/* 
void PrintMatrix(int[,] matrix)
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
void SortRowsDescending(int[,] matrix)
{
	// Введите свое решение ниже
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			for (int k = matrix.GetLength(1) - 1; k > j; k--)
			{
				if (matrix[i, k] > matrix[i, j])
				{
					int minItem = matrix[i, j];
					matrix[i, j] = matrix[i, k];
					matrix[i, k] = minItem;
				}
			}
		}
	}

}


// Не удаляйте и не меняйте метод Main! 
void Main(string[] args)
{
	int[,] matrix;
	if (args.Length == 0)
	{
		// Если аргументы не переданы, используем матрицу по умолчанию
		matrix = new int[,] {
								{5, 2, 9},
								{8, 1, 4},
								{6, 7, 3}
						};
	}
	else
	{
		// Иначе, парсим аргументы в двумерный массив
		string[] rows = args[0].Split(';');
		matrix = new int[rows.Length, rows[0].Split(',').Length];
		for (int i = 0; i < rows.Length; i++)
		{
			string[] elements = rows[i].Split(',');
			if (elements.Length != matrix.GetLength(1))
			{
				Console.WriteLine($"Ошибка: Неправильное количество элементов в строке {i + 1}.");
				return;
			}
			for (int j = 0; j < elements.Length; j++)
			{
				if (int.TryParse(elements[j], out int number))
				{
					matrix[i, j] = number;
				}
				else
				{
					Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
					return;
				}
			}
		}
	}

	Console.WriteLine("Исходная матрица:");
	PrintMatrix(matrix);

	SortRowsDescending(matrix);

	Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
	PrintMatrix(matrix);
} */

/* using System;

public class Answer
{
	public static void PrintMatrix(int[,] matrix)
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


	public static void SortRowsDescending(int[,] matrix)
	{
		// Введите свое решение ниже
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				for (int k = matrix.GetLength(1) - 1; k > j; k--)
				{
					if (matrix[i, k] > matrix[i, j])
					{
						int minItem = matrix[i, j];
						matrix[i, j] = matrix[i, k];
						matrix[i, k] = minItem;
					}
				}
			}
		}


	}


	// Не удаляйте и не меняйте метод Main! 
	public static void Main(string[] args)
	{
		int[,] matrix;
		if (args.Length == 0)
		{
			// Если аргументы не переданы, используем матрицу по умолчанию
			matrix = new int[,] {
								{5, 2, 9},
								{8, 1, 4},
								{6, 7, 3}
						};
		}
		else
		{
			// Иначе, парсим аргументы в двумерный массив
			string[] rows = args[0].Split(';');
			matrix = new int[rows.Length, rows[0].Split(',').Length];
			for (int i = 0; i < rows.Length; i++)
			{
				string[] elements = rows[i].Split(',');
				if (elements.Length != matrix.GetLength(1))
				{
					Console.WriteLine($"Ошибка: Неправильное количество элементов в строке {i + 1}.");
					return;
				}
				for (int j = 0; j < elements.Length; j++)
				{
					if (int.TryParse(elements[j], out int number))
					{
						matrix[i, j] = number;
					}
					else
					{
						Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
						return;
					}
				}
			}
		}

		Console.WriteLine("Исходная матрица:");
		PrintMatrix(matrix);

		SortRowsDescending(matrix);

		Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
		PrintMatrix(matrix);
	}
} */
/* string[] array = { "9,1,7;1,2,3;4,5,6" };
Main(array); */

/* task 3 */
public class Answer
{
	public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
	{ // Введите свое решение ниже
		if (matrixA.GetLength(1) != matrixB.GetLength(0))
		{
			Console.WriteLine("It is impossible to multiply.");
		}

		else
		{
			MatrixMultiplication(matrixA, matrixB);
		}

	}

	public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
	{  // Введите свое решение ниже
		int[,] resultArr = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
		for (int i = 0; i < matrixA.GetLength(0); i++)
		{
			for (int j = 0; j < matrixA.GetLength(1); j++)
			{
				for (int k = 0; k < matrixA.GetLength(1); k++)
				{
					resultArr[i, j] += matrixA[i, k] * matrixB[k, j];
				}
				Console.Write($"{resultArr[i, j]}\t");
			}
			Console.WriteLine();
		}
		return resultArr;
	}

	public static void PrintMatrix(int[,] matrix)
	{  // Введите свое решение ниже
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				Console.Write($"{matrix[i, j]}\t");
			}
			Console.WriteLine();
		}
	}
	// Не удаляйте и не меняйте метод Main! 
	public static void Main(string[] args)
	{
		int[,] matrix;

		if (args.Length == 0)
		{
			// Если аргументы не переданы, используем матрицу по умолчанию
			matrix = new int[,]
			{
								{1, 2,3},
								{3, 4,5}
			};
		}
		else
		{
			// Иначе, парсим аргументы в двумерный массив
			string[] rows = args[0].Split(';');
			matrix = new int[rows.Length, rows[0].Split(',').Length];
			for (int i = 0; i < rows.Length; i++)
			{
				string[] elements = rows[i].Split(',');
				for (int j = 0; j < elements.Length; j++)
				{
					if (int.TryParse(elements[j], out int number))
					{
						matrix[i, j] = number;
					}
					else
					{
						Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
						return;
					}
				}
			}
		}

		Console.WriteLine("Исходная матрица:");
		PrintMatrix(matrix);

		int[,] matrixB = {
						{5, 6},
						{7, 8}
				};

		Console.WriteLine("\nMatrix B:");
		PrintMatrix(matrixB);

		Console.WriteLine("\nMultiplication result:");

		MultiplyIfPossible(matrix, matrixB);
	}
}