List<ISuperhero> superheroes = new List<ISuperhero> 
{ 
    new Wonderwoman("Diana"),
    new Batman("Bruce Wayne"),
    new Blackwidow("Natasha Romanoff")
};

for(int i = 0; i < superheroes.Count - 1; i++)
{
    for(int j = i + 1; j < superheroes.Count; j++)
    {
        ISuperhero attacker = superheroes[i];
        ISuperhero attacked = superheroes[j];

        Console.WriteLine($"{attacker.Name} attacks {attacked.Name}");
        bool defeats = attacker.Fights(attacked);

        if (defeats)
        {
            Console.WriteLine($"{attacker.Name} wins");
        }
        else
        {
            Console.WriteLine($"{attacked.Name} wins");
        }

        await Task.Delay(1000);
    }
}