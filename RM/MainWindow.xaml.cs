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
            cacheGetal = Convert.ToInt32(cacheBlock.Text); //Kan ik ni ineens zeggen dat: cacheGetal = Convert.ToInt32(schermBlock.Text); ?
            schermBlock.Text = "";
            huidigGetal = "";
        }

        //button-eventhandlers der getalbuttons in een methode zetten met een Button als parameter

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text += 1.ToString();
            huidigGetal += "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text += 2.ToString();
            huidigGetal += "2";
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text += 3.ToString();
            huidigGetal += "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text += 4.ToString();
            huidigGetal += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text += 5.ToString();
            huidigGetal += "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text += 6.ToString();
            huidigGetal += "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text += 7.ToString();
            huidigGetal += "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text += 8.ToString();
            huidigGetal += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text += 9.ToString();
            huidigGetal += "9";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            schermBlock.Text += 0.ToString();
            huidigGetal += "0";
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            //alles resetten
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
            //hier som berekenen
        }

        private void aftrekButton_Click(object sender, RoutedEventArgs e)
        {
            OpOperatorknopGeklikt();
            //hier verschil berekenen
        }

        private void uitkomstButton_Click(object sender, RoutedEventArgs e)
        {
            som = Convert.ToInt32(huidigGetal) + cacheGetal;
            verschil = cacheGetal - Convert.ToInt32(huidigGetal);
            schermBlock.Text = null;
            cacheBlock.Text = null;

            //resultaat berekenen a.d.h.v. resultaat, optelButton_Click(sender, e) en aftrekButton_Click(sender, e)
            schermBlock.Text = Convert.ToString(som);
        }
    }
}
