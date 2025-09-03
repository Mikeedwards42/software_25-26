// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Console;
using System.Net.Security;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Console.WriteLine(@"
  ██████╗  █████╗ ██╗     ███████╗ ██████╗ 
 ██╔═══██╗██╔══██╗██║     ██╔════╝██╔═══██╗
 ██║   ██║███████║██║     █████╗  ██║   ██║
 ██║   ██║██╔══██║██║     ██╔══╝  ██║   ██║
 ╚██████╔╝██║  ██║███████╗███████╗╚██████╔╝
  ╚═════╝ ╚═╝  ╚═╝╚══════╝╚══════╝ ╚═════╝ 
");

        Console.WriteLine("Choose your path: oldtown or california?");
        string answer = Console.ReadLine().ToLower();

        if (answer == "old town")
        {
            Console.WriteLine(@"
   OOO   L     DDDD        TTTTT  OOO  W     W  N   N
  O   O  L     D   D         T   O   O W     W  NN  N
  O   O  L     D    D        T   O   O W  W  W  N N N
  O   O  L     D   D         T   O   O W W W W  N  NN
   OOO   LLLLL DDDD          T    OOO   W   W   N   N
");
            Console.WriteLine("Do you give +100 gold or -100 gold?");
            answer = Console.ReadLine();

            if (answer == "+100 gold")
            {
                Console.WriteLine("You get mugged in the alley! 💀");
            }
            else if (answer == "-100 gold")
            {
                Console.WriteLine("The King rewards your sacrifice and gives you a fortune of gold! 👑💰");
            }
        }
        else if (answer == "california")
        {
            Console.WriteLine(@"
   CCCC   AAAAA  L       III FFFFF  OOOOO  RRRR   N   N  III  AAAAA
  C       A   A  L        I  F     O     O R   R  NN  N   I  A   A
  C       AAAAA  L        I  FFFF  O     O RRRR   N N N   I  AAAAA
  C       A   A  L        I  F     O     O R  R   N  NN   I  A   A
   CCCC   A   A  LLLLL   III F      OOOOO  R   R  N   N  III A   A
");
            Console.WriteLine("Do you go to the MINES or the FOREST?");
            answer = Console.ReadLine().ToLower();

            if (answer == "mines")
            {
                Console.WriteLine("Do you choose GOLD or DIAMOND?");
                answer = Console.ReadLine().ToLower();

                if (answer == "gold")
                {
                    Console.WriteLine("The market went up! You’re rich! 📈💰");
                }
                else if (answer == "diamond")
                {
                    Console.WriteLine("You got mugged in the dark caves! 🪓💀");
                }
            }
            else if (answer == "forest")
            {
                Console.WriteLine("Do you marry a TROLL or a FAIRY?");
                answer = Console.ReadLine().ToLower();

                if (answer == "fairy")
                {
                    Console.WriteLine("Oh no! The fairy catfished you! 🧚‍♀️😱");
                }
                else if (answer == "troll")
                {
                    Console.WriteLine("The troll was actually pretty! 💕👹");
                }
            }
        }
        else
        {
            Console.WriteLine("That’s not a valid path! Game over.");
        }
    }
}






























