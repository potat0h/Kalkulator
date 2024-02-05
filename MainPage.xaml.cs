using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace kalkulator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int rezultat;
        string currentConversionType = "dec";
        public MainPage()
        {
            this.InitializeComponent();
        }

        public void decConv()
        {
            textBlock1.Text = Convert.ToInt32(rezultat).ToString();
        }

        public void binConv()
        {
            int decimalnaVrijednost = Convert.ToInt32(rezultat);
            textBlock1.Text = Convert.ToString(decimalnaVrijednost, 2);
        }

        public void octConv()
        {
            int decimalnaVrijednost = Convert.ToInt32(rezultat);
            textBlock1.Text = Convert.ToString(decimalnaVrijednost, 8);
        }

        public void hexConv()
        {
            int decimalnaVrijednost = Convert.ToInt32(rezultat);
            textBlock1.Text = Convert.ToString(decimalnaVrijednost, 16);
        }

        public void updateResult()
        {
            switch (currentConversionType)
            {
                case "dec":
                    decConv();
                    break;
                case "bin":
                    binConv();
                    break;
                case "oct":
                    octConv();
                    break;
                case "hex":
                    hexConv();
                    break;
                default:
                    decConv();
                    break;
            }
        }


        //##########################################################################################################

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            int zbroj = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
            textBlock1.Text = zbroj.ToString();
            rezultat = zbroj;
            updateResult();
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            int razlika = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
            textBlock1.Text = razlika.ToString();
            rezultat = razlika;
            updateResult();
        }

        private void puta_Click(object sender, RoutedEventArgs e)
        {          
            int umnozak = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
            textBlock1.Text = umnozak.ToString();
            rezultat = umnozak;
            updateResult();
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            int kolicnik = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
            textBlock1.Text = kolicnik.ToString();
            rezultat = kolicnik;
            updateResult();
        }

        //###########################################################################################################

        private void dec_Checked(object sender, RoutedEventArgs e)
        {
            currentConversionType = "dec";
            decConv();
        }

        private void bin_Checked(object sender, RoutedEventArgs e)
        {
            currentConversionType = "bin";
            binConv();
        }

        private void oct_Checked(object sender, RoutedEventArgs e)
        {
            currentConversionType = "oct";
            octConv();
        }

        private void hex_Checked(object sender, RoutedEventArgs e)
        {
            currentConversionType = "hex";
            hexConv();
        }
    }
}
