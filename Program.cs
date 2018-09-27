using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //making an array of 3 player characters
            PlayerCharacter[] players = new PlayerCharacter[3]
            {
                new PlayerCharacter { Name = "Sarah}"},
                new PlayerCharacter(), // Name = null
                null // PlayerCharacter = null 
            };
            // null conditional operator when working with arrays
            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name; 

            //var player = new PlayerChara
            //player.DaysSinceLastLogin = 42;
            //int days = player?.DaysSinceLastLogin ?? -1;
            //Console.WriteLine(days);

            Console.ReadLine();
        }
    }
}
