using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AncertCrono
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            CronoView window = new CronoView();
            //CronoViewModel VM = new CronoViewModel();
            //window.DataContext = VM;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
        }
    }
}
        
    
