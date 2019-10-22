using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Player
    {
        private string Name;
        public Player (string name)
        {
            Name = name;

        }
        public void PickBall(Board game)
        {
            Console.Write("Which group do you choose :");
            int group = int.Parse(Console.ReadLine());
            Console.Write("How many balls do you want to pick:");
            int balls = int.Parse(Console.ReadLine());
            game.PickBall(group, balls);
        }
        public string GetName()
        {
            return this.Name;
        }
    }
    
}
