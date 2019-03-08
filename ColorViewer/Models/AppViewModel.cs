using ColorViewer.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ColorViewer.Models
{
    public class AppViewModel : INotifyPropertyChanged
    {
        AppCommand addComm;
        public AppCommand AddComm
        {
            get
            {
                return addComm ?? (addComm = new AppCommand(o => { Colors.Add(new ColorViewModel()); }));
            }
        }

        AppCommand removeComm;
        public AppCommand RemoveComm
        {
            get
            {
                return removeComm ?? (removeComm = new AppCommand(o =>
                {
                    ColorViewModel curColor = o as ColorViewModel;
                    if (curColor != null)
                        Colors.Remove(curColor);
                }));
            }
        }

        public ObservableCollection<ColorViewModel> Colors { get; set; }

        ColorViewModel activeColor;

        public ColorViewModel ActiveColor
        {
            get { return activeColor; }
            set
            {
                activeColor = value;
                OnPropertyChanged(nameof(ActiveColor));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public AppViewModel()
        {
            Colors = new ObservableCollection<ColorViewModel> {
                new ColorViewModel(255, 255, 0, 0),
                new ColorViewModel(255, 0, 255, 0),
                new ColorViewModel(255, 0, 0, 255)
            };
        }
    }
}
