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

namespace Sakklepesek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Grid tabla;
        Rectangle[,] tablaMezok;
        public MainWindow()
        {
            InitializeComponent();
            Felulet();
            TablaFelulete();
        }

        private void Kijeloles(object sender, MouseButtonEventArgs e)
        {
            Rectangle jelenlegi = sender as Rectangle;
            int aktElsoKord = 0;
            int aktMasodikKord = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (tablaMezok[i, j].Equals(jelenlegi))
                    {
                        aktElsoKord = i;
                        aktMasodikKord = j;

                    }
                    tablaMezok[i, j].Fill = (i + j) % 2 == 0 ? Brushes.White : Brushes.Black;
                }
            }
            tablaMezok[aktElsoKord, aktMasodikKord].Fill = Brushes.Red;
            
            poz.Content = $"Az aktuális pozíció: [{aktElsoKord};{aktMasodikKord}]";

            

           
        }

        private void TablaFelulete()
        {
            tablaMezok = new Rectangle[10, 10];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tablaMezok[i, j] = new Rectangle();
                    tablaMezok[i, j].Stroke = Brushes.Black;
                    tablaMezok[i, j].Fill = (i + j) % 2 == 0 ? Brushes.White : Brushes.Black;
                    tabla.Children.Add(tablaMezok[i, j]);
                    Grid.SetColumn(tablaMezok[i, j], j);
                    Grid.SetRow(tablaMezok[i, j], i);
                    tablaMezok[i, j].MouseUp += Kijeloles;
                }
            }
            
        }

        private void Felulet()

        {

          
            
            babuk.Items.Add("Király");
            babuk.Items.Add("Királynő");
            babuk.Items.Add("Bástya");
            babuk.Items.Add("Futó");
            babuk.Items.Add("Huszár");
            babuk.Items.Add("Világos gyalog");
            babuk.Items.Add("Sötét gyalog");
            
           
            tabla = new Grid();
            for (int i = 0; i < 10; i++)
            {
                tabla.RowDefinitions.Add(new RowDefinition());
                tabla.ColumnDefinitions.Add(new ColumnDefinition());
            }
            ablak.Children.Add(tabla);
            tabla.Height = 600;
            tabla.Width = 600;
           
          
        }

    }
}
