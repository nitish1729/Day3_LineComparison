int x1 = 4;
int x2 = 2;
int y1 = 4;
int y2 = 5;
double result;
result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
Console.WriteLine(result);
int a1 = 4, a2 = 2;
int b1 = 4, b2 = 5;
double result2;
result2 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
Console.WriteLine(result2);

if (result == result2)
{
	Console.WriteLine("both lines are equal");
}
else
{
	Console.WriteLine("Both lines are not equals");
}