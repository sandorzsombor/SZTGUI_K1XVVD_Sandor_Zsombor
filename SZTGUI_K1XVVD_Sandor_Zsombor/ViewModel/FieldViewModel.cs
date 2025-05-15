using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SZTGUI_K1XVVD_Sandor_Zsombor.Model;

namespace SZTGUI_K1XVVD_Sandor_Zsombor.ViewModel
{
    public class FieldViewModel : INotifyPropertyChanged
    {

        private Player? selectedPlayer;
        public Player? SelectedPlayer
        {
            get => selectedPlayer;
            set
            {
                if (selectedPlayer != value)
                {
                    selectedPlayer = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<Player> Players { get; }

        public FieldViewModel()
        {
            Players = new ObservableCollection<Player>();

            Players.Add(new Player
            {
                Name = "zoli",
                Number = 1,
                Age = 20,
                Position = "GK"
            });

            Players.Add(new Player
            {
                Name = "ati",
                Number = 60,
                Age = 22,
                Position = "RB"
            });

            Players.Add(new Player
            {
                Name = "bence",
                Number = 12,
                Age = 27,
                Position = "LB"
            });

            Players.Add(new Player
            {
                Name = "sanyi",
                Number = 4,
                Age = 23,
                Position = "CB"
            });

            Players.Add(new Player
            {
                Name = "zsolti",
                Number = 6,
                Age = 31,
                Position = "CM"
            });

            Players.Add(new Player
            {
                Name = "áron",
                Number = 11,
                Age = 19,
                Position = "RW"
            });

            Players.Add(new Player
            {
                Name = "bazsi",
                Number = 7,
                Age = 35,
                Position = "LW"
            });

            Players.Add(new Player
            {
                Name = "zaza",
                Number = 9,
                Age = 25,
                Position = "ST"
            });
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool Add(Player player)
        {
            bool exists = Players.Any(p => p.Number == player.Number);

            if (exists)
            {
                MessageBox.Show(
                    $"Már létezik játékos ezzel a mezszámmal: {player.Number}",
                    "Hiba",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return false;
            }

            Players.Add(player);
            return true;
        }
    }
}
