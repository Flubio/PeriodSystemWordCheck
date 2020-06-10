using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PeriodSystemWordCheck
{
    class Program
    {
        internal static bool ConsoleRunning = false;
        public static List<string> elements = new List<string>();
        static void Main(string[] args)
        {

            MainProcedure mainProcedure = new MainProcedure();

            AddItems();

            ConsoleRunning = true;

            Logger.Log("Please enter a Word to check");


            string output;

            string line = "";
            while (ConsoleRunning)
            {
                line = Console.ReadLine();

                if(line == "stop" || line == "end")
                {
                    Environment.Exit(0);
                }

                if(line == null || line == " ")
                {
                    Logger.Log("Error: invalid input");
                    Logger.Log("Sorry the input can't be empty");
                }
                else
                {
                    Logger.Log("Word: " + line);
                    if (mainProcedure.StartSearching(line, out output))
                        Logger.Log("Your word can be built: " + output);

                }
            }

            

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
