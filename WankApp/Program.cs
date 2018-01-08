using System;
using System.Threading;

namespace WankAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Wank myWank = new Wank();
            Console.WriteLine("Please Enter a Command");

            string line = Console.ReadLine();
            while (line != "exit")
            {
                switch (line)
                {
                    case ("wank offi"):
                        line = "";
                        myWank.Do_Fap(Wank.WankSpeed.Offi, 50, 40);
                        line = Console.ReadLine();
                        break;
                    case ("wank god"):
                        line = "";
                        myWank.Do_Fap(Wank.WankSpeed.God, 50, 32);
                        line = Console.ReadLine();
                        break;
                    case ("wank fast"):
                        line = "";
                        myWank.Do_Fap(Wank.WankSpeed.Fast, 50, 10);
                        line = Console.ReadLine();
                        break;
                    case ("wank slow"):
                        line = "";
                        myWank.Do_Fap(Wank.WankSpeed.Slow, 50, 10);
                        line = Console.ReadLine();
                        break;
                    case ("wank sloth"):
                        line = "";
                        myWank.Do_Fap(Wank.WankSpeed.Sloth, 50, 10);
                        line = Console.ReadLine();
                        break;
                    case ("wank tiny"):
                        line = "";
                        myWank.Do_Fap(Wank.WankSpeed.Tiny, 50, 6);
                        line = Console.ReadLine();
                        break;
                    case ("wank medium"):
                        line = "";
                        myWank.Do_Fap(Wank.WankSpeed.Med, 50, 10);
                        line = Console.ReadLine();
                        break;
                }
            }
        }
    }

    class Wank
    {
        int Fapcounter;
        int Blamcounter;
        int Faplength;
        int Fapdirection = 1;

        public void Fap()
        {
            Fapcounter = Fapcounter + Fapdirection;

            Console.Write("8");
            for (int i = 0; i < Faplength + 2; i++) {
                if (i == Fapcounter) {
                    Console.Write("MM");
                }
                Console.Write("=");
            }
            Console.Write("D");
            Console.SetCursorPosition(Console.CursorLeft - Faplength - 6, Console.CursorTop);

            if (Fapcounter > Faplength) {
                Fapdirection = -1;
            }

            if (Fapcounter < 1) {
                Fapdirection = 1;
            }

            // switch (Fapcounter % 6)
            // {
            //     case 0:
            //         Console.Write("8====MM=D");
            //         Console.SetCursorPosition(Console.CursorLeft - 9, Console.CursorTop);
            //         break;
            //     case 1:
            //         Console.Write("8===MM==D");
            //         Console.SetCursorPosition(Console.CursorLeft - 9, Console.CursorTop);
            //         break;
            //     case 2:
            //         Console.Write("8==MM===D");
            //         Console.SetCursorPosition(Console.CursorLeft - 9, Console.CursorTop);
            //         break;
            //     case 3:
            //         Console.Write("8=MM====D");
            //         Console.SetCursorPosition(Console.CursorLeft - 9, Console.CursorTop);
            //         break;
            //     case 4:
            //         Console.Write("8==MM===D");
            //         Console.SetCursorPosition(Console.CursorLeft - 9, Console.CursorTop);
            //         break;
            //     case 5:
            //         Console.Write("8===MM==D");
            //         Console.SetCursorPosition(Console.CursorLeft - 9, Console.CursorTop);
            //         break;
            // }
        }

        public void Do_Fap(WankSpeed speed, int strokes, int length)
        {
            Faplength = length;

            bool isWanking = true;
            int delayTime = 100;
            switch (speed)
            {
                case WankSpeed.God:
                    delayTime = 10;
                    break;

                case WankSpeed.Fast:
                    delayTime = 100;
                    break;

                case WankSpeed.Slow:
                    delayTime = 200;
                    break;

                case WankSpeed.Sloth:
                    delayTime = 350;
                    break;

                case WankSpeed.Med:
                    delayTime = 150;
                    break;

                case WankSpeed.Tiny:
                    delayTime = 150;
                    break;

                case WankSpeed.Offi:
                    delayTime = 135;
                    break;
            }
            if (isWanking)
            {
                for (int i = 0; i < strokes; i++)
                {
                    Thread.Sleep(delayTime);
                    Fap();
                }
                Do_Blamm();


                isWanking = false;
            }
            Console.Clear();
            Console.WriteLine("Please Enter a Command");

        }
        public void Blamm()
        {
            Blamcounter++;
            {
                Console.Write("8");
            for (int i = 0; i < Faplength + 2; i++)
            {
                if (i == Fapcounter)
                {
                    Console.Write("MM");
                }
                Console.Write("=");
            }
            Console.Write("D");
                    Console.Write(" --___");
            Console.SetCursorPosition(Console.CursorLeft - Faplength - 12, Console.CursorTop);
            }
    }

        public void Do_Blamm()
        {
            bool IsBlamming = true;
            if (IsBlamming)
            {
                for (int i = 0; i < 4; i++)
                {
                    Blamm();
                    System.Threading.Thread.Sleep(200);

                }
                IsBlamming = false;
            }
            Console.Clear();
            Console.WriteLine("Please Enter a Command");

        }
        public enum WankSpeed { Fast, Slow, God, Sloth, Tiny, Med, Offi }
    }



}