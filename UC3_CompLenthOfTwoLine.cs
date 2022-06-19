// compare two lines based on the end points,
// So that I know one line is equal, greater or less than the other line.

int x1 = 4, x2 = 2;

int y1 = 4, y2 = 5;

double result;
result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
Console.WriteLine(result);
int a1 = 5, a2 = 6;
int b1 = 7, b2 = 8;
double result2;
result2 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
Console.WriteLine(result2);

if (result == result2)
{
	Console.WriteLine("both lines are equal");
}
else if (result > result2)
{
	Console.WriteLine("Line one is greater than Line two");
}
else
{
	Console.WriteLine("Line two is greater");
}
