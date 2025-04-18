using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

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
            Console.WriteLine("--- Menu Lučistníka ---");
            robin.DisplayStatus();
            Console.WriteLine("1 - Vystřelit šíp");
            Console.WriteLine("2 - Přidat šípy");
            Console.WriteLine("3 - Konec");
            Console.WriteLine("Zadejte svou volbu (1-3)");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    robin.Shoot();
                    break;

                case "2":
                    robin.AddArrows(LoadIntegerFromConsole("Zadej počet šípů:"));
                    break;

                case "3":
                    return;

                default:
                    Console.WriteLine("Neplatný vstup. Zkus to prosím znovu.");
                    continue;
            }
        }
    }

    public static int LoadIntegerFromConsole(string alert)
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
