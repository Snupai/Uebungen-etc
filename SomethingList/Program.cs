using static System.Console;
using static Yann.wc;

namespace SomethingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Programm1.Main1();
            Programm2.Main1();
            ReadKey();
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
        static int zahlGuess;
        public static void Main1()
        {
            while (true) {
                WriteLine("Zahlen Raten:\nGebe eine Zahl zwischen 0 und 100 ein:");
                var guess = ReadLine();
                try { zahlGuess = Convert.ToInt32(guess); } catch (Exception e) { WriteLineColor($"<*red*>{e.Message}<*/*>"); }
                if (zahGuess == )
                {
                    break;
                }
            }
        }
    }

}