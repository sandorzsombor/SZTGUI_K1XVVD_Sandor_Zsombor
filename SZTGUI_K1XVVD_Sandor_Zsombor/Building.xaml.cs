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
    /// Interaction logic for Building.xaml
    /// </summary>
    public partial class Building : Window
    {
        public Player? SelectedPlayer { get; private set; }


        public Building(IEnumerable<Player> players, string position, IEnumerable<int> alreadySelectedNumbers)
        {
            InitializeComponent();
            DataContext = new BuildingViewModel(players, position, alreadySelectedNumbers);
        }

        private void Bt_ok(object sender, RoutedEventArgs e)
        {
            if (DataContext is BuildingViewModel vm && vm.SelectedPlayer != null)
            {
                SelectedPlayer = vm.SelectedPlayer;
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Válassz ki egy játékost!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Bt_cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
