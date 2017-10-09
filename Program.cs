using System;

namespace die
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while(isRunning) {
                Cup cup = new Cup();

                Console.WriteLine("Hom many Dice Do You Want to roll?");
                int numberOfRolls = Convert.ToInt32(Console.ReadLine());
                for(int i = 0; i < numberOfRolls; i++) {
                     Console.WriteLine("How many sides?");
                     int sides = Convert.ToInt32(Console.ReadLine());
                     cup.Dice.Add(new Dice(sides));
                }

                cup.TotalRollValue();
                
                Console.WriteLine("Do you want to roll again? Y or N?");
                string choice = Console.ReadLine();

                if(choice != "Y") {
                    isRunning = false;
                }
               
            }
            
            

        }
    }
}
