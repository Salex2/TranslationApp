using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationLibrary
{
    class Dictionaries
    {
        public static List<Dictionary<string, string>> ListaDictionare = new List<Dictionary<string, string>>();

        public static void ListOfAllDictioaries()
        {
            ListaDictionare.Add(EngToEsp);
            ListaDictionare.Add(EngToFr);
            ListaDictionare.Add(FrToEng);
            ListaDictionare.Add(FrToEsp);
            ListaDictionare.Add(EspToFr);
            ListaDictionare.Add(EspToEng);

        }

        private static readonly Dictionary<string, string> EngToEsp = new Dictionary<string, string>()
            {
                
                //She is a girl
                //Ella es una niña

                { "She", "Ella" },
                { "she", "ella" },
                { "is", "es" },
                { "a", "una" },
                { "girl", "niña" },
                { "to", "a" },
                { "the", "la" },
                { "and", "y" },
                { "with", "con" },
                { "but", "pero" },
                { "here", "aquí" },
                { "everything", "todo" },
                { "already", "ya" },
                { "something", "algo" },
                { "I have", "tengo" },
                { "you", "tú" },
                { "nothing", "nada" },
                { "good", "bueno" },
                { "God", "Dios" },
                { "never", "nunca" },
                { "where", "dónde" },
            };
        private static readonly Dictionary<string, string> EngToFr = new Dictionary<string, string>()
            {
               
                //She is a girl
                //Elle est une fille
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
