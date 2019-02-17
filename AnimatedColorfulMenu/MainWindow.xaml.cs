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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnimatedColorfulMenu
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenUni1_Click(object sender, RoutedEventArgs e)
        {
            if (Unit1.Height > 50)
            {
                ((Storyboard)this.Resources["HidesUni1"]).Begin(this);
            }
            else
            {
                ((Storyboard)this.Resources["opensUni1"]).Begin(this);
            }
        } // показ и скрытие unit 1

        private void Unit1Prac_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(new Units.Unit_1.Practice.Begin());
        }
    }
}
