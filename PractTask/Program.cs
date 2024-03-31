using PractTask;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Fruit> fruits = new List<Fruit>();
        Fruit fruit = new Fruit();
        Console.WriteLine("Enter 1 to add Fruit");
        Console.WriteLine("Enter 2 to add Citrus");
        Console.WriteLine("Enter 0 to exit");
        int chooseMenu = int.Parse(Console.ReadLine());
        do
        {
            switch (chooseMenu)
            {
                case 1:
                    Fruit fruit1 = new Fruit();
                    fruits.Add(fruit1.Input());
                    break;
                case 2:
                    Citrus citrus1 = new Citrus();
                    fruits.Add(citrus1.Input());
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.WriteLine("Enter 1 to add Fruit");
            Console.WriteLine("Enter 2 to add Citrus");
            Console.WriteLine("Enter 0 to exit");
            chooseMenu = int.Parse(Console.ReadLine());
        } while(chooseMenu != 0);

        fruit.Print(fruits);
        fruit.Initialize(fruits);

        Console.WriteLine("Sorted");

        var sortedFruits = fruits.OrderBy(f => f.Name).ToList();

        fruit.Print(sortedFruits);

        Console.WriteLine("Found yellow");
        var yellowFruits = fruits.Where(f => f.Color == "yellow").ToList();
        fruit.Print(yellowFruits);
    }
}