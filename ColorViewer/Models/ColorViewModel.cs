using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ColorViewer.Models
{
    public class ColorViewModel : INotifyPropertyChanged
    {
        Color color;

        public Color Color
        {
            get { return color; }
            set
            {
                color = (Color)ColorConverter.ConvertFromString(value.ToString());
                OnPropertyChanged(nameof(Color));
                OnPropertyChanged(nameof(A));
                OnPropertyChanged(nameof(R));
                OnPropertyChanged(nameof(G));
                OnPropertyChanged(nameof(B));
            }
        }
        
        public byte A
        {
            get { return color.A; }
            set
            {
                color.A = value;
                OnPropertyChanged(nameof(A));
                OnPropertyChanged(nameof(Color));
            }
        }

        public byte R
        {
            get { return color.R; }
            set
            {
                color.R = value;
                OnPropertyChanged(nameof(R));
                OnPropertyChanged(nameof(Color));
            }
        }

        public byte G
        {
            get { return color.G; }
            set
            {
                color.G = value;
                OnPropertyChanged(nameof(G));
                OnPropertyChanged(nameof(Color));
            }
        }

        public byte B
        {
            get { return color.B; }
            set
            {
                color.B = value;
                OnPropertyChanged(nameof(B));
                OnPropertyChanged(nameof(Color));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public ColorViewModel()
        {
            color = Color.FromArgb(255,0,0,0);
        }
    }
}
