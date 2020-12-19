using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PSE_with_PictureCombine
{
    class Program
    {
        internal static bool ConsoleRunning = false;
        public static List<string> elements = new List<string>();
        private static List<string> names = new List<string>();
        static void Main(string[] args)
        {
            Console.Title = "PSE Generator with picture output";

            AddItems();

            ConsoleRunning = true;

            Console.WriteLine("Please enter a Word to check");

            string output;

            string line = "";
            while (ConsoleRunning)
            {
                line = Console.ReadLine();

                if (line == "stop" || line == "end")
                {
                    Environment.Exit(0);
                }

                if (line == null || line == " " || line == "")
                {
                    Console.WriteLine("Error: invalid input");
                    Console.WriteLine("Sorry the input can't be empty");
                }
                else
                {
                    Console.WriteLine("Word: " + line);
                    if (Searching(line, out output))
                    {
                        CombinePsePics.CombinePics(names);
                        Console.WriteLine("Your word can be built: " + output);
                    }
                    
                    names.Clear();

                }
            }
        }

        private static bool Searching(string @in, out string output)
        {
            Console.WriteLine("Checking input: " + @in);

            foreach (char item in @in)
            {
                if (!((item >= 65 && item <= 90) || (item >= 97 && item <= 122) || item == 32))
                {
                    Console.WriteLine("Input invalid!");
                    Console.WriteLine("Your Input can't contain any special characters");
                    output = "";
                    return false; //invalid
                }
            }

            string result = "";

            for (int i = 0; i < @in.Length; i++)
            {

                if (@in.ElementAt(i) == ' ')
                {
                    result += " ";
                    continue;
                }

                if (i < @in.Length - 1)
                {
                    string t = @in.ElementAt(i).ToString().ToUpper() + @in.ElementAt(i + 1).ToString().ToLower();
                    if (ElementInPseList(t))
                    {
                        result += t;
                        names.Add(t);
                        i++;
                        continue;
                    }
                }

                if (ElementInPseList(@in.ElementAt(i).ToString().ToUpper()))
                {
                    names.Add(@in.ElementAt(i).ToString().ToUpper());
                    result += @in.ElementAt(i).ToString().ToUpper();
                }
                else
                {
                    Console.WriteLine("Your word can't be build with PSE");
                    output = "";
                    return false;
                }

            }


            output = result;
            return true;
        }

        private static bool ElementInPseList(string element)
        {
            foreach (var item in elements)
            {
                if (item.ToLower() == element.ToLower())
                    return true;
            }
            return false;
        }

        private static void AddItems()
        {
            elements.Add("H");
            elements.Add("He");
            elements.Add("Li");
            elements.Add("Be");
            elements.Add("B");
            elements.Add("C");
            elements.Add("N");
            elements.Add("O");
            elements.Add("F");
            elements.Add("Ne");
            elements.Add("Na");
            elements.Add("Mg");
            elements.Add("Al");
            elements.Add("Si");
            elements.Add("P");
            elements.Add("S");
            elements.Add("Cl");
            elements.Add("Ar");
            elements.Add("K");
            elements.Add("Ca");
            elements.Add("Sc");
            elements.Add("Ti");
            elements.Add("V");
            elements.Add("Cr");
            elements.Add("Mn");
            elements.Add("Fe");
            elements.Add("Co");
            elements.Add("Ni");
            elements.Add("Cu");
            elements.Add("Zn");
            elements.Add("Ga");
            elements.Add("Ge");
            elements.Add("As");
            elements.Add("Se");
            elements.Add("Br");
            elements.Add("Kr");
            elements.Add("Rb");
            elements.Add("Sr");
            elements.Add("Y");
            elements.Add("Zr");
            elements.Add("Nb");
            elements.Add("Mo");
            elements.Add("Tc");
            elements.Add("Ru");
            elements.Add("Rh");
            elements.Add("Pd");
            elements.Add("Ag");
            elements.Add("Cd");
            elements.Add("In");
            elements.Add("Sn");
            elements.Add("Sb");
            elements.Add("Te");
            elements.Add("I");
            elements.Add("Xe");
            elements.Add("Cs");
            elements.Add("Ba");
            elements.Add("La");
            elements.Add("Ce");
            elements.Add("Pr");
            elements.Add("Nd");
            elements.Add("Pm");
            elements.Add("Sm");
            elements.Add("Eu");
            elements.Add("Gd");
            elements.Add("Tb");
            elements.Add("Dy");
            elements.Add("Ho");
            elements.Add("Er");
            elements.Add("Tm");
            elements.Add("Yb");
            elements.Add("Lu");
            elements.Add("Hf");
            elements.Add("Ta");
            elements.Add("W");
            elements.Add("Re");
            elements.Add("Os");
            elements.Add("Ir");
            elements.Add("Pt");
            elements.Add("Au");
            elements.Add("Hg");
            elements.Add("Tl");
            elements.Add("Pb");
            elements.Add("Bi");
            elements.Add("Po");
            elements.Add("At");
            elements.Add("Rn");
            elements.Add("Fr");
            elements.Add("Ra");
            elements.Add("Ac");
            elements.Add("Th");
            elements.Add("Pa");
            elements.Add("U");
            elements.Add("Np");
            elements.Add("Pu");
            elements.Add("Am");
            elements.Add("Cm");
            elements.Add("Bk");
            elements.Add("Cf");
            elements.Add("Es");
            elements.Add("Fm");
            elements.Add("Md");
            elements.Add("No");
            elements.Add("Lr");
            elements.Add("Rf");
            elements.Add("Db");
            elements.Add("Sg");
            elements.Add("Bh");
            elements.Add("Hs");
            elements.Add("Mt");
            elements.Add("Ds");
            elements.Add("Rg");
            elements.Add("Cn");
            elements.Add("Nh");
            elements.Add("Fl");
            elements.Add("Mc");
            elements.Add("Lv");
            elements.Add("Ts");
            elements.Add("Og");

        }
    }
}
