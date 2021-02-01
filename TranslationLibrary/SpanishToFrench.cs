using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationLibrary
{
    class SpanishToFrench
    {
        public static string SpaniolaFranceza(string input)
        {

            string[] words = input.Split(new string[] { ".", " ", ":", ";", "-", "`", ",", "/" }, StringSplitOptions.None);
            string ToReturn = "";

            foreach (string word in words)
            {
                string temp = SpanishToFr(word) + " ";
                ToReturn += temp;
            }
            return ToReturn;
        }


        public static string SpanishToFr(string spanishWord)
        {


            if (!EspToFr.ContainsKey(spanishWord)) return spanishWord;
            else
            {
                return EspToFr[spanishWord];
            }
        }
        private static readonly Dictionary<string, string> EspToFr = new Dictionary<string, string>()
            {
                //She is a good girl word in plus
                //Elle est une fille
                //Ella es una niña

                { "Ella", "Elle" },
                { "ella", "elle" },
                { "es", "est" },
                { "una", "une" },
                { "niña", "fille" },
                { "buena", "bonne" },


            };
    }
}
