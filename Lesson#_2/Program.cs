// // ЗАДАЧА 10
// int Input(string content)
// {
// 	Console.WriteLine($"{content}");
// 	int number = Convert.ToInt32(Console.ReadLine());
// 	return number;
// }
// void Error(int number, string text)
// {
// 	Console.WriteLine($"{text} -> {number}");
// }
// void SearchTwo(int num)
// {
// 	string numString = Convert.ToString(num);
// 	if (numString.Length == 3)
// 		Console.WriteLine($"Вторая цифра {num} -> {numString[1]}");
// 	else Error(num, "Введено не трехзначное число");

// }
// SearchTwo(Input("Введите трехзначное число"));

// // ЗАДАЧА 13

// void SearchThree(int num)
// {
// 	string numString = Convert.ToString(num);
// 	if (numString.Length == 2)
// 		Console.WriteLine($"Третьей цифры нет -> {num}");
// 	else if (numString.Length >= 3)
// 		Console.WriteLine($"Третья цифра {num} -> {numString[2]}");
// 	else if (num < 2)
// 		Error(num, "Введено не корректное число");
// }

// SearchThree(Input("Введите число из трех и более цифр!"));

// // ЗАДАЧА 15
// void SearchDay(string[] arr, int number, string content)
// {
// 	int index = 0;
// 	while (arr.Length > index)
// 	{
// 		if (number == (index + 1))
// 		{
// 			Console.WriteLine($"{number} {content} -> {arr[index]}");
// 			break;
// 		}
// 		index++;
// 	}
// }

// void NameDay(int num)
// {
// 	string[] weekday = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
// 	if (num <= 7 && num > 0)
// 	{
// 		{
// 			if (num > 5)
// 			{
// 				SearchDay(weekday, num, "это выходной день");
// 			}
// 			else
// 			{
// 				SearchDay(weekday, num, "это рабочий день");
// 			}
// 		}
// 	}
// 	else Error(num, "Введено не корректное число");
// }
// NameDay(Input("Введите день недели!"));
int number = 58945;
double remainder = number % 10;
double remainder1 = number / 10 % 10;
double remainder2 = number / 100 % 10;
double remainder3 = number / 1000 % 10;
double remainder4 = number / 10000 % 10;

Console.WriteLine(remainder);
Console.WriteLine(remainder1);
Console.WriteLine(remainder2);
Console.WriteLine(remainder3);
Console.WriteLine(remainder4);