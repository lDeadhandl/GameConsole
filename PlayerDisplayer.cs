﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("String is null or whitespace");

            }
            else
            {
                Console.WriteLine(player.Name);
            }
            Console.WriteLine(player.Name);
            
            //int days = player.DaysSinceLastLogin ?? -1;
            // conditional operator
            //int days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;
            //int days = player.DaysSinceLastLogin.GetValueOrDefault(-1);
            //Console.WriteLine($"{days} days since last login");
            //if(!player.DaysSinceLastLogin.HasValue)
            //{
            //    Console.WriteLine("No value for DaysSinceLastLogin");

            //}
            //else
            //{
            //    Console.WriteLine(player.DaysSinceLastLogin);
            //}

            if (player.DateOfBirth == null)
            {
                Console.WriteLine("No date of birth specified");

            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }

            if (player.IsNoob == null)
            {
                Console.WriteLine("Player newbie status is unknown");
            }
            else if (player.IsNoob == true)
            {
                Console.WriteLine("Player is a newbie");
            }
            else
            {
                Console.WriteLine("Player is experienced");
            }
        }
    }
}
