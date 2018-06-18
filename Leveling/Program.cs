using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leveling
{
    class Program
    {
        int level = 1;
        int levelXP = 0;
        int levelXPremaining = 0;
        int leveltotalXP = 10;
        int playerTotalXP = 0;
        int playerUsedXP = 0;


        static void Main(string[] args)
        {
            string xp = "";
            Console.WriteLine("Welcome to the leveling system trial");
            Console.WriteLine("Please select the amount of experience you desire to gain");
            Console.WriteLine("(1) 1 XP");
            Console.WriteLine("(2) 5 XP");
            Console.WriteLine("(3) 10 XP");
            Console.WriteLine("(4) 25 XP");
            Console.WriteLine("(5) 50 XP");
            Console.WriteLine("(6) 100 XP");
            Console.Write("XP: ");

            switch(xp)
            {
                case "1":
                    LevelUp(1);
                    break;
                case "2":
                    LevelUp(5);
                    break;
                case "3":
                    LevelUp(10);
                    break;
                case "4":
                    LevelUp(25);
                    break;
                case "5":
                    LevelUp(50);
                    break;
                case "6":
                    LevelUp(100);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    return;
            }

        }

        public static void LevelUp(int xp)
        {
            level = 1;
            leveltotalXP = level * 10;


            levelXP = 0;
            levelXPremaining = levelTotalXP - levelXP;
            
            playerTotalXP += xp;
            playerUsedXP = 0;



        }
    }
}
