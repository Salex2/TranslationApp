using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationLibrary
{
   
    class EnglishToFrench
    {
        //here i tried to use directly BaseTranslatioClass
       // public static string EnglezaFranceza(string input)
      //  {
       //     return BaseTranslation.LanguageToLanguage(input, EngToFr);
     //   }


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


        public static string EngToFrench(string EnglishWord)
        {
          
            
            if (!EngToFr.ContainsKey(EnglishWord)) return EnglishWord;
            else
            {
                return EngToFr[EnglishWord];
            }
        }

            private static readonly Dictionary<string, string> EngToFr = new Dictionary<string, string>()
            {
                //am gasit key "home"-> fac query pt franceza spaniola
                //She is a girl
                //Elle est une fille
                { "home", "maison" },
                { "plane", "avion" },
                { "i", "je" },
                { "happy", "heureux" },
                { "am", "suis" },
                { "be", "être" },
                { "to", "à" },
                { "of", "de" },
                { "and", "et" },
                { "a", "une" },
                { "in", "dans" },
                { "that", "cette" },
                { "She", "elle" },
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
                { "is", "est" },
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
                { "girl", "fille" },
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


