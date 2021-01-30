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
            //to do a switch
            string output = "";
            if (fromLanguage == "English" && toLanguage == "French")
            {
              output = EnglishToFrench.EnglezaFranceza(input);
            }

            if (fromLanguage == "English" && toLanguage == "Spanish")
            {
                
            }

            if (fromLanguage == "French" && toLanguage == "English")
            {

            }

            if (fromLanguage == "French" && toLanguage == "Spanish")
            {

            }

            if (fromLanguage == "Spanish" && toLanguage == "English")
            {

            }

            if (fromLanguage == "Spanish" && toLanguage == "French")
            {

            }



            return output;
            

        }

        
    }
}
