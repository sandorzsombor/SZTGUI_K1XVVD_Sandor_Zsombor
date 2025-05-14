using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
using SZTGUI_K1XVVD_Sandor_Zsombor.ViewModel;
using SZTGUI_K1XVVD_Sandor_Zsombor.Model;
    

namespace SZTGUI_K1XVVD_Sandor_Zsombor
{
    /// <summary>
    /// Interaction logic for Field.xaml
    /// </summary>
    public partial class Field : Window
    {
        FieldViewModel viewModel;
        private Dictionary<Button, Player> buttonPlayerMap = new Dictionary<Button, Player>();

        public Field()
        {
            InitializeComponent();
            this.viewModel = this.DataContext as FieldViewModel;
        }

        private void Bt_add(object sender, RoutedEventArgs e)
        {
            AddPlayer addPlayer = new AddPlayer();

            if (addPlayer.ShowDialog() == true)
            {
                if (addPlayer.DataContext is AddPlayerViewModel addP)
                {
                    Player newPlayer = addP.Player;
                    this.viewModel.Add(newPlayer);
                }
            }
        }

        private void Bt_filter(object sender, RoutedEventArgs e)
        {
            
        }

        private void PositionButton_RightClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button button)
            {

                // Ha volt hozzárendelt játékos ehhez a gombhoz
                if (buttonPlayerMap.ContainsKey(button))
                {
                    buttonPlayerMap.Remove(button);
                    button.Content = button.Tag?.ToString() ?? "Válassz"; // Alap szöveg visszaállítás
                }
            }
        }

        private void Bt_remove(object sender, RoutedEventArgs e)
        {
            viewModel.Players.Remove(viewModel.SelectedPlayer);
        }

        private void Bt_exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
