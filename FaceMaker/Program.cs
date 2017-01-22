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
            Face gameFace = new Face();         // Instantiate the face object
            DisplayIntro();                     // Splash Screen

            while(true)
            {
                gameFace.DisplayFace();         // Prints latest face
                DisplayMenu();                  // Main Menu
            }



            Console.ReadLine();             // pause and keep window open for testing
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
            Console.WriteLine("                                                     ");

            Console.ReadLine();
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
            
            Console.ReadLine();


            // Options (Each should call methods in face)

            // Clear Face -- blanks face out and reloads
            // Random Face -- pulls a random number for each face possibility and reloads

            // each of these launches a method which changes the screen to a choose your whatever 

            // Change Hair
            // Change Eyes
            // Change Nose
            // Change Mouth
            // Change Chin

        }


    }
}
