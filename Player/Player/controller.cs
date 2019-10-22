using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePickBall
{
    class Controller
    {
        private Board Game;
        private Player P1, P2;

        public Controller()
        {
            P1 = new Player("Hung");
            P2 = new Player("Nhan");
            Game = new Board(3, 4, 6);
        }

        public void PlayGame()
        {
            Game.PrintGame();
            while (true)
            {
                Console.WriteLine(P1.GetName()+ "a turn");
                P1.PickBall(Game);
                Game.PrintGame();
                if (Game.Game_Over())
                {
                    Console.WriteLine(P1.GetName() + "lose");
                    Console.WriteLine(P2.GetName() + "Wins");
                    break;
                }
                Console.WriteLine(P2.GetName() + " a turn");
                P2.PickBall(Game);
                Game.PrintGame();
                if (Game.Game_Over())
                {
                    Console.WriteLine(P2.GetName()+"lose");
                    Console.WriteLine(P1.GetName() + "wins");
                    break;
                }
            }
        }

    }
}
