/* int Input(string content)
{
	Console.WriteLine($"{content}");
	int number = Convert.ToInt32(Console.ReadLine());
	return number;
} */

/* Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2]-> [4, 8, -8, -2]
 */
/* int[] Rand(int number_1, int number_2, int length)
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
} */

/* void signOff(int[] arr)
{
	if (arr.Length > 0)
	{
		Console.WriteLine("Меняем знак - ");
		int[] arrSignOff = new int[arr.Length];
		for (int i = 0; i < arr.Length; i++)
		{
			arrSignOff[i] = arr[i] * (-1);
			Console.Write($"{arrSignOff[i]} ");
		}
	}

} */

/* int[] resRand = Rand(Input("Введите первое число"), Input("Введите второе число - больше первого"), Input("Введите длину массива")); */

/* signOff(resRand); */

/* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив[6, 7, 19, 345, 3]->нет
- 3; массив[6, 7, 19, 345, 3]->да */

/* void Search(int[] arr)
{
	if (arr.Length > 0)
	{
		int number = Input("Введите искомое число");
		for (int i = 0; i < arr.Length; i++)
		{
			if (number == Math.Abs(arr[i]))
				Console.Write($"{arr[i]} key -> {i}; ");
		}
	}
}

Search(resRand); */

/* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10, 99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2]-> 1
[1, 2, 3, 6, 2]-> 0
[10, 11, 12, 13, 14]-> 5 */

/* void Quantity(int[] arr, int[] segment)
{
	if (arr.Length > 0)
	{
		int count = 0;
		int lastChild = segment.Length - 1;
		for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i] >= segment[0] && arr[i] <= segment[lastChild])
			{
				count++;
			}
		}
		Console.WriteLine($"{count} -> elements");
	}
}
int[] segment = { 11, 83 };
Quantity(resRand, segment); */

/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5]-> 5 8 3
[6 7 3 6]-> 36 21 */

/* void Work(int[] arr)
{
	int length = arr.Length;
	if (length > 0)
	{
		for (int i = 0; i < length; i++)
		{
			if (i < length / 2)
			{
				int pow = arr[i] * arr[(length - 1) - i];
				Console.Write($"{pow} ");
			}
			else if (length % 2 == 1)
			{
				Console.Write($"{arr[i]} ");
				break;
			}
		}
	}
}
Work(resRand); */



/* Task - 1
int CountEvenElements(int[] array)
{
	// Введите свое решение ниже
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 == 0)
			count++;
	}
	return count;
}


void PrintArray(int[] array)
{
	// Введите свое решение ниже
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine("");
}

int[] array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };


Console.WriteLine("Массив:");

int evenCount = CountEvenElements(array);
PrintArray(array);
Console.WriteLine($"Количество четных элементов: {evenCount}");
 */

//Task-2

int SumOddElements(int[] array)
{
	// Введите свое решение ниже
	int summ = 0;

	for (int key = 0; key < array.Length; key++)
	{
		/* if (key % 2 == 1) */
		summ += key % 2 == 1 ? array[key] : 0;
	}
	return summ;
}
void PrintArray(int[] array)
{
	// Введите свое решение ниже

	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine("");
}

int[] array = new int[] { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };



// Не удаляйте строки ниже
PrintArray(array);
int sumOdd = SumOddElements(array);
Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");


