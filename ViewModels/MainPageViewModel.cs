using System.ComponentModel;

namespace MauiApp01.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private int _blue;
        public int Blue
        {
            get => _blue;
            set
            {
                if (_blue != value)
                {
                    _blue = value;
                    MainBg = Color.FromRgb(Red, Green, Blue);   
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Blue"));
                }
            }
        }

        private int _red;
        public int Red
        {
            get => _red;
            set
            {
                if (_red != value)
                {
                    _red = value;
                    MainBg = Color.FromRgb(Red, Green, Blue);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Red"));
                }
            }
        }

        private int _green;
        public int Green
        {
            get => _green;
            set
            {
                if (_green != value)
                {
                    _green = value;
                    MainBg = Color.FromRgb(Red, Green, Blue);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Green"));
                }
            }
        }

        private Color _mainBg;
        public Color MainBg
        {
            get => _mainBg;
            set
            {
                if (_mainBg != value)
                {
                    _mainBg = value;
                    HexCode = _mainBg.ToHex();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MainBg"));
                }
            }
        }

        private string _hexCode;
        public string HexCode
        {
            get => _hexCode;
            set
            {
                if (_hexCode != value)
                {
                    _hexCode = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HexCode"));
                }
            }
        }
    }
}
