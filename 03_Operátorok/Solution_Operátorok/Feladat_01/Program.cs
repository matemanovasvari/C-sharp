Console.Write("Please type in a number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Please type in another number: ");
int secondNumber = int.Parse(Console.ReadLine());

int sum = firstNumber + secondNumber;

Console.WriteLine($"The sum is: {sum}");

Console.ReadKey();