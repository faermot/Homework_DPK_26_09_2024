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
using MaterialSkin;
using MaterialSkin.Controls;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string OneNumber, TwoNumber;

        private void TextBoxOne_TextChanged(object sender, TextChangedEventArgs e)
        {
            MainText.Text = "Римский калькулятор";
            MainText.Foreground = Brushes.Black;
            OneNumber = TextBoxOne.Text;
            switch (OneNumber)
            {
                case "1":
                    TextBoxTwo.Text = "I";
                    break;

                case "2":
                    TextBoxTwo.Text = "II";
                    break;

                case "3":
                    TextBoxTwo.Text = "III";
                    break;

                case "4":
                    TextBoxTwo.Text = "IV";
                    break;

                case "5":
                    TextBoxTwo.Text = "V";
                    break;

                case "6":
                    TextBoxTwo.Text = "VI";
                    break;

                case "7":
                    TextBoxTwo.Text = "VII";
                    break;

                case "8":
                    TextBoxTwo.Text = "VIII";
                    break;

                case "9":
                    TextBoxTwo.Text = "IX";
                    break;

                case "10":
                    TextBoxTwo.Text = "X";
                    break;

                case "11":
                    TextBoxTwo.Text = "XI";
                    break;

                case "12":
                    TextBoxTwo.Text = "XII";
                    break;

                case "13":
                    TextBoxTwo.Text = "XIII";
                    break;

                case "14":
                    TextBoxTwo.Text = "XIV";
                    break;

                case "15":
                    TextBoxTwo.Text = "XV";
                    break;

                default:
                    MainText.Text = "ERROR!";
                    MainText.Foreground = Brushes.Red;
                    break;
            }
        }

        private void TextBoxTwo_TextChanged(object sender, TextChangedEventArgs e)
        {
            MainText.Text = "Римский калькулятор";
            MainText.Foreground = Brushes.Black;
            TwoNumber = TextBoxTwo.Text;
            switch (TwoNumber)
            {
                case "I":
                    TextBoxOne.Text = "1";
                    break;

                case "II":
                    TextBoxOne.Text = "2";
                    break;

                case "III":
                    TextBoxOne.Text = "3";
                    break;

                case "IV":
                    TextBoxOne.Text = "4";
                    break;

                case "V":
                    TextBoxOne.Text = "5";
                    break;

                case "VI":
                    TextBoxOne.Text = "6";
                    break;

                case "VII":
                    TextBoxOne.Text = "7";
                    break;

                case "VIII":
                    TextBoxOne.Text = "8";
                    break;

                case "IX":
                    TextBoxOne.Text = "9";
                    break;

                case "X":
                    TextBoxOne.Text = "10";
                    break;

                case "XI":
                    TextBoxOne.Text = "11";
                    break;

                case "XII":
                    TextBoxOne.Text = "12";
                    break;

                case "XIII":
                    TextBoxOne.Text = "13";
                    break;

                case "XIV":
                    TextBoxOne.Text = "14";
                    break;

                case "XV":
                    TextBoxOne.Text = "15";
                    break;

                default:
                    MainText.Text = "ERROR!";
                    MainText.Foreground = Brushes.Red;
                    break;
            }
        }
    }
}
