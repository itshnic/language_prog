// 1. Сравнение 2-х чисел
Console.WriteLine("СРАВНЕНИЕ 2-x ЧИСЕЛ!");
Console.WriteLine("Введите первое число:");
int num2_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2_2 = Convert.ToInt32(Console.ReadLine());

if (num2_1 > num2_2)
{
	Console.Write("Число - ");
	Console.Write(num2_1);
	Console.Write(" > ");
	Console.WriteLine(num2_2);
}
else if (num2_1 < num2_2)
{
	Console.Write("Число - ");
	Console.Write(num2_2);
	Console.Write(" > ");
	Console.WriteLine(num2_1);
}
else
{
	Console.WriteLine($"Число {num2_1} равно числу {num2_2}");
}
// 3. Сравнение 3-х чисел

Console.WriteLine("СРАВНЕНИЕ 3-х ЧИСЕЛ!");
Console.WriteLine("Введите первое число:");
int num3_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num3_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int num3_3 = Convert.ToInt32(Console.ReadLine());

int max = num3_1;

if (num3_2 > max) max = num3_2;

if (num3_3 > max) max = num3_3;

Console.WriteLine($"Самое большое число {max}");

// 4. Четность
Console.WriteLine("ПРОВЕРКА ЧЕТНОСТИ!");
Console.WriteLine("Введите число:");
int num4_1 = Convert.ToInt32(Console.ReadLine());
if ((num4_1 % 2) == 0)
	Console.WriteLine($"Число {num4_1} четное!");
else Console.WriteLine($"Число {num4_1} НЕчетное!");

// 5. Четные числа

Console.WriteLine("РЯД ЧЕТНЫХ ЧИСЕЛ");
Console.WriteLine("Введите число:");
int num5_1 = Convert.ToInt32(Console.ReadLine());
int number = 2;
Console.Write("Ряд четных чисел -> ");
while (number < num5_1)
{
	Console.Write($"{number}, ");
	number += 2;
}
Console.Write($" -> Остаток {number - num5_1}");