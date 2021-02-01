using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslationLibrary;

namespace MyTranslator.ViewModels
{
    public class TranslatorViewModel : Screen
    {

        public List<string> Language { get; } = new List<string>() { "English", "French", "Spanish" };


        private string _input ;
        public string Input
        {
            get { return _input; }
            set
            {
                NotifyOfPropertyChange(() => CanTranslate);
                _input = value;
            }
            
        }

        public string Output { get; set; }


        //what is selected in Fromlanguage is selected
        private string _selectedfromLanguage;
        public string SelectedFromLanguage
        {
            get { return _selectedfromLanguage; }
            set
            {
                
                _selectedfromLanguage = value;
                NotifyOfPropertyChange(() => SelectedFromLanguage);
                NotifyOfPropertyChange(() => CanTranslate);
            }
        }

        


        //what is selected in Tolanguage is selected
        private string _selectedtoLanguage;
        public string SelectedToLanguage
        {
            get { return _selectedtoLanguage; }
            set
            {
                NotifyOfPropertyChange(() => CanTranslate);
                NotifyOfPropertyChange(() => SelectedToLanguage);
                _selectedtoLanguage = value;
            }
        }


        //Clear text in both TextBoxes
        public void ClearText()
        {
            Input = "";
            Output = "";
            NotifyOfPropertyChange(() => CanTranslate);
            NotifyOfPropertyChange(() => Input);
            NotifyOfPropertyChange(() => Output);
        }

        //Check if languages are selected and input is not null
        public bool CanTranslate
        {
            get
            {
                bool output = false;

                if (!String.IsNullOrWhiteSpace(Input) && SelectedFromLanguage != null && SelectedToLanguage != null
                    && SelectedFromLanguage!=SelectedToLanguage)
                {
                    output = true;
                }
                return output;
            }
        }

        public void Translate()
        {
            Output = TranslationApi.Translate(Input, SelectedFromLanguage, SelectedToLanguage);
            NotifyOfPropertyChange(() => Output);
        }

        
      


    }
}
    