using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationLibrary
{
    class FrenchToSpanish
    {
        public static string FrancezaSpaniola(string input)
        {

            string[] words = input.Split(new string[] { ".", " ", ":", ";", "-", "`", ",", "/" }, StringSplitOptions.None);
            string ToReturn = "";

            foreach (string word in words)
            {
                string temp = FrenchToEsp(word) + " ";
                ToReturn += temp;
            }
            return ToReturn;
        }


        public static string FrenchToEsp(string Frenchword)
        {


            if (!FrToEsp.ContainsKey(Frenchword)) return Frenchword;
            else
            {
                return FrToEsp[Frenchword];
            }
        }
        private static readonly Dictionary<string, string> FrToEsp = new Dictionary<string, string>()
            {
            //She is a good girl word in plus
            //Elle est une fille
            //Ella es una niña 
            
                { "maison", "hogar" },
                { "avion", "avión" },
                { "Elle", "Ella" },
                { "elle", "ella" },
                { "est", "es" },
                { "une", "una" },
                { "fille", "niña" },
                { "bonne", "buena" },
               

            };
    }
}
