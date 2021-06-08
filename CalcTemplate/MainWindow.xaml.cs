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

namespace CalcTemplate
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();
            ClearLabels();
        }

        public void ClearLabels()
        {
            lblFirst.Content = "";
            lblSecond.Content = "";
            lblAction.Content = "";
            lblEqually.Content = "";
            lblResult.Content = "";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (lblAction.Content == "")
            {
                lblFirst.Content += Numbers.One();
            }
            else
            {
                lblSecond.Content += Numbers.One();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (lblAction.Content == "")
            {
                lblFirst.Content += Numbers.Two();
            }
            else
            {
                lblSecond.Content += Numbers.Two();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (lblAction.Content == "")
            {
                lblFirst.Content += Numbers.Three();
            }
            else
            {
                lblSecond.Content += Numbers.Three();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (lblAction.Content == "")
            {
                lblFirst.Content += Numbers.Four();
            }
            else
            {
                lblSecond.Content += Numbers.Four();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (lblAction.Content == "")
            {
                lblFirst.Content += Numbers.Five();
            }
            else
            {
                lblSecond.Content += Numbers.Five();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (lblAction.Content == "")
            {
                lblFirst.Content += Numbers.Six();
            }
            else
            {
                lblSecond.Content += Numbers.Six();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (lblAction.Content == "")
            {
                lblFirst.Content += Numbers.Seven();
            }
            else
            {
                lblSecond.Content += Numbers.Seven();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (lblAction.Content == "")
            {
                lblFirst.Content += Numbers.Eight();
            }
            else
            {
                lblSecond.Content += Numbers.Eight();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (lblAction.Content == "")
            {
                lblFirst.Content += Numbers.Nine();
            }
            else
            {
                lblSecond.Content += Numbers.Nine();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (lblAction.Content == "")
            {
                lblFirst.Content += Numbers.Zero();
            }
            else
            {
                lblSecond.Content += Numbers.Zero();
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearLabels();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            lblAction.Content = "+";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            lblAction.Content = "-";
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            lblAction.Content = "*";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            lblAction.Content = "/";
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            lblEqually.Content = "=";
           lblResult.Content =  Solution.Result(lblFirst.Content.ToString(), lblSecond.Content.ToString(), lblAction.Content.ToString());
        }
        public bool number1(bool first, bool second)
        {



            if ()
            {
                Application.Current.Shutdown();
                return true;
            }
            else
            {
                Application.Current.Shutdown();
                return false;
            }

        }
    }
}
