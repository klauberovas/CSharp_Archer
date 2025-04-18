using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Archer
{
    public class Archer
    {
        public string Name { get; private set; }
        public int ArrowCount { get; private set; }
        public Archer(string name, int arrowCount)
        {
            Name = name;
            if (arrowCount > 0)
            {
                ArrowCount = arrowCount;
            }
            else
            {
                throw new Exception("Please, insert number higher than zero.");
            }
        }
        public void Shoot()
        {
            if (ArrowCount > 0)
            {
                ArrowCount -= 1;
                Console.WriteLine($"Úspěšný výstřel. Zbývá ti {ArrowCount} šípů.");
            }
            else
            {
                Console.WriteLine("Už nemáš šípy.");
            }
        }
        public void AddArrows(int number)
        {
            if (number > 0)
            {
                ArrowCount += number;
                Console.WriteLine($"Úspěšně přidáno {number} šípů.");
            }
            else
            {
                Console.WriteLine("Počet šípů k přidání musí být kladný.");
            }
        }
        public void DisplayStatus()
        {
            Console.WriteLine($"Jméno lučištníka: {Name}, počet šípů: {ArrowCount}.");
        }
    }
}