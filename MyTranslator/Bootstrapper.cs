using Caliburn.Micro;
using MyTranslator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyTranslator
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            //instead of mainWindow launch TranslatorViewModel; override on startup to do that
            DisplayRootViewFor<TranslatorViewModel>();
        }
    }
}
