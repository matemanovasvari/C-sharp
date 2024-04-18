using _01_Constructor;

//parameter nelkuli konstruktor hasznalata peldanyositaskor
Fruit apple = new Fruit();
apple.Name = "apple";
apple.Calories = 60;
apple.Price = 450;
apple.Importers.Add("ABCS");
//apple.Importers = new List<string>(); private set miatt nem működne
//apple.HasImporter = true; //Property or indexer 'property' cannot be assigned to -- it is read only

Fruit orange = new Fruit
{
    Name = "orange",
    Calories = 90,
    Price = 380
};

//peldanyositas parameteres konstruktorral
Fruit banana = new Fruit("banana", 89, 600);

Fruit vmi = new Fruit(apple);