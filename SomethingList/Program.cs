using static System.Console;
using static Yann.wc;

namespace SomethingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;
            while (true)
            {
                Clear();
                WriteLine("Press the key to run the according program.");
                WriteLine("-------------------------------------------");
                WriteLine("'1'\tidk tests.");
                WriteLine("'2'\tFSTAuP09_PD6_KA3");
                WriteLine("'3'\tFSTInf21_L08_KA2");
                WriteLine("'0'\tProgramm beenden.");
                WriteLine("-------------------------------------------");
                char select = ReadKey().KeyChar;
                switch (select)
                {
                    case '0':
                        Write("\b");
                        Environment.Exit(42);
                        break;
                    case '1':
                        Clear();
                        idk_test();
                        break;
                    case '2':
                        Clear();
                        FSTAuP09_PD6_KA3();
                        break;
                    case '3':
                        Clear();
                        FSTInf21_L08_KA2();
                        break;
                }
            }
        }
        static void idk_test()
        {
            bool zurück = false;
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
                WriteLine("'0'\tZurück.");
                WriteLine("-------------------------------------------");
                char select = ReadKey().KeyChar;
                switch (select)
                {
                    case '0':
                        zurück = true;
                        break;
                    case '1':
                        Clear();
                        idk_test_.Programm1.Main1();
                        break;
                    case '2':
                        Clear();
                        idk_test_.Programm2.Main1();
                        break;
                    case '3':
                        Clear();
                        idk_test_.Programm3.Main1();
                        break;
                    case '4':
                        Clear();
                        idk_test_.Programm4.Main1();
                        break;
                    case '5':
                        Clear();
                        idk_test_.Programm5.Main1();
                        break;
                }
                if (zurück == true) { break; }
            }
        }
        static void FSTAuP09_PD6_KA3()
        {
            bool zurück = false;
            while (true)
            {
                Clear();
                WriteLine("Press the key to run the according program.");
                WriteLine("-------------------------------------------");
                WriteLine("'1'\tAufgabe 1: Wertetabelle und Summe der Zahlen");
                WriteLine("'2'\tAufgabe 2: Würfeln");
                WriteLine("'3'\tAufgabe 3: Body-Mass-Index");
                WriteLine("'4'\tAufgabe 4: Verschachtelte Schleifen");
                WriteLine("'5'\tAufgabe 5: Zahlenraten");
                WriteLine("'6'\tAufgabe 6: Kreuze suchen");
                WriteLine("'0'\tZurück.");
                WriteLine("-------------------------------------------");
                char select = ReadKey().KeyChar;
                switch (select)
                {
                    case '0':
                        zurück = true;
                        break;
                    case '1':
                        Clear();
                        FSTAuP09_PD6_KA3_.Programm1.Main1();
                        break;
                    case '2':
                        Clear();
                        FSTAuP09_PD6_KA3_.Programm2.Main1();
                        break;
                    case '3':
                        Clear();
                        FSTAuP09_PD6_KA3_.Programm3.Main1();
                        break;
                    case '4':
                        Clear();
                        FSTAuP09_PD6_KA3_.Programm4.Main1();
                        break;
                    case '5':
                        Clear();
                        FSTAuP09_PD6_KA3_.Programm5.Main1();
                        break;
                    case '6':
                        Clear();
                        FSTAuP09_PD6_KA3_.Programm6.Main1();
                        break;
                }
                if (zurück == true) { break; }
            }
        }
        static void FSTInf21_L08_KA2()
        {
            bool zurück = false;
            while (true)
            {
                Clear();
                WriteLine("Press the key to run the according program.");
                WriteLine("-------------------------------------------");
                WriteLine("'1'\tAufgabe 1: Theorie");
                WriteLine("'2'\tAufgabe 2: Theorie");
                WriteLine("'3'\tAufgabe 3: Würfeln");
                WriteLine("'4'\tAufgabe 4: Zahlenraten");
                WriteLine("'5'\tAufgabe 5: Schaltjahr");
                WriteLine("'6'\tAufgabe 6: Funktionstabelle");
                WriteLine("'6'\tAufgabe 7: Verschachtelte Schleifen");
                WriteLine("'0'\tZurück.");
                WriteLine("-------------------------------------------");
                char select = ReadKey().KeyChar;
                switch (select)
                {
                    case '0':
                        zurück = true;
                        break;
                    case '1':
                        Clear();
                        FSTInf21_L08_KA2_.Programm1.Main1();
                        break;
                    case '2':
                        Clear();
                        FSTInf21_L08_KA2_.Programm2.Main1();
                        break;
                    case '3':
                        Clear();
                        FSTInf21_L08_KA2_.Programm3.Main1();
                        break;
                    case '4':
                        Clear();
                        FSTInf21_L08_KA2_.Programm4.Main1();
                        break;
                    case '5':
                        Clear();
                        FSTInf21_L08_KA2_.Programm5.Main1();
                        break;
                    case '6':
                        Clear();
                        FSTInf21_L08_KA2_.Programm6.Main1();
                        break;
                    case '7':
                        Clear();
                        FSTInf21_L08_KA2_.Programm7.Main1();
                        break;
                }
                if (zurück == true) { break; }
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
}

namespace idk_test_
{
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

            if (IsPointInRectangle1(z, u) && IsPointInRectangle2(z, u)) { WriteLine("JA GEIL BEIDE!!!"); }
            else if (IsPointInRectangle1(z, u)) { WriteLine("JA GEIL 0"); }
            else if (IsPointInRectangle2(z, u)) { WriteLine("JA GEIL 1"); }
            else { WriteLine("JA NEIN"); }
            ReadKey();
        }
        public static bool IsPointInRectangle1(int x, int y)
        {
            if (x >= -2 && x <= 6)
                return y >= 1 && y <= 7;
            return false;
        }
        public static bool IsPointInRectangle2(int x, int y)
        {
            if (x >= -6 && x <= 2)
                return y >= -2 && y <= 3;
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

namespace FSTAuP09_PD6_KA3_
{
    public class Programm1
    {
        public static void Main1()
        {
            double erg;
            for (int i = 0; i < 9; i++)
            {
                erg = Math.Pow(2, i);
                WriteLine($"2^{i} = {erg.ToString().PadLeft(3)}");
            }
            ReadKey();
        }
    }
    public class Programm2
    {
        public static void Main1()
        {
            int[] counts = CheckList(RandomList());
            WriteLine($"Die Zahlen -7 bis -3 gibt es {counts[0]}mal. Das sind {RelativeMenge(counts[0]):N2}% der Zahlen.");
            WriteLine($"Die Zahlen -2 bis +2 gibt es {counts[1]}mal. Das sind {RelativeMenge(counts[1]):N2}% der Zahlen.");
            WriteLine($"Die Zahlen +3 bis +7 gibt es {counts[2]}mal. Das sind {RelativeMenge(counts[2]):N2}% der Zahlen.");
            ReadKey();
        }
        static List<int> RandomList()
        {
            List<int> list = new();
            Random rnd = new();
            for (int i = 0; i <= 5 * Math.Pow(10, 6); i++)
            {
                list.Add(rnd.Next(-7, 7 + 1));
            }
            list.Sort();
            return list;
        }
        static int[] CheckList(List<int> list)
        {
            int[] actualCount = new int[3];
            List<int> countAmKleinsten = new();
            List<int> countMitte = new();
            List<int> countAmGrößten = new();
            foreach (int n in list)
            {
                if (n <= -3)
                {
                    countAmKleinsten.Add(n);
                }
                else if (n >= 3)
                {
                    countAmGrößten.Add(n);
                }
                else
                {
                    countMitte.Add(n);
                }
            }
            actualCount[0] = countAmKleinsten.Count;
            actualCount[1] = countMitte.Count;
            actualCount[2] = countAmGrößten.Count;
            countAmKleinsten.Clear();
            countMitte.Clear();
            countAmGrößten.Clear();
            return actualCount;
        }
        static double RelativeMenge(int count)
        {
            return (100.0 / 5_000_000) * count;
        }
    }
    public class Programm3
    {
        public static void Main1()
        {
            while (true)
            {
                double gewicht = 0;
                double größe = 0;
                Write("Geben Sie ihr Gewicht in kg an: ");
                try { gewicht = Convert.ToDouble(ReadLine()); } catch (Exception e) { Clear(); WriteLine("Falsche Eingabe bitte gebe nur Ganzzahlen oder Kommazahlen an."); }
                Write("\nGeben Sie ihre Größe in m an: ");
                try { größe = Convert.ToDouble(ReadLine()); } catch (Exception e) { Clear(); WriteLine("Falsche Eingabe bitte gebe nur Ganzzahlen oder Kommazahlen an."); }
                Clear();
                WriteLine($"Ihr BMI ist {BMIBerechnen(gewicht, größe):N2}\n\nMöchten Sie eine weitere berechnung durchführen? 'ja' oder 'nein'");
                var eingabe = ReadLine();
                if (eingabe != "ja")
                {
                    break;
                }
                else
                {
                    Clear();
                }
            }
        }
        static double BMIBerechnen(double gewicht, double größe)
        {
            return gewicht / Math.Pow(größe, 2);
        }
    }
    public class Programm4
    {
        public static void Main1()
        {
            WriteLine("Hell nah!");
            ReadKey();
        }

    }
    public class Programm5
    {
        public static void Main1()
        {
            List<int> guessed = new();
            WriteLine("Zahlen Raten:");
            int zahlGuess;
            var i = 0;
            var rndZahl = RandomNumber();
            while (true)
            {
                i++;
                while (true)
                {
                    Write("Gebe eine Zahl zwischen 0 und 20 ein: ");
                    var guess = ReadLine();
                    try
                    {
                        zahlGuess = Convert.ToInt32(guess);
                        if (zahlGuess >= 0 && zahlGuess <= 20)
                        {
                            guessed.Add(zahlGuess);
                            Write("Die bisherigen Zahlen waren:");
                            foreach (var gue in guessed)
                            {
                                Write($" {gue}");
                            }
                            WriteLine();
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        WriteLineColor($"<*red*>{e.Message}<*/*>");
                    }
                }
                if (zahlGuess == rndZahl)
                {
                    WriteLine($"\nDu hast die Zahl {rndZahl} richtig erraten.\nDu hast {i} Versuche gebraucht.\nDeine geratenen Zahlen waren:");
                    for (int j = 1; j <= guessed.Count; j++)
                    {
                        WriteLine($"{j}. Versuch: {guessed[j - 1]}");
                    }
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
            }
            ReadKey();
        }
        static int RandomNumber()
        {
            var rnd = new Random();
            return rnd.Next(0, 20 + 1);
        }
    }
    public class Programm6
    {
        public static void Main1()
        {
            WriteLine("Hell nah!");
            ReadKey();
        }
    }
}

namespace FSTInf21_L08_KA2_
{
    public class Programm1
    {
        public static void Main1()
        {
            WriteLine("Was ist die Ausgabe der folgenden Codeabschnitte?");
            WriteLine("int a = 1;" +
                "\nint b = 7;" +
                "\nb = a++;" +
                "\nWriteLine(++b);" +
                "\n" +
                "\nint x = 9;" +
                "\nint y = 6;" +
                "\nx %= y;" +
                "\nWriteLine(x);" +
                "\n" +
                "\nint d = 8;" +
                "\nint e = --d;" +
                "\nif (d > 8)" +
                "\n{" +
                "\n\te = 9;" +
                "\n}" +
                "\nelse" +
                "\n{" +
                "\n\te -= 3;" +
                "\n}" +
                "\nWriteLine(e);" +
                "\n" +
                "\nint u = 2;" +
                "\ndo {" +
                "\n\tu += 3;" +
                "\n} while (u< 4);" +
                "\nWriteLine(u);");
            ReadKey();
            WriteLine("\nDie Ausgaben sind:\n2\n3\n4\n5\n");
            ReadKey();
            WriteLine("\nÜberprüfung:");
            Überprüfung();
            ReadKey();
        }
        static void Überprüfung()
        {
            int a = 1;
            int b = 7;
            b = a++;
            WriteLine(++b);

            int x = 9;
            int y = 6;
            x %= y;
            WriteLine(x);

            int d = 8;
            int e = --d;
            if (d > 8)
            {
                e = 9;
            }
            else
            {
                e -= 3;
            }
            WriteLine(e);

            int u = 2;
            do
            {
                u += 3;
            } while (u < 4);
            WriteLine(u);
        }
    }
    public class Programm2
    {
        public static void Main1()
        {
            WriteLine("Bitte die Lücken füllen, damit der Wert von x fünfmal ausgegeben wird!\n");
            WriteLine("int x = 42;\n" +
                "int num = 0;\n" +
                "while (num < _______)\n" +
                "{\n" +
                "\tWriteLine(______);\n" +
                "\t______++;\n" +
                "}");
            ReadKey();
            WriteLine("\nLösungsansatz:");
            WriteLine("int x = 42;\n" +
                "int num = 0;\n" +
                "while (num < 5)\n" +
                "{\n" +
                "\tWriteLine(x);\n" +
                "\tnum++;\n" +
                "}");
            ReadKey();
            WriteLine("\nAusgabe Lösungsansatz:");
            int x = 42;
            int num = 0;
            while (num < 5)
            {
                WriteLine(x);
                num++;
            }
            ReadKey();
        }
    }
    public class Programm3
    {
        static Random rnd = new();
        public static void Main1()
        {
            bool zurück = false;
            while (true)
            {
                Clear();
                WriteLine("Press the key to run the according program.");
                WriteLine("-------------------------------------------");
                WriteLine("'1'\ta): 5mal Würfeln und Summe aus Augen.");
                WriteLine("'2'\tb): Wie oft Augenzahl bei 1.000.000 würfen.");
                WriteLine("'0'\tZurück.");
                WriteLine("-------------------------------------------");
                char select = ReadKey().KeyChar;
                switch (select)
                {
                    case '0':
                        zurück = true;
                        break;
                    case '1':
                        Clear();
                        AufgabeA();
                        break;
                    case '2':
                        Clear();
                        AufgabeB();
                        break;
                }
                if (zurück == true) { break; }
            }
        }
        static void AufgabeA()
        {
            WriteLine($"Die Summe der Augen bei den 5 Würfen beträgt {Würfel5mal()}.");
            ReadKey();
        }
        static int Würfel5mal()
        {
            int[] würfe = new int[5];
            for (int i = 0; i < 5; i++)
            {
                würfe[i] = rnd.Next(1, 6+1);
            }
            return würfe.Sum(x => x);
            
        }
        static void AufgabeB()
        {
            var würfe = VielWürfeln(); 
            for (int i = 1; i <= 6; i++)
            {
                WriteLine($"Die Zahl {i} kommt {WieOft(würfe, i):N0}mal vor.");
            }
            ReadKey();
        }
        static int WieOft(List<int> list, int augen)
        {
            return list.Count(x => x == augen);;
        }
        static List<int> VielWürfeln()
        {
            List<int> list = new();
            for (int i = 0; i < 1_000_000; i++)
            {
                list.Add(rnd.Next(1,6+1));
            }
            list.Sort();
            return list;
        }
    }
    public class Programm4
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
                    WriteLine("\nGebe eine Zahl ein (1-30):");
                    var guess = ReadLine();
                    try { zahlGuess = Convert.ToInt32(guess); if (zahlGuess >= 1 && zahlGuess <= 30) { break; } } catch (Exception e) { WriteLineColor($"<*red*>{e.Message}<*/*>"); }
                }
                if (zahlGuess == rndZahl)
                {
                    WriteLine($"Du hast die Zahl {rndZahl} richtig erraten.\nDu hast {i} Versuche gebraucht.");
                    Write("Neues Spiel? 'j'/'n' ");
                    if (ReadKey().KeyChar != 'j')
                    {
                        break;
                    }
                    else
                    {
                        WriteLine();
                        Main1();
                        break;
                    }
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
        }
        static int RandomNumber()
        {
            var rnd = new Random();
            return rnd.Next(1, 30 + 1);
        }
    }
    public class Programm5
    {
        public static void Main1()
        {
            List<int> schlatJahre = new();
            for (int i = 1600; i <= 2000; i++)
            {
                if (IstSchaltjahr(i)) { WriteLine($"{i} ist ein Schaltjahr."); schlatJahre.Add(i); }
            }
            WriteLine($"\nVon 1600-2000 gab es {schlatJahre.Count} Schaltjahre.");
            ReadKey();
        }
        static bool IstSchaltjahr(int jahr)
        {
            if (jahr % 400 == 0) { return true; }
            if (jahr % 100 == 0) { return false; }
            if (jahr % 4 == 0) { return true; }
            return false;
        }
    }
    public class Programm6
    {
        public static void Main1()
        {
            ForegroundColor = ConsoleColor.Cyan;
            BackgroundColor = ConsoleColor.DarkBlue;
            Clear();
            WriteLine();
            int basis;
            int von;
            int bis;
            var test = WindowWidth;
            SetCursorPosition(WindowWidth/2 - 9, CursorTop);
            WriteLine("Potenzen berechnen\n", ForegroundColor = ConsoleColor.Green, BackgroundColor = ConsoleColor.DarkRed);
            BackgroundColor = ConsoleColor.DarkBlue;
            Write("Im folgenden können die Potenzen zu einer ", ForegroundColor = ConsoleColor.Cyan);
            Write("Basis B", ForegroundColor = ConsoleColor.Red);
            Write(" berechnet werden. Es wird dann eine Tabelle von ", ForegroundColor = ConsoleColor.Cyan);
            Write("von", ForegroundColor = ConsoleColor.Red);
            Write(" bis ", ForegroundColor = ConsoleColor.Cyan);
            Write("bis", ForegroundColor = ConsoleColor.Red);
            WriteLine(" ausgegeben.\n", ForegroundColor = ConsoleColor.Cyan);
            WriteLine("Bitte geben Sie ein (Enter übernimmt Standardwerte!)", ForegroundColor = ConsoleColor.Cyan);
            Write("Basis B: ", ForegroundColor = ConsoleColor.Cyan);
            ForegroundColor = ConsoleColor.Red;
            try { basis = Convert.ToInt32(ReadLine()); } catch { basis = 4; }
            Write("von: ", ForegroundColor = ConsoleColor.Cyan);
            ForegroundColor = ConsoleColor.Red;
            try { von = Convert.ToInt32(ReadLine()); } catch { von = 0; }
            Write("bis: ", ForegroundColor = ConsoleColor.Cyan);
            ForegroundColor = ConsoleColor.Red;
            try { bis = Convert.ToInt32(ReadLine()); } catch { bis = 6; }
            WriteLine($"\nExponent  |  {basis}^Exponent", ForegroundColor = ConsoleColor.Cyan);
            WriteLine(new string('-', 30));
            for (int i = von; i <= bis; i++)
            {
                var erg = Math.Pow(basis, i);
                WriteLine($"{i.ToString().PadLeft(8)}  |  {erg.ToString("N0").PadLeft(8)}");
            }
            ReadKey();
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;
        }
    }
    public class Programm7
    {
        public static void Main1()
        {
            ReadKey();
        }
    }
}