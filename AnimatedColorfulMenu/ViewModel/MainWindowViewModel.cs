using AnimatedColorfulMenu.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AnimatedColorfulMenu.MainViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        SoundPlayer sp = new SoundPlayer();

        Words selectedword;
        public ObservableCollection<Words>  Worlds { get; private set; }

        public Words SelectedWorld
        {
            get { return selectedword; }
            set
            {
                selectedword = value;
                checkSelectAudio(selectedword.Word,selectedword.Audio);
            }
        }

      

        public MainWindowViewModel()
        {
            Worlds = new ObservableCollection<Words>(Words.GetWords());
            
        }


        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
        void checkSelectAudio(string data,string audio){
            sp.SoundLocation = "Units/Unit1/Practice/Audio/"+data+".wav";
            sp.Load();
            sp.Play();
        }
    }
}
