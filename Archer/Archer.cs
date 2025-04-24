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
                Console.WriteLine($"{Name} is ready with {ArrowCount} {(ArrowCount == 1 ? "arrow" : "arrows")}!");
            }
            else
            {
                throw new Exception("Please insert number higher than zero.");
            }
        }
        public void Shoot()
        {
            if (ArrowCount > 0)
            {
                ArrowCount -= 1;
                Console.WriteLine($"{Name} fired! Arrows left: {ArrowCount}.");
            }
            else
            {
                Console.WriteLine($"{Name} has no arrows.");
            }
        }
        public void AddArrows(int number)
        {
            if (number > 0)
            {
                ArrowCount += number;
                Console.WriteLine($"{Name} added {number} {(number == 1 ? "arrow" : "arrows")}. Total arrows: {ArrowCount}.");
            }
            else
            {
                Console.WriteLine("The number of arrows must be greater than zero.");
            }
        }
        public void DisplayStatus()
        {
            Console.WriteLine($"Archer: {Name} | Arrows: {ArrowCount}.");
        }
    }
}