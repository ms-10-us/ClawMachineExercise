using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClawMachineExercise
{
    internal class ClawMachine
    {
        private static Reward rewardOne = new Reward("Cheap candy", (decimal)0.50);
        private static Reward rewardTwo = new Reward("Cheap candy", (decimal)0.50);
        private static Reward rewardThree = new Reward("Cheap candy", (decimal)0.50);
        private static Reward rewardFour = new Reward("Candy bar", (decimal)1.00);
        private static Reward rewardFive = new Reward("Candy bar", (decimal)1.00);
        private static Reward rewardSix = new Reward("Stuffed Animal", (decimal)10.00);
        private List<Reward> AllRewards = new List<Reward>() { rewardOne, rewardTwo, rewardThree, rewardFour, rewardFive , rewardSix};
        private decimal CostToPlay = (decimal) 1.50;

        public Reward GetReward()
        {
            Random randomObject = new Random();
            return AllRewards.ElementAt(randomObject.Next(0, AllRewards.Count));
        }

        public bool MadeProfit(Reward randomReward)
        {
            if (randomReward.Value > CostToPlay)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Play()
        {
            Reward reward = GetReward();
            Console.WriteLine($"The rewards is {reward.Name}");
            if (MadeProfit(reward))
            {
                Console.WriteLine("You made a profit!");
            }
            else
            {
                Console.WriteLine("You lost money!");
            }
        }

    }
}
