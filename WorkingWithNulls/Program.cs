using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithNulls
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 4

            PlayerCharacter sarah = new PlayerCharacter(new DiamondSkinDefense())
            {
                Name = "Sarah"
            };

            PlayerCharacter amrit = new PlayerCharacter(new IIronBonesDefense())
            {
                Name = "Amrit"
            };

            PlayerCharacter gentry = new PlayerCharacter(new NullDefense())
            {
                Name = "Gentry"
            };


            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);

            Console.ReadLine();
           













        //Part 3
            //PlayerCharacter[] players = null;

            //string p1 = players?[0]?.Name;
            //string p2 = players?[1]?.Name;
            //string p3 = players?[2]?.Name;

            //Console.ReadLine();

         // Part 2
            //PlayerCharacter[] players = new PlayerCharacter[3]
            //{
            //    new PlayerCharacter {Name = "Sarah"},
            //    new PlayerCharacter(), // Name = null
            //    null // PlayerCharacter = null
            //};


         //Part 1
            // *******************************************************
            //PlayerCharacter player = new PlayerCharacter();
            ////player.DaysSinceLastLogin = 42;

            ////int days = player.DaysSinceLastLogin.Value;
            //int days = player?.DaysSinceLastLogin ?? -1;

            //Console.WriteLine(days);

            //Console.ReadLine();
        }
    }
}
