using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace AnimatedColorfulMenu.Units.Unit1.Practice
{
    /// <summary>
    /// Логика взаимодействия для Vocabulaty.xaml
    /// </summary>
    public partial class Vocabulaty : Page
    {
        SoundPlayer sp = new SoundPlayer();
        public Vocabulaty()
        {
            InitializeComponent();
        }
        string data = "";

       

        private void Words_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            if (words.SelectedIndex != -1)
            {
                sp.SoundLocation = data;
                sp.Load();
                sp.Play();
            }
            words.SelectedIndex = -1;
        }
    }
}
