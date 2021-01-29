using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTranslator.ViewModels
{
    public class TranslatorViewModel : Screen
    {
        public BindableCollection<String> Language { get; set; }

        public TranslatorViewModel()
        {
            Language = new BindableCollection<string>() { "English", "French", "Spanish" };
        }




        //what is selected in from language is selected
        private string _selectedfromLanguage;
        public string SelectedFromLanguage
        {
            get { return _selectedfromLanguage; }
            set
            {
                NotifyOfPropertyChange(() => SelectedFromLanguage);
                _selectedfromLanguage = value;
            }
        }
        //what is selected in to language is selected
        private string _selectedtoLanguage;
        public string SelectedToLanguage
        {
            get { return _selectedtoLanguage; }
            set
            {
                NotifyOfPropertyChange(() => SelectedFromLanguage);
                _selectedtoLanguage = value;
            }
        }


        public void Translate()
        {
            
        }

        public void Clear()
        {

        }


    }
}
    