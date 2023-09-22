// ЗАДАЧА 10
Console.WriteLine("Введите трехзначное число!");

string number = Console.ReadLine();

if (number.Length == 3)
	Console.WriteLine($"{number} -> {number[1]}");
else
	Console.WriteLine($"Введено не трехзначное число -> {number}");

// ЗАДАЧА 13
Console.WriteLine("Введите число из трех и более цифр!");

string number_2 = Console.ReadLine();

if (number_2.Length >= 3)
	Console.WriteLine($"{number_2} -> {number_2[2]}");
else
	Console.WriteLine($"В числе менее 3-х цифр -> {number_2}");

// ЗАДАЧА 15
Console.WriteLine("Введите день недели!");
int day = Convert.ToInt32(Console.ReadLine());
int[] weekend = { 6, 7 };
if (day <= 7)
{
	int index = 0;
	while (weekend.Length > index)
	{
		if (weekend[index] == day)
		{
			Console.WriteLine($"Ура выходной! -> {day}");
			break;
		}
		index++;
	}
}
else if (day <= 5) Console.WriteLine($"Работаем братья( -> {day}");
else Console.WriteLine($"Введено не корректное число -> {day}");
