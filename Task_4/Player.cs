using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Player
    {
        public string playerName;
        public int level;
        public string health;


        public Player()
        {
            Console.WriteLine("Default Constructor Called");

        }
        public Player(string playerName, int level, string health)
        {
            Console.WriteLine("Parameterized Constructor Called");
            this.playerName = playerName;
            this.level = level;
            this.health = health;

        }

    }
}
