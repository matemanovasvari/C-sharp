using System.Globalization;

Console.Write("What is your favourite movie? ");
int favMovie = int.Parse(Console.ReadLine());

Console.Write("When did your fabourite movie premier? ");
int premierDate = int.Parse(Console.ReadLine());

Console.WriteLine($"{{megjelenési év}}-ban {{rendező neve}} rendezésében\r\nmegjelent a/az {{film címe}} című film {{főszereplő neve}} főszereplésével!\r\n");

Console.ReadKey();