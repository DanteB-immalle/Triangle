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

namespace WpfApp6
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                Line Lijn = new Line();
                Lijn.X1 = 300;
                Lijn.Y1 = 50;
                Lijn.X2 = 100;
                Lijn.Y2 = 50;
                Lijn.Stroke = new SolidColorBrush(Colors.PeachPuff);
                MijnGrid.Children.Add(Lijn);

                Line Lijn1 = new Line();
                Lijn1.X1 = 300;
                Lijn1.Y1 = 50;
                Lijn1.X2 = 300;
                Lijn1.Y2 = 250;
                Lijn1.Stroke = new SolidColorBrush(Colors.PeachPuff);
                MijnGrid.Children.Add(Lijn1);

                Line Lijn2 = new Line();
                Lijn2.X1 = 300;
                Lijn2.Y1 = 250;
                Lijn2.X2 = 100;
                Lijn2.Y2 = 50;
                Lijn2.Stroke = new SolidColorBrush(Colors.PeachPuff);
                MijnGrid.Children.Add(Lijn2);
            }

        }
    }




