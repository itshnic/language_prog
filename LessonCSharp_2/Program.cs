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
string[] weekday = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

void nameDay(string[] arr, int day)
{
	if (day <= 7 && day > 0)
	{
		int index = 0;
		{
			if (day > 5)
			{
				while (arr.Length > index)
				{
					if (day == (index + 1))
					{
						Console.WriteLine($"{day} -> {arr[index]} <<ВЫХОДНОЙ>>");
						break;
					}
					index++;
				}
			}
			else
			{
				while (arr.Length > index)
				{
					if (day == (index + 1))
					{
						Console.WriteLine($"{day} -> {arr[index]} <<Пора на работу!>>))");
						break;
					}
					index++;
				}
			}
		}
	}
	else Console.WriteLine($"Введено не корректное число -> {day}");
}
nameDay(weekday, day);

