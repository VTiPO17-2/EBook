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

namespace AnimatedColorfulMenu.Units.Unit_1.Practice
{
    /// <summary>
    /// Логика взаимодействия для Begin.xaml
    /// </summary>
    public partial class Begin : Page
    {
        SoundPlayer sp = new SoundPlayer();
        public Begin()
        {
            InitializeComponent();
            MainFrame.NavigationService.Navigate(new Units.Unit1.Practice.Vocabulaty());
        }

        private void TitleAudio_Click(object sender, RoutedEventArgs e)
        {
            sp.SoundLocation = "Units/Unit1/Practice/Audio/Title.wav";
            sp.Load();
            sp.Play();
        }
    }
}
