using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimatedColorfulMenu.Model
{
    class Words : INotifyPropertyChanged
    {
        string word;
        string translateword;
        string audio;
        
         public string Word
        {
            get { return word; }
            set
            {
                word = value;
                OnPropertyChanged("Word");
            }
        }
        public string TranslateWord
        {
            get { return translateword; }
            set
            {
                translateword = value;
                OnPropertyChanged("TranslateWord");
            }
        }

        public string Audio
        {
            get { return audio; }
            set
            {
                audio = value;
                OnPropertyChanged("Audio");
            }
        }

        public static Words[] GetWords()
        {
            var result = new[]
            {
                new Words() {Word="Tenderness", TranslateWord="Нежность", Audio="Units/Unit1/Practice/Audio/Tenderness.wav"},
                new Words() {Word="Indifference", TranslateWord="Безразличие",Audio="Units/Unit1/Practice/Audio/Tenderness.wav"},
                //new Words() {Word="Selfishness", TranslateWord="Эгоизм",Audio="Units/Unit1/Practice/Audio/Tenderness.wav"},
                new Words() {Word="Rudeness", TranslateWord="Грубость"},
                new Words() {Word="Hypocrisy", TranslateWord="Лицемерие"},
                new Words() {Word="Insincerity", TranslateWord="Неискренность"},
                new Words() {Word="attention", TranslateWord="внимание"},
                new Words() {Word="Warm-heartedness", TranslateWord="душевная теплота"},
                new Words() {Word="Patience", TranslateWord="Терпение "},
                new Words() {Word="Unfriendliness", TranslateWord="Недружелюбие "},
                new Words() {Word="Respect", TranslateWord="Уважать "},
                new Words() {Word="Love", TranslateWord="Любовь"},
                new Words() {Word="Understanding", TranslateWord="Понимание "},
                new Words() {Word="surname", TranslateWord="фамилия"},
                new Words() {Word="to be born", TranslateWord="родиться"},
                new Words() {Word="well-built", TranslateWord="хорошо сложенный"},
                new Words() {Word="pleasant-looking", TranslateWord="приятный"},
                new Words() {Word="energetic", TranslateWord="энергичный"},
                new Words() {Word="talkative", TranslateWord="talkative"},
                new Words() {Word="look after", TranslateWord="присматривать"},
                new Words() {Word="to play hide-and-seek", TranslateWord="играть в прятки"},
                new Words() {Word="relatives", TranslateWord="родственники"},
                new Words() {Word="admit", TranslateWord="признавать"},
                new Words() {Word="apologize", TranslateWord="извиняться"},
                new Words() {Word="appreciate", TranslateWord="ценить"},
                new Words() {Word="wake", TranslateWord="будить"},
                new Words() {Word="beauty", TranslateWord="красавица"},
                new Words() {Word="calm", TranslateWord="спокойный"},
                new Words() {Word="crazy", TranslateWord="сильно увлечённый чем-то"},
                new Words() {Word="equestrian", TranslateWord="конный"},
                new Words() {Word="even-tempered", TranslateWord="уравновешенный"},
                new Words() {Word="faithful", TranslateWord="верный преданный"},
                new Words() {Word="fate", TranslateWord="судьба"},
                new Words() {Word="frank", TranslateWord="искренний"},
                new Words() {Word="hard-working", TranslateWord="трудолюбивый"},
                new Words() {Word="hot-tempered", TranslateWord="вспыльчивый"},
                new Words() {Word="influence", TranslateWord="влиять"},
                new Words() {Word="lose one’s temper", TranslateWord="выходить из себя"},
                new Words() {Word="modest", TranslateWord="скромный"},
                new Words() {Word="overcrowded", TranslateWord="переполненный"},
                new Words() {Word="partially", TranslateWord="частично"},
                new Words() {Word="persistent", TranslateWord="настойчивый"},
                new Words() {Word="reserved", TranslateWord="сдержанный"},
                new Words() {Word="retire into smb’s shell", TranslateWord="уйти в себя"},
                new Words() {Word="serious", TranslateWord="серьёзный"},
                new Words() {Word="sincere", TranslateWord="искренний"},
                new Words() {Word="slim", TranslateWord="стройный"},
                new Words() {Word="stand up to smth", TranslateWord="выдержать"},
                new Words() {Word="stubborn", TranslateWord="упрямый"},
                new Words() {Word="tolerant", TranslateWord="терпимый"},
                new Words() {Word="wise", TranslateWord="мудрый"},
                new Words() {Word="witty", TranslateWord="остроумный"},
                new Words() {Word="zodiac sign", TranslateWord="знак зодиака"},
                new Words() {Word="ambitious", TranslateWord="честолюбивый"},
                new Words() {Word="Aries", TranslateWord="Овен"},
                new Words() {Word="Taurus", TranslateWord="Телец"},
                new Words() {Word="Gemini", TranslateWord="Близнецы"},
                new Words() {Word="Cancer", TranslateWord="Рак"},
                new Words() {Word="Leo", TranslateWord="Лев"},
                new Words() {Word="Virgo", TranslateWord="Дева"},
                new Words() {Word="Libra", TranslateWord="Весы"},
                new Words() {Word="Scorpio", TranslateWord="Скорпион"},
                new Words() {Word="Sagittarius", TranslateWord="Стрелец"},
                new Words() {Word="Capricorn", TranslateWord="Козерог"},
                new Words() {Word="Aquarius", TranslateWord="Водолей"},
                new Words() {Word="Pisces", TranslateWord="Рыбы"},

            };
            return result;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string PorpertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PorpertyName));
            }
        }
       
    }
}
