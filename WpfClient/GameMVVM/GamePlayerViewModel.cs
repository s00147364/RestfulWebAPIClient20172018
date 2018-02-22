using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIAuthenticationClient;
using WpfClient.DAL;

namespace WpfClient.GameMVVM
{
    public class GamePlayerViewModel: INotifyPropertyChanged
    {
        
        public ObservableCollection<GameScoreObject> ScoreList { get; set; }
        IGameScore<GameScoreObject> context;
        public GamePlayerViewModel()
        {
            context = new GameScoreRepository();
            if(DesignerProperties.GetIsInDesignMode(
                new System.Windows.DependencyObject())) return;
            PlayerAuthentication.baseWebAddress = "http://localhost:50574/";
            //ScoreList = new ObservableCollection<GameScoreObject>( PlayerAuthentication.getScores(4, "Battle Call"));
            ScoreList = new ObservableCollection<GameScoreObject>(context.getGameScores(4, "Battle Call"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
