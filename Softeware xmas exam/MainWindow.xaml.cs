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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


            // combo box contents
            cbxFormation.ItemsSource = new string[] { "4-4-2", "4-3-3", "4-5-1" };
            








        }
        static void Rng()
        {
            //random name gen
            string[] firstNames = {
                "Adam", "Amelia", "Ava", "Chloe", "Conor", "Daniel", "Emily",
                "Emma", "Grace", "Hannah", "Harry", "Jack", "James",
                "Lucy", "Luke", "Mia", "Michael", "Noah", "Sean", "Sophie"};


            string[] lastNames = {
                "Brennan", "Byrne", "Daly", "Doyle", "Dunne", "Fitzgerald", "Kavanagh",
                "Kelly", "Lynch", "McCarthy", "McDonagh", "Murphy", "Nolan", "O'Brien",
                "O'Connor", "O'Neill", "O'Reilly", "O'Sullivan", "Ryan", "Walsh"
            };

            Random rng = new Random();

            for (int i = 0; i < 20; i++)
            {

                int number = rng.Next(0, 20);
                string fname = firstNames[number];
                number = rng.Next(0, 20);
                string lname = lastNames[number];
            }
            

        }
        //method to create the players and add them to a list

        //private static void PlayerList()
        //{
        //    Player p1 = new Player()
        //    {
        //        FirstName =
        //    }


        //    List<Player> players = new List<Player>();
        //    players.Add();




        //}
        

    }
}
