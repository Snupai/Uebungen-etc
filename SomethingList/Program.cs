using System.Drawing;
using static System.Console;
using static Yann.wc;

namespace SomethingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Clear();
                WriteLine("Press the key to run the according program.");
                WriteLine("-------------------------------------------");
                WriteLine("'1'\t6 aus 49.");
                WriteLine("'2'\tZahlen raten.");
                WriteLine("'3'\tZahlen erraten lassen.");
                WriteLine("'4'\tRechteck scheiß.");
                WriteLine("'5'\t1mal1 is 3.");
                WriteLine("'0'\tProgramm beenden.");
                WriteLine("-------------------------------------------");
                char select = ReadKey().KeyChar;
                switch (select)
                {
                    case '0':
                        Environment.Exit(42);
                        break;
                    case '1':
                        Clear();
                        Programm1.Main1();
                        break;
                    case '2':
                        Clear();
                        Programm2.Main1();
                        break;
                    case '3':
                        Clear();
                        Programm3.Main1();
                        break;
                    case '4':
                        Clear();
                        Programm4.Main1();
                        break;
                    case '5':
                        Clear();
                        Programm5.Main1();
                        break;
                }
            }
        }

        static void Test()
        {
            //
            // This program demonstrates all colors and backgrounds.
            //
            Type type = typeof(ConsoleColor);
            ForegroundColor = ConsoleColor.White;
            foreach (var name in Enum.GetNames(type))
            {
                BackgroundColor = (ConsoleColor)Enum.Parse(type, name);
                WriteLine(name);
            }
            BackgroundColor = ConsoleColor.Black;
            foreach (var name in Enum.GetNames(type))
            {
                ForegroundColor = (ConsoleColor)Enum.Parse(type, name);
                WriteLine(name);
            }

            //
            // This is an example to show you how to you WriteColor or WriteLineColor
            //
            WriteLineColor("\nYou can see all possible colors above!\nThis is an example string for <*!red*>background color<*/!*> and <*red*>foreground color<*/*>.");
        }
    }
    public class Programm1
    {
        public static void Main1()
        {
            foreach (var zahl in ZahlenZiehen(ListeErstellen()))
            {
                WriteLineColor($"<*green*>{zahl}<*/*>");
            }
            ReadKey();
        }
        public static List<int> ListeErstellen()
        {
            List<int> zahlen = new();
            for (int i = 1; i < 50; i++)
            {
                zahlen.Add(i);
            }
            return zahlen;
        }

        public static int[] ZahlenZiehen(List<int> zahlen)
        {
            List<int> lotto = new();
            for (int i = 0; i < 6; i++)
            {
                Random rnd = new();
                var zahl = zahlen[rnd.Next(zahlen.Count)];
                lotto.Add(zahl);
                zahlen.Remove(zahl);
            }
            zahlen.Clear();
            return lotto.ToArray();
        }
    }
    public class Programm2
    {
        public static void Main1()
        {
            WriteLine("Zahlen Raten:");
            int zahlGuess;
            var i = 0;
            var rndZahl = RandomNumber();
            while (true)
            {
                i++;
                while (true)
                {
                    WriteLine("\nGebe eine Zahl zwischen 0 und 100 ein:");
                    var guess = ReadLine();
                    try { zahlGuess = Convert.ToInt32(guess); if (zahlGuess >= 0 && zahlGuess <= 100) { break; } } catch (Exception e) { WriteLineColor($"<*red*>{e.Message}<*/*>"); }
                }
                if (zahlGuess == rndZahl)
                {
                    WriteLine($"Du hast die Zahl {rndZahl} richtig erraten.\nDu hast {i} Versuche gebraucht.");
                    break;
                }
                else if (zahlGuess > rndZahl)
                {
                    WriteLine("Die gesuchte Zahl ist niedriger.");
                }
                else
                {
                    WriteLine("Die gesuchte Zahl ist größer.");
                }
                WriteLine("\n----------------------------------------------");
            }
            ReadKey();
        }
        static int RandomNumber()
        {
            var rnd = new Random();
            return rnd.Next(0, 100 + 1);
        }
    }
    public class Programm3
    {
        public static void Main1()
        {
            WriteLine("Zahlen Raten lassen:");
            int rndZahl;
            while (true)
            {
                WriteLine("\nGebe eine Zahl zwischen 0 und 100 ein:");
                var rndInput = ReadLine();
                try { rndZahl = Convert.ToInt32(rndInput); if (rndZahl >= 0 && rndZahl <= 100) { break; } } catch (Exception e) { WriteLineColor($"<*red*>{e.Message}<*/*>"); }
            }
            ZahlErraten(rndZahl);
            ReadKey();
        }
        static void ZahlErraten(int rndZahl)
        {
            List<int> guessed = new();
            var i = 0;
            var zahlGuess = 100;
            zahlGuess /= 2;
            var leZahl = zahlGuess;
            guessed.Add(zahlGuess);
            while (true)
            {
                WriteLine($"\nGuessed: {zahlGuess}");
                i++;
                if (zahlGuess == rndZahl)
                {
                    WriteLine($"Deine Zahl ist {rndZahl}.\nIch habe {i} Versuche gebraucht sie zu erraten.");
                    break;
                }
                else if (zahlGuess > rndZahl)
                {
                    WriteLine("Die gesuchte Zahl ist niedriger.");
                    leZahl = leZahl / 2;
                    zahlGuess = zahlGuess - leZahl;
                    if (guessed.Contains(zahlGuess)) zahlGuess -= 1;
                    guessed.Add(zahlGuess);
                }
                else
                {
                    WriteLine("Die gesuchte Zahl ist größer.");
                    leZahl = leZahl / 2;
                    zahlGuess = zahlGuess + leZahl;
                    if (guessed.Contains(zahlGuess)) zahlGuess += 1;
                    guessed.Add(zahlGuess);
                }
            }
        }
    }
    public class Programm4
    {
        public static void Main1()
        {
            WriteLine("Gebe Koordinaten an.\tExample: '6,1'");
            string pointIn = ReadLine();
            if (pointIn == "") { pointIn = "1,1"; }
            string[] point = pointIn.Split(",");
            int z = Convert.ToInt16(point[0]);
            int u = Convert.ToInt16(point[1]);

            Rectangle rectangle = new Rectangle(-2, 1, 8, 6);
            Rectangle rectangle1 = new(-6, -2, 8, 5);

            if (rectangle.Contains(z, u) && rectangle1.Contains(z, u)) { WriteLine("JA GEIL BEIDE"); }
            else if (rectangle.Contains(z, u)) { WriteLine("JA GEIL 0"); }
            else if (rectangle.Contains(z, u)) { WriteLine("JA GEIL 1"); }
            else if (IsPointOnRectangleEdge(rectangle, z, u)) { WriteLine("JA GEIL 0"); }
            else if (IsPointOnRectangleEdge(rectangle1, z, u)) { WriteLine("JA GEIL 1"); }
            else { WriteLine("JA NEIN"); }
            ReadKey();

        }
        public static bool IsPointOnRectangleEdge(Rectangle rect, int x, int y)
        {
            if (x == rect.Left || x == rect.Right)
                return y >= rect.Top && y <= rect.Bottom;
            if (y == rect.Top || y == rect.Bottom)
                return x >= rect.Left && x <= rect.Right;
            return false;
        }
    }
    public class Programm5
    {
        public static void Main1()
        {
            Console.Title = "NÄHER!";
            //Console.SetWindowSize(85, 22);
            //Console.SetBufferSize(WindowWidth, WindowHeight);

            var o = 0;
            var k = 1;
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    var res = i * j;
                    if (i == 0)
                    {
                        var geg = o++ * 1;
                        if (geg >= 1)
                        {
                            WriteColor($"<*red*>{geg.ToString().PadLeft(3)}<*/*> |\t");
                        }
                        else
                        {
                            Write("\t");
                        }
                    }
                    else if (j == 0 && i >= 1)
                    {
                        var geg = k++ * 1;
                        WriteColor($"<*red*>{geg.ToString().PadLeft(3)}<*/*> |\t");
                    }

                    else if (i >= 1 || j >= 1)
                    {
                        WriteColor($"<*green*>{res.ToString().PadLeft(3)}<*/*> |\t");
                    }
                }
                WriteLine();
                Write(new string('-', 85));
                WriteLine();
            }
            ReadKey();
        }
    }
}