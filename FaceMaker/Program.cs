using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FaceMaker.Classes;

namespace FaceMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Face gameFace = new Face();                     // Set up game object

            DisplayIntro();                                 // Intro screen

            while (true)                                    // Game Loop
            {
                gameFace.DisplayCurrentFace();              // Draw the latest face

                DisplayMenu();                              // Show commands list

                gameFace.ChangeFace(TakePlayerInput());     // Take, validate player input and update face info
            }
        }

        static void DisplayIntro()
        {
            Console.WriteLine("                   ooo OOO OOO ooo                   ");
            Console.WriteLine("               oOO                 OOo               ");
            Console.WriteLine("           oOO                         OOo           ");
            Console.WriteLine("        oOO                               OOo        ");
            Console.WriteLine("      oOO                                   OOo      ");
            Console.WriteLine("    oOO                                       OOo    ");
            Console.WriteLine("   oOO      WELCOME               WRITTEN      OOo   ");
            Console.WriteLine("  oOO       TO FACE              BY NATHAN      OOo  ");
            Console.WriteLine(" oOO         MAKER                RATHBUN        OOo ");
            Console.WriteLine(" oOO                                             OOo ");
            Console.WriteLine(" oOO                                             OOo ");
            Console.WriteLine(" oOO                   PLEASE                    OOo ");
            Console.WriteLine(" oOO                                             OOo ");
            Console.WriteLine("  oOO                                           OOo  ");
            Console.WriteLine("   oOO      PRESS                    GAME      OOo   ");
            Console.WriteLine("    oOO           ENTER TO START THE          OOo    ");
            Console.WriteLine("      oOO                                   OOo      ");
            Console.WriteLine("        oO                                OOo        ");
            Console.WriteLine("           oOO                         OOo           ");
            Console.WriteLine("               oOO                 OOo               ");
            Console.WriteLine("                   ooo OOO OOO ooo                   ");

            Console.ReadLine();                 // press enter to continue
        }

        static void DisplayMenu()
        {
            Console.WriteLine(" [1] Generate a random face.");
            Console.WriteLine(" [2] Change your face's Hair.");
            Console.WriteLine(" [3] Change your face's Eyes.");
            Console.WriteLine(" [4] Change your face's Nose.");
            Console.WriteLine(" [5] Change your face's Mouth.");
            Console.WriteLine(" [6] Change your face's Chin.");
            Console.WriteLine(" [7] Start over with a blank face.");
        }

        static int TakePlayerInput()
        {
            char playerInput;
            bool isInputValid = false;

            while (!isInputValid)
            {
                isInputValid = char.TryParse(Console.ReadLine(), out playerInput);
                if (playerInput != '1' && playerInput != '2' && playerInput != '3' && playerInput != '4' && playerInput != '5' && playerInput != '6' && playerInput != '7')
                {
                    isInputValid = false;
                }
                else
                {
                    return int.Parse(playerInput.ToString()); // this is converting to int 50 for some reason
                }
            }
            return '0';
        }

    }
}
