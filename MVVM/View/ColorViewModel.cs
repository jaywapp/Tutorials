using mvvm.Model;
using Prism.Commands;
using Prism.Mvvm;
using System.Windows.Media;

namespace mvvm.View
{
    public class ColorViewModel : BindableBase
    {
        #region Internal Field
        private RGBColor _rgb;

        private byte _rValue;
        private byte _gValue;
        private byte _bValue;

        private string _colorText;
        private SolidColorBrush _color;
        #endregion

        #region Commands
        public DelegateCommand UpdateCommand { get; }
        #endregion

        #region Properties
        public byte RValue
        {
            get => _rValue;
            set
            {
                SetProperty(ref _rValue, value);
                Update();
            }
        }

        public byte GValue
        {
            get => _gValue;
            set
            {
                SetProperty(ref _gValue, value);
                Update();
            }
        }

        public byte BValue
        {
            get => _bValue;
            set
            {
                SetProperty(ref _bValue, value);
                Update();
            }
        }

        public string ColorText
        {
            get => _colorText;
            set => SetProperty(ref _colorText, value);
        }

        public SolidColorBrush Color
        {
            get => _color;
            set => SetProperty(ref _color, value);
        }
        #endregion

        #region Constructor
        public ColorViewModel()
        {
            _rgb = new RGBColor();

            UpdateCommand = new DelegateCommand(Update);
        }
        #endregion

        #region Functions
        private void Update()
        {
            _rgb.R = _rValue;
            _rgb.G = _gValue;
            _rgb.B = _bValue;

            var color = System.Windows.Media.Color.FromRgb(RValue, GValue, BValue);

            ColorText = color.ToString();
            Color = new SolidColorBrush(color);
        }
        #endregion
    }
}
