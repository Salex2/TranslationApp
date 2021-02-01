using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationLibrary
{
    public class TranslationApi
    {
        public static string Translate(string input, string fromLanguage, string toLanguage)
        {

            string output = "";

            if (fromLanguage == "English" && toLanguage == "French")
            {
             return  output = EnglishToFrench.EnglezaFranceza(input);
            }

            if (fromLanguage == "French" && toLanguage == "English")
            {
                return output = FrenchToEnglish.FrancezaEngleza(input);
            }

            if (fromLanguage == "English" && toLanguage == "Spanish")
            {
                return output = EnglishToSpanish.EnglezaSpaniola(input);
            }

            if (fromLanguage == "Spanish" && toLanguage == "English")
            {
                return output = SpanishToEnglish.SpaniolaEngleza(input);
            }

            if (fromLanguage == "French" && toLanguage == "Spanish")
            {
                return output = FrenchToSpanish.FrancezaSpaniola(input);
            }

            if (fromLanguage == "Spanish" && toLanguage == "French")
            {
                return output = SpanishToFrench.SpaniolaFranceza(input);
            }



            return output;


        }


    }
}
