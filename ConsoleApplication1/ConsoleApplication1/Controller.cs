using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Controller
    {
        private Board Game;
        private Player P1, P2;
       public  Controller()
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
                Console.WriteLine(P1.GetName() + "a turn");
                P1.PickBall(Game);
                Game.PrintGame();
                if(Game.IsGameOver())
                {
                    Console.WriteLine(P1.GetName() + " Hung da thua");
                    Console.WriteLine(P2.GetName() + " Nhan da thang");
                    break;
                }
                Console.WriteLine(P2.GetName() + " a turn");
                P2.PickBall(Game);
                Game.PrintGame();
                if(Game.IsGameOver())
                {
                    Console.WriteLine(P2.GetName() + " Nhan da thua ");
                    Console.WriteLine(P1.GetName() + "Hung da thang ");
                    break;
                }
            }
        }

    }
}
