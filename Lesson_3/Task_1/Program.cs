
bool IsPalindrome(int number)
{
	// Вариант 1

	// if (Convert.ToString(number).Length == 5)
	// {

	// 	int[] divider = { 1, 10, 100, 1000, 10000 };
	// 	int[] numbers = new int[5];
	// 	for (int i = 0; divider.Length > i; i++)
	// 	{
	// 		numbers[i] = number / divider[i] % 10;
	// 	}
	// 	if (numbers[0] == numbers[4] && numbers[1] == numbers[3])
	// 	{
	// 		return true;
	// 	}
	// 	else
	// 	{
	// 		return false;
	// 	}
	// }
	// else
	// {
	// 	Console.WriteLine("Число не пятизначное");
	// 	return false;
	// }
	// Вариант 2
	int remainder = 10;
	int number_1 = number % remainder;
	int number_2 = number / 10 % remainder;
	int number_3 = number / 100 % remainder;
	int number_4 = number / 1000 % remainder;
	int number_5 = number / 10000 % remainder;
	if (number > 9999 && number < 100000)
	{
		if (number_1 == number_5 && number_2 == number_4)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	else
	{
		Console.WriteLine("Число не пятизначное");
		return false;
	}

}

int number = 57875;

bool result = IsPalindrome(number);
Console.WriteLine($"{result}");

