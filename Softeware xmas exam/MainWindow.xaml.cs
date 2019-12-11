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

namespace Softeware_xmas_exam
{

    // i spent to long trying to get the random stuff to work so the rest of the code is kind of crap.
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // list for all players.
        List<Player> allPlayers = new List<Player>();
        //list for players that are going to be moved from one list to the other.
        List<Player> selectedplayers = new List<Player>() ;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // counldnt get the random to work so done it this way to get the rest of the code working
            Player p1 = new Player("adam", "o'connor", Position.Defender, new DateTime(1989, 01, 01));
            Player p2 = new Player("Amelia", "O'Brien", Position.Defender, new DateTime(1989, 01, 01));
            Player p3 = new Player("emma", "Walsh", Position.Defender, new DateTime(1989, 01, 01));
            Player p4 = new Player("Grace", "O'Sullivan", Position.Defender, new DateTime(1989, 01, 01));
            Player p5 = new Player("Chole", "Fitzgerald", Position.Defender, new DateTime(1989, 01, 01));
            Player p6 = new Player("Mia", "Brennan", Position.Defender, new DateTime(1989, 01, 01));
            Player p7 = new Player("Noah", "o'connor", Position.Goalkeeper, new DateTime(1989, 01, 01));
            Player p8 = new Player("micheal", "o'connor", Position.Goalkeeper, new DateTime(1989, 01, 01));
            Player p9 = new Player("adam", "o'connor", Position.Midfilder, new DateTime(1989, 01, 01));
            Player p10 = new Player("adam", "o'connor", Position.Midfilder, new DateTime(1989, 01, 01));
            Player p11 = new Player("adam", "o'connor", Position.Midfilder, new DateTime(1989, 01, 01));
            Player p12 = new Player("adam", "o'connor", Position.Midfilder, new DateTime(1989, 01, 01));
            Player p13 = new Player("adam", "o'connor", Position.Midfilder, new DateTime(1989, 01, 01));
            Player p14 = new Player("adam", "o'connor", Position.Midfilder, new DateTime(1989, 01, 01));
            Player p15 = new Player("adam", "o'connor", Position.Defender, new DateTime(1989, 01, 01));
            Player p16 = new Player("adam", "o'connor", Position.Defender, new DateTime(1989, 01, 01));
            Player p17 = new Player("adam", "o'connor", Position.Defender, new DateTime(1989, 01, 01));
            Player p18= new Player("adam", "o'connor", Position.Defender, new DateTime(1989, 01, 01));
            // combo box contents
            cbxFormation.ItemsSource = new string[] { "4-4-2", "4-3-3", "4-5-1" };

            allPlayers.Add(p1);
            allPlayers.Add(p2);
            allPlayers.Add(p3);
            allPlayers.Add(p4);
            allPlayers.Add(p5);
            allPlayers.Add(p6);
            allPlayers.Add(p7);
            allPlayers.Add(p8);
            allPlayers.Add(p9);
            allPlayers.Add(p10);
            allPlayers.Add(p11);
            allPlayers.Add(p12);
            allPlayers.Add(p13);
            allPlayers.Add(p14);
            allPlayers.Add(p15);
            allPlayers.Add(p16);
            allPlayers.Add(p17);
            allPlayers.Add(p18);

            lbxPlayers.ItemsSource = allPlayers;





        }
        // runs when the add button is clicked.
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Player selectedplayer = lbxPlayers.SelectedItem as Player;

            // null check
            if(selectedplayer != null)
            {
                // moves an activity from the left listbox to  the right listox when the add 
                //( >> ) button is clicked and an activity is selected
                allPlayers.Remove(selectedplayer);
                selectedplayers.Add(selectedplayer);
                refreshLists();
            }
            else
            {
                MessageBox.Show("please select a player");
            }
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            Player selectedplayer = lbxselected.SelectedItem as Player;

            //null check
            if (selectedplayer != null)
            {
                allPlayers.Add(selectedplayer);
                selectedplayers.Remove(selectedplayer);
                // refresh list
                refreshLists();
            }
        }

        // method to refresh the lists.
        private void refreshLists()
        {

            lbxPlayers.ItemsSource = null;
            lbxPlayers.ItemsSource = allPlayers;

            lbxselected.ItemsSource = null;
            lbxselected.ItemsSource = selectedplayers;

        }

        
    }
}
