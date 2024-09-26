internal class Program
{
    private static void Main(string[] args)
    {
        int humanYears = 5;
        if (humanYears <= 0)
        {
            throw new ArgumentException("Human years must be a positive integer.");
        }
        Console.WriteLine($"[{humanYears},{GetCatYears(humanYears)},{GetDogYears(humanYears)}]");
        Console.WriteLine($"[{humanYears},{GetAnimalYears(humanYears,AnimalType.Cat)},{GetAnimalYears(humanYears,AnimalType.Dog)}]");
    }

    public static int GetCatYears(int humanYears)
    {
        if (humanYears == 1)
        {
            return 15;
        }
        else if (humanYears == 2)
        {
            return 24;
        }
        else
        {
            return 24 + (humanYears - 2) * 4;
        }
    }
    public static int GetDogYears(int humanYears)
    {
        if (humanYears == 1)
        {
            return 15;
        }
        else if (humanYears == 2)
        {
            return 24;
        }
        else
        {
            return 24 + (humanYears - 2) * 5;
        }
    }
    public enum AnimalType
    {
        Cat,
        Dog
    }
    public static int GetAnimalYears(int humanYears, AnimalType animal)
    {
        if (humanYears == 1)
        {
            return 15;
        }
        else if (humanYears == 2)
        {
            return 24;
        }
        else
        {
            return 24 + (humanYears - 2) * (animal==AnimalType.Cat?4:5);
        }
    }
}
