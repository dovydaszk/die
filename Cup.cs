using System;
using System.Collections.Generic;

namespace die
{
    class Cup
    {
        private List<Dice> dice = new List<Dice>();
        public List<Dice> Dice { 
            get
            {
                return dice;
            }
            set
            {
                dice = value;
            }
        }
        
        public void TotalRollValue() {
            int total = 0;
            for(int i = 0; i < dice.Count; i++) {
                int roll = dice[i].Roll();
                System.Console.WriteLine($"Roll {i + 1}: {roll}");
                total += roll;
            }

            PrintResult(total);
        }

        private void PrintResult(int total) {
            Console.WriteLine("Result: ");
            Console.WriteLine(total);
        }
    }
}