using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AncertCrono
{
    /// <summary>
    /// Lógica de interacción para CronoView.xaml
    /// </summary>
    public partial class CronoView : Window
    {
        Crono timer = null;

        public CronoView()
        {
            InitializeComponent();

            CronoViewModel VM = new CronoViewModel();
            DataContext = VM;

            //timer = new Crono();
        }

        private void btnCronoInicio_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as CronoViewModel).MyCrono.Start();

            //timer.Start();
        }

        private void btnCronoPausa_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as CronoViewModel).MyCrono.Stop();
        }

        private void btnCronoReset_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as CronoViewModel).MyCrono.Reset();

            //lblCrono.Content = @"00::00::00";
        }
    }
}
