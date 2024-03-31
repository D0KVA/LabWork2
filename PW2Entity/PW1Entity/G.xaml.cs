using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PW1Entity
{
    /// <summary>
    /// Логика взаимодействия для G.xaml
    /// </summary>
    public partial class G : Page
    {
        private PractikaPW1Entities context = new PractikaPW1Entities();
        public G()
        {
            InitializeComponent();
            dg.ItemsSource = context.Games.ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Games g = new Games();
                g.NameGame = NG.Text;
                g.Zhanre_ID = int.Parse(Zid.Text);

                context.Games.Add(g);

                context.SaveChanges();
                dg.ItemsSource = context.Games.ToList();
            }
            catch { }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                context.Games.Remove(dg.SelectedItem as Games);

                context.SaveChanges();
                dg.ItemsSource = context.Games.ToList();
            }
            catch
            {
                MessageBox.Show("Успешное удаление");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                var selected = dg.SelectedItem as Games;

                
                selected.NameGame = NG.Text;
                selected.Zhanre_ID = int.Parse(Zid.Text);

                context.SaveChanges();
                dg.ItemsSource = context.Games.ToList();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Нельзя пустоту изменить", ex.Message);
            }

        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dg.SelectedItem != null)
            {
                var selected = dg.SelectedItem as Games;
                NG.Text = selected.NameGame;
                Zid.Text = selected.Zhanre_ID.ToString();
            }
        }
    }
}
