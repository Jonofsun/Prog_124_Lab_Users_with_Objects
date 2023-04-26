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

namespace Prog_124_Lab_Users_with_Objects
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<HeadPhones> HeadPhones = new List<HeadPhones>();
        public MainWindow()
        {
            InitializeComponent();
            TransmitionWired wired = new TransmitionWired("Wired");
            TransmitionWireless wireless = new TransmitionWireless("Wirless");
            HeadPhones headPhones1 = new HeadPhones("Beyerdynamic", "Open Back", "DT 1990 Pro", 42000, wired);
            HeadPhones headPhones2 = new HeadPhones("Beyerdynamic", "Closed Back", "DT 1770", 42000, wireless);

            lbDisplay.Items.Add(headPhones1);
            lbDisplay.Items.Add(headPhones2);

            lbDisplay.SelectionChanged += lbDisplay_SelectionChanged;
        }

        private void btnSubscribe_Click(object sender, RoutedEventArgs e)
        {
            string userFName = txtFirstName.Text;
            string userLName = txtLastName.Text;
            bool wired = rbWired.IsChecked.Value;
            bool wireless = rbWireless.IsChecked.Value;
            if (wired)
            {
                MessageBox.Show($"{userFName} {userLName} - {HeadPhones.ToString()}");
            }
            else if (wireless)
            {
                MessageBox.Show($"{userFName} {userLName} - {HeadPhones.ToString()}");
            }
            
        }

        private void btnUnsub_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("See you later");
        }

        private void lbDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbDisplay.Items.Clear();
            HeadPhones selectedHeadphone = (HeadPhones)lbDisplay.SelectedItem;

            foreach (var headphone in lbDisplay.Items)
            {
                lbDisplay.Items.Add(headphone.ToString());
            }
        }
    }
}
