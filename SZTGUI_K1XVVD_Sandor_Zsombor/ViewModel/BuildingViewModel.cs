using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SZTGUI_K1XVVD_Sandor_Zsombor.Model;

namespace SZTGUI_K1XVVD_Sandor_Zsombor.ViewModel
{
    public class BuildingViewModel
    {
        public ObservableCollection<Player> FilteredPlayers { get; }
        public Player? SelectedPlayer { get; set; }

        public BuildingViewModel()
        {
            FilteredPlayers = new ObservableCollection<Player>();
        }
        public BuildingViewModel(IEnumerable<Player> allPlayers, string position, IEnumerable<int> alreadySelectedNumbers)
        {
            FilteredPlayers = new ObservableCollection<Player>(
                allPlayers
                    .Where(p => p.Position == position && !alreadySelectedNumbers.Contains(p.Number))
            );
        }
    }
}
