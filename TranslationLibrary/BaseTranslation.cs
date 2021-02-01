using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationLibrary
{
      class BaseTranslation
      {

        private static readonly List<Dictionary<string, string>> _dictionaries = Dictionaries.ListaDictionare;


        public static string LanguageToLanguage(string input,Dictionary<string,string> dictionar)
        {
            
            
            
            string[] words = input.Split(new string[] { ".", " ", ":", ";", "-", "`", ",", "/" }, StringSplitOptions.None);
            string ToReturn = "";

            foreach (string word in words)
            {
                string temp = WordByWord(word,dictionar) + " ";
                ToReturn += temp;
            }

            return ToReturn;
        }


        private static string WordByWord(string Word,  Dictionary<string, string> dictionar)
        {

            if (!dictionar.ContainsKey(Word))
            {
                var found = "";//found the key in another dictionary !=dictionar
                var found1 = "";//return it
                foreach (var dictionary in _dictionaries)
                {
                     if (dictionary.ContainsKey(Word)) found=dictionary[Word];
                }
                return found;
            } 
            else
            {
                return dictionar[Word];
            }
        }

        

        
    }
}
