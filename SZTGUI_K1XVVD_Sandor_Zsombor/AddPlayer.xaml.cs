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
using System.Windows.Shapes;
using SZTGUI_K1XVVD_Sandor_Zsombor.Model;
using SZTGUI_K1XVVD_Sandor_Zsombor.ViewModel;

namespace SZTGUI_K1XVVD_Sandor_Zsombor
{
    /// <summary>
    /// Interaction logic for AddPlayer.xaml
    /// </summary>
    public partial class AddPlayer : Window
    {
        public Player P { get; private set; }

        public AddPlayer()
        {
            InitializeComponent();
            this.DataContext = new AddPlayerViewModel();
        }

        private void Bt_ok(object sender, RoutedEventArgs e)
        {

            if (this.DataContext is AddPlayerViewModel addP)
            {
                this.P = addP.Player;
            }

            this.DialogResult = true;
        }

        private void Bt_cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
