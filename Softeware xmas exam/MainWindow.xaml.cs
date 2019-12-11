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










        }
        private void Rng()
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
                string Fname = firstNames[number];
                number = rng.Next(0, 20);
                string Lname = lastNames[number];
            }
            // random date gen
            Random randNum = new Random();

            DateTime minDt = new DateTime(1989, 12, 1, 11, 0, 0);
            DateTime maxDt = new DateTime(1999, 12, 1, 11, 0, 0);
            List<DateTime> myDates = new List<DateTime>();
            
            int minutesDiff = Convert.ToInt32(maxDt.Subtract(minDt).TotalMinutes + 1);

            for (int i = 0; i < 100; i++)
            {
                
                int r = randNum.Next(1, minutesDiff);
                myDates.Add(minDt.AddMinutes(r));
            }

            foreach (DateTime d in myDates)
            {
                Console.WriteLine(string.Format("{0:dd-MMM-yyyy hh:mm}", d));
            }

        }
    }
}
