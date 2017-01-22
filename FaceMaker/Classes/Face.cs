using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceMaker.Classes
{
    class Face
    {
        private string[] faceDisplayHair = new string[4];       // Hair String Array
        private string[] faceDisplayEyes = new string[5];       // Eyes String Array
        private string[] faceDisplayNose = new string[4];       // Nose String Array
        private string[] faceDisplayMouth = new string[5];      // Mouth String Array
        private string[] faceDisplayChin = new string[4];       // Chin String Array

        public Face()                                           // Constructor
        {
            SetFaceToBlank();
        }

        public void DisplayFace()
        {
            Console.Clear();

            for (int i = 0; i < faceDisplayHair.Length; i++)
            {
                Console.WriteLine(faceDisplayHair[i]);
            }

            for (int i = 0; i < faceDisplayEyes.Length; i++)
            {
                Console.WriteLine(faceDisplayEyes[i]);
            }

            for (int i = 0; i < faceDisplayNose.Length; i++)
            {
                Console.WriteLine(faceDisplayNose[i]);
            }

            for (int i = 0; i < faceDisplayMouth.Length; i++)
            {
                Console.WriteLine(faceDisplayMouth[i]);
            }

            for (int i = 0; i < faceDisplayChin.Length; i++)
            {
                Console.WriteLine(faceDisplayChin[i]);
            }
        }                            // Prints the current face

        public void SetFaceToBlank()                            // Blank out the whole face
        {
            SetHair("                   ooo OOO OOO ooo                   ",
                    "               oOO                 OOo               ",
                    "           oOO                         OOo           ",
                    "        oOO                               OOo        ");

            SetEyes("      oOO                                   OOo      ",
                    "    oOO                                       OOo    ",
                    "   oOO                                         OOo   ",
                    "  oOO                                           OOo  ",
                    " oOO                                             OOo ");

            SetNose(" oOO                                             OOo ",
                    " oOO                                             OOo ",
                    " oOO                                             OOo ",
                    " oOO                                             OOo ");

            SetMouth("  oOO                                           OOo  ",
                     "   oOO                                         OOo   ",
                     "    oOO                                       OOo    ",
                     "      oOO                                   OOo      ",
                     "        oO                                OOo        ");

            SetChin("           oOO                         OOo           ",
                    "               oOO                 OOo               ",
                    "                   ooo OOO OOO ooo                   ",
                    "                                                     ");
        }

        public void SetHair(string lineZero, string lineOne, string lineTwo, string lineThree)
        {
            this.faceDisplayHair[0] = lineZero;
            this.faceDisplayHair[1] = lineOne;
            this.faceDisplayHair[2] = lineTwo;
            this.faceDisplayHair[3] = lineThree;
        }

        public void SetEyes(string lineZero, string lineOne, string lineTwo, string lineThree, string lineFour)
        {
            this.faceDisplayEyes[0] = lineZero;
            this.faceDisplayEyes[1] = lineOne;
            this.faceDisplayEyes[2] = lineTwo;
            this.faceDisplayEyes[3] = lineThree;
            this.faceDisplayEyes[4] = lineFour;
        }

        public void SetNose(string lineZero, string lineOne, string lineTwo, string lineThree)
        {
            this.faceDisplayNose[0] = lineZero;
            this.faceDisplayNose[1] = lineOne;
            this.faceDisplayNose[2] = lineTwo;
            this.faceDisplayNose[3] = lineThree;
        }

        public void SetMouth(string lineZero, string lineOne, string lineTwo, string lineThree, string lineFour)
        {
            this.faceDisplayMouth[0] = lineZero;
            this.faceDisplayMouth[1] = lineOne;
            this.faceDisplayMouth[2] = lineTwo;
            this.faceDisplayMouth[3] = lineThree;
            this.faceDisplayMouth[4] = lineFour;
        }

        public void SetChin(string lineZero, string lineOne, string lineTwo, string lineThree)
        {
            this.faceDisplayChin[0] = lineZero;
            this.faceDisplayChin[1] = lineOne;
            this.faceDisplayChin[2] = lineTwo;
            this.faceDisplayChin[3] = lineThree;
        }



    }
}
