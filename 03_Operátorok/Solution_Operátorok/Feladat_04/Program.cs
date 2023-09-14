Console.Write("Please type in a number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Please type in a second number: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.Write("Please type in a third number: ");
int thirdNumber = int.Parse(Console.ReadLine());

double result = ((double)(firstNumber * secondNumber)) / thirdNumber;

Console.WriteLine($"Az eredmény: {result}");

Console.ReadKey();