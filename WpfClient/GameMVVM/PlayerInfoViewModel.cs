using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIAuthenticationClient;

namespace WpfClient
{
    public class PlayerInfoViewModel
    {
        public PlayerProfile currentPlayer { get; set; }

        public PlayerInfoViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(
                        new System.Windows.DependencyObject())) return;

            PlayerAuthentication.baseWebAddress = "http://localhost:50574/";

            if (PlayerAuthentication.login("http://localhost:50574/", "powell.paul@itsligo.ie", "itsPaul$1"))
            {
                currentPlayer = PlayerAuthentication.getPlayerProfile();
            }

        }
    }
}
