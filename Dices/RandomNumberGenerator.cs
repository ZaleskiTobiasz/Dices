using System;

namespace Dices
{
    public class RandomNumberGenerator
    {
        public int dice1 { get; set; }
        public int dice2 { get; set; }
        private int counter { get; set; }

        private Random random = new Random();

        public void GenerateAndDisplayNumbers()
        {
            while (true)
            {
                dice1 = GenerateNumber();
                dice2 = GenerateNumber();
                counter++;
                if ((dice1 == 6) && (dice2 == 6))
                {
                    DisplayDicesNumbers(dice1, dice2, counter);
                    break;
                }
                else
                {
                    DisplayDicesNumbers(dice1, dice2, counter);
                    continue;
                }
            }
        }
        private void DisplayDicesNumbers(int dice1, int dice2,int counter)
        {
            Console.WriteLine($"{counter}: {dice1} {dice2}");
        }
        private int GenerateNumber()
        {
            return random.Next(1, 7);
        }
    }
}
