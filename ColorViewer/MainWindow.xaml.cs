using ColorViewer.Models;
using MahApps.Metro.Controls;
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

namespace ColorViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            AppViewModel app = new AppViewModel();

            this.DataContext = app;

           // var color = (SolidColorBrush)(new BrushConverter().ConvertFrom("#ffaacc")); ;

            //MessageBox.Show(color.ToString());

            //col.Background = new SolidColorBrush(app.Colors[0].Color);
            //MessageBox.Show(col.Background.ToString());
        }
    }
}
