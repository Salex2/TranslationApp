using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationLibrary
{
    class EnglishToSpanish
    {
        
        public static string EnglezaSpaniola(string input)
        {

            string[] words = input.Split(new string[] { ".", " ", ":", ";", "`", "," }, StringSplitOptions.None);
            string ToReturn = "";

            foreach (string word in words)
            {
                string temp = EngToSpanish(word) + " ";
                ToReturn += temp;
            }
            return ToReturn;
        }


        public static string EngToSpanish(string EngWord)
        {
           
            //nu am gasit cuvantul in dictionarul ENGtoEsp
            if (!EngToEsp.ContainsKey(EngWord))
            {
                string found2 = EngWord;
                //il caut in dictionarul eng franceza
                string found = EnglishToFrench.EngToFrench(EngWord);

               // if (found != EngWord) FrenchToSpanish.FrancezaSpaniola(found);

                if (FrenchToSpanish.FrancezaSpaniola(found) != found)
                
                    found2 = FrenchToSpanish.FrancezaSpaniola(found);
                    return found2;
            }
            else
            {
                return EngToEsp[EngWord];
            }
           
            



        }
        //ENGLEZA SPANIOLA NU GASESTE
        //ENGLEZA FRANCEZA GASESTE
        //FRANCEZA SPANIOLA SI RETURNEZ
        


            private static readonly Dictionary<string, string> EngToEsp = new Dictionary<string, string>()
            {
                //home word is missing from engToEsp; i need to query englishToFrench
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

       
    }
}
