Console.Write("What is your favourite movie? ");
int favMovie = int.Parse(Console.ReadLine());

Console.Write("When did your fabourite movie premier? ");
int premierDate = int.Parse(Console.ReadLine());

Console.Write("Who directed it? ");
string directorName = Console.ReadLine();

Console.Write("Who is the main character? ");
string mainActor = Console.ReadLine();


Console.WriteLine($"{premierDate}-ban {directorName} rendezésében\r\nmegjelent a/az {favMovie} című film {mainActor} főszereplésével!\r\n");

Console.ReadKey();