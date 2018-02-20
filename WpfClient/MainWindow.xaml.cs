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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WebAPIAuthenticationClient;

namespace WpfClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PlayerAuthentication.baseWebAddress = "http://localhost:50574/";
            IEnumerable<GameScoreObject> list = PlayerAuthentication.getScores(4, "Battle Call")as IEnumerable<GameScoreObject>;
            this.listBox.ItemsSource = list;
            
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
