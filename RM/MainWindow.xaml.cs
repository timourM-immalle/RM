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
using System.Windows.Controls;
using System.Windows.Input;

namespace RM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string huidigGetal = "";
        private int som = 0;
        private int cacheGetal = 0;
        private int verschil = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpOperatorknopGeklikt()
        {
            cacheBlock.Text = schermBlock.Text;
            cacheGetal = Convert.ToInt32(cacheBlock.Text); //kan ik ni ineens zeggen dat: cacheGetal = Convert.ToInt32(cacheblock.Text); ?
            schermBlock.Text = ""; //Wrm nu ook al weer?
            huidigGetal = "";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text += Convert.ToString(1);
            huidigGetal += "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text += Convert.ToString(2);
            huidigGetal += "2";
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text += Convert.ToString(3);
            huidigGetal += "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text += Convert.ToString(4);
            huidigGetal += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text += Convert.ToString(5);
            huidigGetal += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text += Convert.ToString(6);
            huidigGetal += "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text += Convert.ToString(7);
            huidigGetal += "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text += Convert.ToString(8);
            huidigGetal += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text += Convert.ToString(9);
            huidigGetal += "9";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text += Convert.ToString(0);
            huidigGetal += "0";
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text = null;
            huidigGetal = "";
            cacheBlock.Text = null;
            som = 0;
            verschil = 0;
            cacheGetal = 0;
        }

        private void optelButton_Click(object sender, RoutedEventArgs e)
        {
            OpOperatorknopGeklikt();
        }

        private void aftrekButton_Click(object sender, RoutedEventArgs e)
        {
            OpOperatorknopGeklikt();
        }

        private void uitkomstButton_Click(object sender, RoutedEventArgs e)
        {
            som = Convert.ToInt32(huidigGetal) + cacheGetal;
            verschil = cacheGetal - Convert.ToInt32(huidigGetal);
            schermBlock.Text = null;
            cacheBlock.Text = null;

            //als er op optelButton werd geklikt, berekent het de som, anders het verschil
            schermBlock.Text = Convert.ToString(som);
        }
    }
}
