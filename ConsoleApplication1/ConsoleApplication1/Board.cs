using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Board
    {
        private int G1, G2, G3;
        public Board(int g1, int g2, int g3) 
        {
            this.G1 = g1;
            this.G2 = g2;
            this.G3 = g3;

        }
        public void PickBall(int g , int b)
        {
            switch(g)
            {
                case 1:
                    G1 -= b;
                    break;
                case 2:
                    G2 -= b;
                    break;
                case 3:
                    G3 -= b;
                    break;
            }
        }

        public void PrintGame()
        {
            Console.Write("Group 1: ");
            for (int i = 0; i < G1; i++)
            {
                Console.Write(" 0 ");
            }
            Console.WriteLine();
            Console.Write("Group 2: ");
            for( int i = 0; i < G2;i++)
            {
                Console.Write(" 0 ");
            }
            Console.WriteLine();
            Console.Write("Group 3: ");
            for(int i = 0;i < G3;i++)
            {
                Console.Write(" 0 ");
            }
            Console.WriteLine();
        }
        public bool IsGameOver()
        {
            if (G1 == 0 && G2 == 0 && G3 == 0)
                return true;
            else
                return false;
        }
    }
}
