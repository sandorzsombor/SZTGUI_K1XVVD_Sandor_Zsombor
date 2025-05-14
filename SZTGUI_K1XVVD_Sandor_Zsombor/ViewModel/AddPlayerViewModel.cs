using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SZTGUI_K1XVVD_Sandor_Zsombor.Model;

namespace SZTGUI_K1XVVD_Sandor_Zsombor.ViewModel
{
    internal class AddPlayerViewModel : INotifyPropertyChanged
    {
        public Player _player;

        public Player Player
        {
            get => _player;
            set
            {
                _player = value;
                OnPropertyChanged(nameof(Player));
            }
        }

        public AddPlayerViewModel()
        {
            Player = new Player();
        }

        public string Name
        {
            get => Player.Name;
            set
            {
                if (Player.Name != value)
                {
                    Player.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Position
        {
            get => Player.Position;
            set
            {
                if (Player.Position != value)
                {
                    Player.Position = value;
                    OnPropertyChanged(nameof(Position));
                }
            }
        }

        public int Age
        {
            get => Player.Age;
            set
            {
                if (Player.Age != value)
                {
                    Player.Age = value;
                    OnPropertyChanged(nameof(Age));
                }
            }
        }

        public int Number
        {
            get => Player.Number;
            set
            {
                if (Player.Number != value)
                {
                    Player.Number = value;
                    OnPropertyChanged(nameof(Number));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
