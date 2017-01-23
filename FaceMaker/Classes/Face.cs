using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceMaker.Classes
{
    class Face
    {
        private string[] faceHairArray = new string[4];
        private string[] faceEyesArray = new string[5];
        private string[] faceNoseArray = new string[4];
        private string[] faceMouthArray = new string[5];
        private string[] faceChinArray = new string[3];

        private int[] currentFace = new int[5];                 // Keeps record of current face piece ID for each slot

        public Face()                                           // Constructor
        {
            SetFaceToBlank();
        }

        public void DisplayCurrentFace()
        {
            Console.Clear();

            for (int i = 0; i < faceHairArray.Length; i++)
            {
                Console.WriteLine(faceHairArray[i]);
            }

            for (int i = 0; i < faceEyesArray.Length; i++)
            {
                Console.WriteLine(faceEyesArray[i]);
            }

            for (int i = 0; i < faceNoseArray.Length; i++)
            {
                Console.WriteLine(faceNoseArray[i]);
            }

            for (int i = 0; i < faceMouthArray.Length; i++)
            {
                Console.WriteLine(faceMouthArray[i]);
            }

            for (int i = 0; i < faceChinArray.Length; i++)
            {
                Console.WriteLine(faceChinArray[i]);
            }
        }

        public void ChangeFace(int choice)
        {
            switch (choice)
            {
                case 1:
                    SetFaceToRandom();
                    break;
                case 2:
                    NextHair();
                    break;
                case 3:
                    NextEyes();
                    break;
                case 4:
                    NextNose();
                    break;
                case 5:
                    NextMouth();
                    break;
                case 6:
                    NextChin();
                    break;
                case 7:
                    SetFaceToBlank();
                    break;
            }
        }

        public void SetFaceToBlank()
        {
            SetHair(0);
            SetEyes(0);
            SetNose(0);
            SetMouth(0);
            SetChin(0);
        }

        public void SetFaceToRandom()
        {
            Random faceRandom = new Random();
            int randomTimes = faceRandom.Next(0, 5);

            for (int i = 0; i < randomTimes; i++)
            {
                NextHair();
            }
            randomTimes = faceRandom.Next(0, 5);
            for (int i = 0; i < randomTimes; i++)
            {
                NextEyes();
            }
            randomTimes = faceRandom.Next(0, 5);
            for (int i = 0; i < randomTimes; i++)
            {
                NextNose();
            }
            randomTimes = faceRandom.Next(0, 5);
            for (int i = 0; i < randomTimes; i++)
            {
                NextMouth();
            }
            randomTimes = faceRandom.Next(0, 5);
            for (int i = 0; i < randomTimes; i++)
            {
                NextChin();
            }
        }

        public void NextHair()
        {
            currentFace[0]++;
            if (currentFace[0] > 4)
            {
                currentFace[0] = 0;
            }
            SetHair(currentFace[0]);
        }

        public void NextEyes()
        {
            currentFace[1]++;
            if (currentFace[1] > 4)
            {
                currentFace[1] = 0;
            }
            SetEyes(currentFace[1]);
        }

        public void NextNose()
        {
            currentFace[2]++;
            if (currentFace[2] > 4)
            {
                currentFace[2] = 0;
            }
            SetNose(currentFace[2]);
        }

        public void NextMouth()
        {
            currentFace[3]++;
            if (currentFace[3] > 4)
            {
                currentFace[3] = 0;
            }
            SetMouth(currentFace[3]);
        }

        public void NextChin()
        {
            currentFace[4]++;
            if (currentFace[4] > 4)
            {
                currentFace[4] = 0;
            }
            SetChin(currentFace[4]);
        }

        public void SetHair(int choice)
        {
            switch (choice)
            {
                case 0:
                    faceHairArray[0] = "                   ooo OOO OOO ooo                   ";
                    faceHairArray[1] = "               oOO                 OOo               ";
                    faceHairArray[2] = "           oOO                         OOo           ";
                    faceHairArray[3] = "        oOO                               OOo        ";
                    break;
                case 1:
                    faceHairArray[0] = "                        /=/=/                        ";
                    faceHairArray[1] = "             /=/=/=/=/=/=/=/=/=/=/=/=/=/             ";
                    faceHairArray[2] = "           /=/=/=/=/=/=/=/=/=/=/=/=/=/=/=/           ";
                    faceHairArray[3] = "        /=/                               /=/        ";
                    break;
                case 2:
                    faceHairArray[0] = "                   _______________                   ";
                    faceHairArray[1] = "              ____/               \\____              ";
                    faceHairArray[2] = "          ___/         GO CAVS!        \\___          ";
                    faceHairArray[3] = "      ___/_________________________________\\___      ";
                    break;
                case 3:
                    faceHairArray[0] = "                   ooo OOO OOO ooo                   ";
                    faceHairArray[1] = "               ooO                 Ooo               ";
                    faceHairArray[2] = "           ###                         ###           ";
                    faceHairArray[3] = "        ######                         ######        ";
                    break;
                case 4:
                    faceHairArray[0] = "        |||||||||||||||||||||||||||||||||||||        ";
                    faceHairArray[1] = "        |||||||||||||||||||||||||||||||||||||        ";
                    faceHairArray[2] = "        |||||||||||||||||||||||||||||||||||||        ";
                    faceHairArray[3] = "        |||||||||||||||||||||||||||||||||||||        ";
                    break;
            }
        }

        public void SetEyes(int choice)
        {
            switch (choice)
            {
                case 0:
                    faceEyesArray[0] = "      oOO                                   OOo      ";
                    faceEyesArray[1] = "    oOO                                       OOo    ";
                    faceEyesArray[2] = "   oOO            o                o           OOo   ";
                    faceEyesArray[3] = "  oOO                                           OOo  ";
                    faceEyesArray[4] = " oOO                                             OOo ";
                    break;
                case 1:
                    faceEyesArray[0] = "      oOO                                   OOo      ";
                    faceEyesArray[1] = "    oOO       |-----|           |-----|       OOo    ";
                    faceEyesArray[2] = "   oOO/-------|  O  |-----------|  O  |-------\\OOo   ";
                    faceEyesArray[3] = "  oOO         |-----|           |-----|         OOo  ";
                    faceEyesArray[4] = " oOO                                             OOo ";
                    break;
                case 2:
                    faceEyesArray[0] = "      oOO                                   OOo      ";
                    faceEyesArray[1] = "    oOO         \\ /               \\ /         OOo    ";
                    faceEyesArray[2] = "   oOO           X                 X           OOo   ";
                    faceEyesArray[3] = "  oOO           / \\               / \\           OOo  ";
                    faceEyesArray[4] = " oOO                                             OOo ";
                    break;
                case 3:
                    faceEyesArray[0] = "      oOO                                   OOo      ";
                    faceEyesArray[1] = "    oOO       ______             ______       OOo    ";
                    faceEyesArray[2] = "   oOO         |    \\           /    |         OOo   ";
                    faceEyesArray[3] = "  oOO         _|__o__\\_       _/__o__|_         OOo  ";
                    faceEyesArray[4] = " oOO                                             OOo ";
                    break;
                case 4:
                    faceEyesArray[0] = "      oOO                                   OOo      ";
                    faceEyesArray[1] = "    oOO_______.________._x^x_.________._______OOo    ";
                    faceEyesArray[2] = "   oOO         \\      /       \\      /         OOo   ";
                    faceEyesArray[3] = "  oOO           \\____/         \\____/           OOo  ";
                    faceEyesArray[4] = " oOO                                             OOo ";
                    break;
            }
        }

        public void SetNose(int choice)
        {
            switch (choice)
            {
                case 0:
                    faceNoseArray[0] = " oOO                    __/                      OOo ";
                    faceNoseArray[1] = " oOO                 __/                         OOo ";
                    faceNoseArray[2] = " oOO                /                            OOo ";
                    faceNoseArray[3] = " oOO               /_______                      OOo ";
                    break;
                case 1:
                    faceNoseArray[0] = " oOO                     | |                     OOo ";
                    faceNoseArray[1] = " oOO                     | |                     OOo ";
                    faceNoseArray[2] = " oOO                    /   \\                    OOo ";
                    faceNoseArray[3] = " oOO                   /_o_o_\\                   OOo ";
                    break;
                case 2:
                    faceNoseArray[0] = " oOO                                             OOo ";
                    faceNoseArray[1] = " oOO                   /     \\                   OOo ";
                    faceNoseArray[2] = " oOO                   | O O |                   OOo ";
                    faceNoseArray[3] = " oOO                   \\     /                   OOo ";
                    break;
                case 3:
                    faceNoseArray[0] = " oOO                     ___                     OOo ";
                    faceNoseArray[1] = " oOO                     \\ /                     OOo ";
                    faceNoseArray[2] = " oOO                   '._:_.'                   OOo ";
                    faceNoseArray[3] = " oOO                                             OOo ";
                    break;
                case 4:
                    faceNoseArray[0] = " oOO                   /-----\\                   OOo ";
                    faceNoseArray[1] = " oOO                  /       \\                  OOo ";
                    faceNoseArray[2] = " oOO                  \\/\\___/\\/                  OOo ";
                    faceNoseArray[3] = " oOO                                             OOo ";
                    break;
            }
        }

        public void SetMouth(int choice)
        {
            switch (choice)
            {
                case 0:
                    faceMouthArray[0] = "  oOO                ____   ____                OOo  ";
                    faceMouthArray[1] = "   oOO              /    \\_/    \\              OOo   ";
                    faceMouthArray[2] = "    oOO            >-------------<            OOo    ";
                    faceMouthArray[3] = "      oOO           \\___________/           OOo      ";
                    faceMouthArray[4] = "        oOO                               OOo        ";
                    break;
                case 1:
                    faceMouthArray[0] = "  oOO                 _ _ _ _ _                 OOo  ";
                    faceMouthArray[1] = "   oOO              /|_|_|_|_|_|\\              OOo   ";
                    faceMouthArray[2] = "    oOO            (  _ _ _ _ _  )            OOo    ";
                    faceMouthArray[3] = "      oOO           \\|_|_|_|_|_|/           OOo      ";
                    faceMouthArray[4] = "        oO                                OOo        ";
                    break;
                case 2:
                    faceMouthArray[0] = "  oOO                                           OOo  ";
                    faceMouthArray[1] = "   oOO                                         OOo   ";
                    faceMouthArray[2] = "    oOO               __________              OOo    ";
                    faceMouthArray[3] = "      oOO              \\ /  \\ /             OOo      ";
                    faceMouthArray[4] = "        oO              '    '            OOo        ";
                    break;
                case 3:
                    faceMouthArray[0] = "  oOO                  ///|\\\\\\                  OOo  ";
                    faceMouthArray[1] = "   oOO              /////|||\\\\\\\\\\\\             OOo   ";
                    faceMouthArray[2] = "    oOO           ////  _____   \\\\\\\\          OOo    ";
                    faceMouthArray[3] = "      oOO                |||                OOo      ";
                    faceMouthArray[4] = "        oO                |               OOo        ";
                    break;
                case 4:
                    faceMouthArray[0] = "  oOO                                           OOo  ";
                    faceMouthArray[1] = "   oOO                _________                OOo   ";
                    faceMouthArray[2] = "    oOO              / _______ \\              OOo    ";
                    faceMouthArray[3] = "      oOO           /_/       \\_\\           OOo      ";
                    faceMouthArray[4] = "        oO                                OOo        ";
                    break;
            }
        }

        public void SetChin(int choice)
        {
            switch (choice)
            {
                case 0:
                    faceChinArray[0] = "           oOO                         OOo           ";
                    faceChinArray[1] = "               oOO                 OOo               ";
                    faceChinArray[2] = "                   ooo OOO OOO ooo                   ";
                    break;
                case 1:
                    faceChinArray[0] = "           oOO                         OOo           ";
                    faceChinArray[1] = "               oOO       _|_       OOo               ";
                    faceChinArray[2] = "                   ooo O)   (O ooo                   ";
                    break;
                case 2:
                    faceChinArray[0] = "           oOO ' .  '  .  '  .  '  . ' OOo           ";
                    faceChinArray[1] = "               oOO  .  '  .  '  .  OOo               ";
                    faceChinArray[2] = "                  \\ooo'O__'__O'ooo/                  ";
                    break;
                case 3:
                    faceChinArray[0] = "           ___            |            ___           ";
                    faceChinArray[1] = "              \\___     ___|___     ___/              ";
                    faceChinArray[2] = "                  \\___/       \\___/                  ";
                    break;
                case 4:
                    faceChinArray[0] = "           vVVv                       vVVv           ";
                    faceChinArray[1] = "               vVVv       v       vVVv               ";
                    faceChinArray[2] = "                   vvv VVV VVV vvv                   ";
                    break;
            }
        }
    }
}
