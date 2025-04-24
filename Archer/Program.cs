namespace Archer;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            StartSimulation();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }

    private static void StartSimulation()
    {
        Archer robin = new Archer("Robin", 10);

        while (true)
        {
            Console.WriteLine("\n--- Archer Menu ---");
            robin.DisplayStatus();
            Console.WriteLine("1 - Shoot");
            Console.WriteLine("2 - Add arrows");
            Console.WriteLine("3 - Quit");
            Console.WriteLine("Please enter a number (1-3)");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    robin.Shoot();
                    break;

                case "2":
                    robin.AddArrows(LoadPositiveIntegerFromConsole("Enter the number of arrows:"));
                    break;

                case "3":
                    return;

                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }
    }

    public static int LoadPositiveIntegerFromConsole(string alert)
    {
        while (true)
        {
            Console.WriteLine(alert);
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                if (result >= 0)
                {
                    return result;
                }
            }
            else
            {
                continue;
            }

        }
    }
}
