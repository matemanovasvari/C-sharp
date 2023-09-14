Console.Write("Please type in a number: ");
double firstNumber = double.Parse(Console.ReadLine());

Console.Write("Please type in a second number: ");
double secondNumber = double.Parse(Console.ReadLine());

Console.Write("Please type in a third number: ");
double thirdNumber = double.Parse(Console.ReadLine());

double result = ((double)((firstNumber + 0.5) * (secondNumber - 0.7)))%thirdNumber;

Console.WriteLine($"Az eredmény: {result}");

Console.ReadKey();