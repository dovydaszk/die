using System;

namespace die
{
    class Dice
    {
        public int Sides { get; set; }

        public Dice(int sides) {
            Sides = sides;
        }
        public int Roll() {
            Random roll = new Random();
            int result = roll.Next(1, Sides + 1);
            return result;
        }
    }
}