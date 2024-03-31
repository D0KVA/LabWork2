using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace PW1Entity
{
    /// <summary>
    /// Логика взаимодействия для Z.xaml
    /// </summary>
    public partial class Z : Page
    {
        private PractikaPW1Entities context = new PractikaPW1Entities();
        public Z()
        {
            InitializeComponent();
            dg.ItemsSource = context.Zhanres.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Zhanres z = new Zhanres();
            z.NameZhanre = NZ.Text;
            z.DescriptionZhanre = OZ.Text;

            context.Zhanres.Add(z);

            context.SaveChanges();
            dg.ItemsSource = context.Zhanres.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                context.Zhanres.Remove(dg.SelectedItem as Zhanres);

                context.SaveChanges();
                dg.ItemsSource = context.Zhanres.ToList();
            }
            catch
            {
                
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
                try
                {
                    var selected = dg.SelectedItem as Zhanres;
                    selected.NameZhanre = NZ.Text;
                    selected.DescriptionZhanre = OZ.Text;

                    context.SaveChanges();
                    dg.ItemsSource = context.Zhanres.ToList();
                }
                catch
                {

                }
                

        }
        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dg.SelectedItem != null)
            {
                var selected = dg.SelectedItem as Zhanres;
                NZ.Text = selected.NameZhanre;
                OZ.Text = selected.DescriptionZhanre;
            }
        }
    }
}
