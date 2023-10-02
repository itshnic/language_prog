int Input(string content)
{
	Console.WriteLine($"{content}");
	int number = Convert.ToInt32(Console.ReadLine());
	return number;
}
/* void Print(int res, string text = null)
{
	Console.WriteLine($"{text} {res}");
} */
/* Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2]-> [4, 8, -8, -2]
 */
int[] Rand(int number_1, int number_2, int length)
{
	int[] arr = new int[length];
	for (int i = 0; i < length; i++)
	{
		arr[i] = new Random().Next(number_1, number_2);
		/* Print(arr[i], "/b"); */
		Console.Write($"{arr[i]} ");
	}
	return arr;
}

void signOff(int[] arr)
{
	Console.WriteLine("Меняем знак - ");
	int[] arrSignOff = new int[arr.Length];
	for (int i = 0; i < arr.Length; i++)
	{
		arrSignOff[i] = arr[i] * (-1);

		Console.Write($"{arrSignOff[i]} ");
	}
}

int[] resRand = Rand(Input("Введите первое число"), Input("Введите второе число"), Input("Введите длину массива"));

signOff(resRand);

/* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив[6, 7, 19, 345, 3]->нет
- 3; массив[6, 7, 19, 345, 3]->да */



/* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10, 99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2]-> 1
[1, 2, 3, 6, 2]-> 0
[10, 11, 12, 13, 14]-> 5 */



/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5]-> 5 8 3
[6 7 3 6]-> 36 21 */