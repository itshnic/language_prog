int Question(string text)
{
	Console.Write($"{text} - ");
	string res = Console.ReadLine();
	if (res == "") return 0;
	else
	{
		int num = Convert.ToInt32(res);
		return num;
	}

}

/* int[] Prompt(string text)
{
	int length = Question(text);

	if (length > 0)
	{
		int[] arrNum = new int[length];
		Console.WriteLine();
		arrNum[0] = Question("Введите первое число ");
		Console.WriteLine();
		for (int i = 1; i < length; i++)
		{
			arrNum[i] = Question("Введите следующее число ");
			Console.WriteLine();
		}
		return arrNum;
	}
	else
	{
		Console.WriteLine("Число должно быть целым и положительным)");
		int[] arrNum = new int[0];
		return arrNum;
	}
}

void CountNumber(int[] arr)
{
	int count = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] > 0) count++;
		if (i > 0) Console.Write(", ");
		Console.Write($"{arr[i]}");
	}
	Console.Write($"-> {count}");
	Console.WriteLine();
}
CountNumber(Prompt("Введите кол-во чисел ")); */

void DotMeeting()
{
	double b1 = Question("Введите точку b1");
	double k1 = Question("Введите точку k1");
	double b2 = Question("Введите точку b2");
	double k2 = Question("Введите точку k2");

	double x = (b1 - b2) / (k2 - k1);
	double y = k1 * x + b1;

	Console.WriteLine();
	Console.WriteLine($"b1={b1}, k1={k1}, b2={b2}, k2={k2} -> ({x},{y})");
}
DotMeeting();