int Input(string content)
{
	Console.WriteLine($"{content}");
	int number = Convert.ToInt32(Console.ReadLine());
	return number;
}

/* int[] CreateArr(int number_1, int number_2, int length)
{

	if (number_2 > number_1)
	{
		int[] arr = new int[length];
		for (int i = 0; i < length; i++)
		{
			arr[i] = new Random().Next(number_1, number_2);
			Console.Write($"{arr[i]} ");
		}
		Console.WriteLine("");
		return arr;
	}
	else
	{
		Console.WriteLine($"Второе число {number_2} меньше первого {number_1} ");
		int[] arr = new int[0];
		return arr;
	}
}

void PrintArray(int[] array)
{
	Console.Write("[")

	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}\t");
	}
	Console.Write("\b\b\b\b\b] -> ")
	Console.WriteLine();
}

int[] resRand = CreateArr(Input("Введите первое число"), Input("Введите второе число - больше первого"), Input("Введите длину массива")); */

/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int[] Bit (int number)
{
	int[] arrBit = new int[];
	for ()
}
void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}");
	}
	Console.WriteLine();
}
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. */