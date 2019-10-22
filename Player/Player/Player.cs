using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePickBall
{
    public class Player
    {

        private string Name;
        public Player(string name)
        {
            Name = name;
        }
        public void PickBall(Board game)
        {
            Console.WriteLine("which group U want to pick ?");
            int group = int.Parse(Console.ReadLine());
            Console.Write("How many balls do U want to pick?");
            int balls = int.Parse(Console.ReadLine());
            game.Pick_Ball(group, balls);
        }

        public string GetName()
        {
            return Name;
        }
    }
}
