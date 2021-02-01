using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationLibrary
{
    class SpanishToEnglish
    {
        public static string SpaniolaEngleza(string input)
        {

            string[] words = input.Split(new string[] { ".", " ", ":", ";", "-", "`", ",", "/" }, StringSplitOptions.None);
            string ToReturn = "";

            foreach (string word in words)
            {
                string temp = SpanishToEng(word) + " ";
                ToReturn += temp;
            }
            return ToReturn;
        }


        public static string SpanishToEng(string SpanishWord)
        {
            

            if (!EspToEng.ContainsKey(SpanishWord)) return SpanishWord;
            else
            {
                return EspToEng[SpanishWord];
            }
        }
        private static readonly Dictionary<string, string> EspToEng = new Dictionary<string, string>()
            {
                   
                //She is a girl
                //Ella es una niña

                { "Ella", "She" },
                { "ella", "she" },
                { "es", "is" },
                { "una", "a" },
                { "niña", "girl" },
                { "nina", "girl" },
                { "a", "to" },
                { "la", "the" },
                { "y", "and" },
                { "con", "with" },
                { "pero", "but" },
                { "aquí", "here" },
                { "todo", "everything" },
                { "ya", "already" },
                { "algo", "something" },
                { "tengo", "I have" },
                { "tú", "you" },
                { "tu", "you" },
                { "nada", "nothing" },
                { "gracias", "thank you" },
                { "bueno", "good" },
                { "Dios", "God" },
                { "nunca", "never" },
                { "dónde", "where" },
                { "donde", "where" },
            };

    }
}
