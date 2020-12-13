using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carti_translator
{
    class Program
    {
        public static string Translate(string word)
        {
            string translated = "END-RESULT";
            bool first = true;
            string last = "LAST-STRING";
            last = "";
            translated = "";

            foreach (char c in word)
            {
                if(first)
                {
                    translated = translated + char.ToUpper(c).ToString();
                    first = false;
                    last = char.ToLower(c).ToString();
                    continue;
                }

                if (char.IsUpper(c) && !first)
                {
                    translated = translated + char.ToLower(c).ToString();
                    last = char.ToLower(c).ToString();
                    continue;
                }

                if (c.ToString() == "0")
                {
                    translated = translated + "o";
                    continue;
                }
                if(last == "<") { } else
                {
                    if (c.ToString() == "3")
                    {
                        translated = translated + "e";
                        continue;
                    }
                }
                if (c.ToString() == "4")
                {
                    translated = translated + "for";
                    continue;
                }
                last = c.ToString();
                translated = translated + c.ToString();
                first = false;
            }
            return translated;
        }

        static void Main()
        {
            Console.Clear();
            string ascii = @" _____                     _       _   _   
/__   \_ __ __ _ _ __  ___| | __ _| |_| |_ 
  / /\/ '__/ _` | '_ \/ __| |/ _` | __| __|
 / /  | | | (_| | | | \__ \ | (_| | |_| |_ 
 \/   |_|  \__,_|_| |_|___/_|\__,_|\__|\__|
                                           
    - Playboi Carti translator";
            Console.Title = "Translatt | Playboi Carti translator made by angxl";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ascii);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Ent3r dA w0Rd tO trAnslatT > ");
            string cartiword = Console.ReadLine();
            string translation = Translate(cartiword);
            if(cartiword == "")
            {
                Main(); 
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ascii);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("oMG, w3 d0nE tRAnSlattIng > ");
            Console.Write(translation);
            Console.WriteLine();
            Console.WriteLine("pr3Ss an7 kEy tO trAnsLatt an0thEr w0rd");
            Console.ReadKey();
            Main();

        }
    }
}
