using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIAuthenticationClient;
using WpfClient.DAL;

namespace WpfClient.GameMVVM
{
    public class PlayerInfoViewModel
    {
        public PlayerProfile currentPlayer { get; set; }
        IPlayer<PlayerProfile> context;
        public PlayerInfoViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(
                        new System.Windows.DependencyObject())) return;

            //PlayerAuthentication.baseWebAddress = "http://localhost:50574/";
            context = new PlayerRepository();

            //if (PlayerAuthentication.login("http://localhost:50574/", "powell.paul@itsligo.ie", "itsPaul$1"))
            //{
            //    currentPlayer = PlayerAuthentication.getPlayerProfile();
            //}
            if (context.login("powell.paul@itsligo.ie", "itsPaul$1"))
                currentPlayer = context.getCurrentPlayer();
        }
    }
}
