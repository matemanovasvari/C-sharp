/*Konzolról kérjünk be két egész számot, majd egy matematika műveletet (+,-,*,/) és
végezzük el a megfelelő műveletet e két számmal.*/
Console.Write("Please type in a number!: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Please type in a number!: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.Write("Please type in an operator from the following:\n+\n-\n*\n/\n");
string operation = Console.ReadLine();

double? result = operation switch
{
    "+" => firstNumber + secondNumber,
    "-" => firstNumber - secondNumber,
    "*" => firstNumber * secondNumber,
    "/" => ((double)(firstNumber)) / secondNumber,
    _ => null,
};
if (result == null)
{
    Console.WriteLine("No such operator!!!");
}
else
{
Console.WriteLine($"{result}");
}

Console.ReadKey();