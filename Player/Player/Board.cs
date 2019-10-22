using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePickBall
{
    class Board
    {
        private int G1 ,G2 ,G3;
        public Board(int g1,int g2,int g3)
        {
            G1 = g1;
            G2 = g2;
            G3 = g3;

        }
        public void PrintGame()
        {
            Console.Write("Group 1 :");
            for(int i=1; i<= G1; i++)
            {
                Console.Write("o");
            }
            Console.Write("\n Group2 :");
            for(int i = 1; i <= G2; i++)
            {
                Console.Write("o");
            }
            Console.Write("\n Group3 :");
            {
             for(int i = 1; i<= G3;i++)
                {
                    Console.Write("o");
                }
            }
                
        }
        public void Pick_Ball(int group, int ball)
        {
            if (group == 1)
            {
                G1 -= ball;
            }
            else if (group == 2)
            {
                G2 -= ball;
            }
            else if (group == 3)
            {
                G3 -= ball;
            }




        }
        public bool Game_Over()
        {
            if (G1 == 0 && G2 == 0 && G3 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
