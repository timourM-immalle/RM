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

        private void OpCijferknopGeklikt(int cijfer)
        {
            schermBlock.Text += cijfer.ToString();
            huidigGetal += cijfer.ToString();
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
            OpCijferknopGeklikt(1);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            OpCijferknopGeklikt(2);
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            OpCijferknopGeklikt(3);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            OpCijferknopGeklikt(4);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            OpCijferknopGeklikt(5);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            OpCijferknopGeklikt(6);
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            OpCijferknopGeklikt(7);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            OpCijferknopGeklikt(8);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            OpCijferknopGeklikt(9);
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            OpCijferknopGeklikt(0);
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
