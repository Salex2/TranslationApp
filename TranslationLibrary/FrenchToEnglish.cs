using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationLibrary
{
    class FrenchToEnglish
    {
        public static string FrancezaEngleza(string input)
        {

            string[] words = input.Split(new string[] { ".", " ", ":", ";", "-", "`", ",", "/" }, StringSplitOptions.None);
            string ToReturn = "";

            foreach (string word in words)
            {
                string temp = FrenchToEng(word) + " ";
                ToReturn += temp;
            }
            return ToReturn;
        }


        public static string FrenchToEng(string FrenchWord)
        {
            
            if (!FrToEng.ContainsKey(FrenchWord)) return FrenchWord;
            else
            {
                return FrToEng[FrenchWord];
            }
        }

        private static readonly Dictionary<string, string> FrToEng = new Dictionary<string, string>()
        {
               
                //She is a girl
                //Elle est une fille
                { "je", "I" },
                { "Je", "I" },
                { "heureux", "happy" },
                { "suis", "am" },
                { "être", "be" },
                { "à", "to" },
                { "de", "of" },
                { "et", "and" },
                { "une", "a" },
                { "dans", "in" },
                { "cette", "that" },
                { "elle", "she" },
                { "Elle", "She" },
                { "est", "is" },
                { "fille", "girl" },

        };
    }
}