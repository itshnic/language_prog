// ЗАДАЧА 10
int Input(string content)
{
	Console.WriteLine($"{content}");
	int number = Convert.ToInt32(Console.ReadLine());
	return number;
}

void SearchTwo(int num)
{
	string numString = Convert.ToString(num);
	if (numString.Length == 3)
		Console.WriteLine($"Вторая цифра {num} -> {numString[1]}");
	else
		Console.WriteLine($"Введено не трехзначное число -> {num}");
}
SearchTwo(Input("Введите трехзначное число"));

// ЗАДАЧА 13

void SearchThree(int num)
{
	string numString = Convert.ToString(num);
	if (numString.Length == 2)
		Console.WriteLine($"Третьей цифры нет -> {num}");
	else if (numString.Length >= 3)
		Console.WriteLine($"Третья цифра {num} -> {numString[2]}");
	else if (num < 1)
		Console.WriteLine($"Введено не корректное число -> {num}");
}

SearchThree(Input("Введите число из трех и более цифр!"));

// ЗАДАЧА 15

void nameDay(int num)
{
	string[] weekday = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
	if (num <= 7 && num > 0)
	{
		int index = 0;
		{
			if (num > 5)
			{
				while (weekday.Length > index)
				{
					if (num == (index + 1))
					{
						Console.WriteLine($"{num} день это -> {weekday[index]} <<ВЫХОДНОЙ>>");
						break;
					}
					index++;
				}
			}
			else
			{
				while (weekday.Length > index)
				{
					if (num == (index + 1))
					{
						Console.WriteLine($"{num} день это -> {weekday[index]} <<Пора на работу!>>))");
						break;
					}
					index++;
				}
			}
		}
	}
	else Console.WriteLine($"Введено не корректное число -> {num}");
}
nameDay(Input("Введите день недели!"));

