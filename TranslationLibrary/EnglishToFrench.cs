using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationLibrary
{
    //internal class accesible only in TranslationLibrary
    class EnglishToFrench
    {


        public static string EnglezaFranceza(string input)
        {

            string[] words = input.Split(new string[] { ".", " ", ":", ";", "-", "`", ",", "/" }, StringSplitOptions.None);
            string ToReturn = "";

            foreach (string word in words)
            {
                string temp = EngToFrench(word) + " ";
                ToReturn += temp;
            }
            return ToReturn;
        }


        private static string EngToFrench(string EngWord)
        {
            string key1 = EngWord;


            if (!EngToFr.ContainsKey(key1)) return EngWord;
            else
            {
                return EngToFr[key1];
            }
        }

        private static Dictionary<string, string> EngToFr = new Dictionary<string, string>()
            {
            //En
            //I am happy for them  
            //Je suis heureux pour eux
                { "i", "je" },
                { "happy", "heureux" },
                { "am", "suis" },
                { "be", "être" },
                { "to", "à" },
                { "of", "de" },
                { "and", "et" },
                 { "a", "un" },
                { "in", "dans" },
                { "that", "cette" },
                 { "have", "avoir" },
                { "has", "a" },
                { "I", "je" },
                 { "it", "il" },
                { "for", "pour" },
                { "not", "ne pas" },
                 { "on", "sur" },
                { "with", "avec" },
                { "he", "il" },
                { "as", "comme" },
                { "you", "tu" },
                { "do", "faire" },
                { "at", "à" },
                { "this", "cette" },
                { "but", "mais" },
                 { "his", "sa" },
                { "by", "par" },
                { "from", "du" },
                 { "they", "ils" },
                { "we", "nous" },
                { "say", "dire" },
                 { "her", "sa" },
                { "she", "elle" },
                { "or", "ou" },
                 { "an", "une" },
                { "will", "volonté" },
                { "my", "mon" },
                { "one", "une " },
                { "all", "tout" },
                { "would", "aurait" },
                { "there", "là" },
                { "their", "leur" },
                { "what", "quoi" },
                { "so", "donc" },
                { "up", "haut" },
                { "if", "si" },
                 { "who", "qui " },
                { "get", "obtenir " },
                { "wich", "qui" },
                 { "go", "aller" },
                { "me", "moi" },
                { "when", "quand" },
                 { "make", "faire" },
                { "can", "pouvez" },
                { "like", "comme" },
                { "time", "temps" },
                { "no", "non" },
                { "just", "juste" },
                { "him", "lui" },
                { "know", "savoir" },
                { "take", "prendre" },
                { "people", "gens" },
                { "into", "dans" },
                 { "year", "an" },
                { "your", "votre" },
                { "good", "bien" },
                 { "some", "certains" },
                { "could", "pourrait" },
                { "them", "eux" },
                 { "other", "autre" },
                { "than", "que" },
                { "now", "maintenant" },
                 { "look", "regardez" },
                { "only", "seulement" },
                { "come", "viens" },
                { "back", "arrière" },
                 { "also", "aussi " },
                { "think", "pense" },
                { "over", "grand" },
                 { "after", "apres" },
                { "how", "comment" },
                { "same", "même" },
                { "want", "voudrais" },
                 { "because", "car" },


        };
    }
}

