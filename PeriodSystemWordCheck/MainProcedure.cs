using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PeriodSystemWordCheck
{
    internal class MainProcedure
    {
        public bool StartSearching(string @in, out string output)
        {
            Logger.Log("Checking input: " + @in);

            foreach (char item in @in)
            {
                if (!((item >= 65 && item <= 90) || (item >= 97 && item <= 122) || item == 32))
                {
                    Logger.Log("Input invalid!");
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
                    if (ElinList(t))
                    {
                        result += t;
                        i++;
                        continue;
                    }
                }

                if (ElinList(@in.ElementAt(i).ToString().ToUpper()))
                {
                    result += @in.ElementAt(i).ToString().ToUpper();
                }
                else
                {
                    Logger.Log("Your word can't be build with PSE");
                    output = "";
                    return false;
                }

            }


            output = result;
            return true;
        }

       public bool ElinList(string element)
        {
            foreach (var item in Program.elements)
            {
                if (item.ToLower() == element.ToLower())
                    return true;
            }
            return false;
        }

    }
}
