

double Length(int[] pointA, int[] pointB)
{
	// Вариант 1
	// double segmentX = Math.Pow((pointA[0] - pointB[0]), 2);
	// double segmentY = Math.Pow((pointA[1] - pointB[1]), 2);
	// double segmentZ = Math.Pow((pointA[2] - pointB[2]), 2);
	// double distance = Math.Sqrt(segmentX + segmentY + segmentZ);
	// return distance;

	// Вариант 2
	double distance = 0;
	for (int i = 0; i < 3; i++)
		distance += Math.Pow((pointA[i] - pointB[i]), 2);

	return Math.Sqrt(distance);
}

int x1 = 3;
int x2 = 6;
int x3 = 8;
int y1 = 2;
int y2 = 1;
int y3 = -7;


double result = Length(new int[] { x1, x2, x3 }, new int[] { y1, y2, y3 });
Console.WriteLine($"{result:F2}");

