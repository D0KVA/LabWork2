using LabPW1.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace LabPW1
{
    /// <summary>
    /// Логика взаимодействия для Games.xaml
    /// </summary>
    public partial class Games : Page
    {
        GamesTableAdapter games = new GamesTableAdapter();
        public Games()
        {
            InitializeComponent();
            dg_BD.ItemsSource = games.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                games.InsertG(NG.Text, int.Parse(Zid.Text));
                dg_BD.ItemsSource = games.GetData();
            }
            catch { }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                object id = (dg_BD.SelectedItem as DataRowView).Row[0];
                games.DeleteG(Convert.ToInt32(id));
                dg_BD.ItemsSource = games.GetData();
            }
            catch { }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (dg_BD.SelectedItem as DataRowView).Row[0];
            games.UpdateG(NG.Text, int.Parse(Zid.Text), Convert.ToInt32(id));
            dg_BD.ItemsSource = games.GetData();
        }
    }
}
