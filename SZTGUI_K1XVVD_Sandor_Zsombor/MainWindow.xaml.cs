using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SZTGUI_K1XVVD_Sandor_Zsombor.ViewModel;

namespace SZTGUI_K1XVVD_Sandor_Zsombor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        FieldViewModel fieldViewModel;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Bt_tmBuilding(object sender, RoutedEventArgs e)
        {
            Field field = new Field();

            field.ShowDialog();
        }


        private void Bt_exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}