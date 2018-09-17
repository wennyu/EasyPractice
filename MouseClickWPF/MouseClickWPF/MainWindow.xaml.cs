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

namespace MouseClickWPF
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {

        int times = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick_Click(object sender, RoutedEventArgs e)
        {
            times++;
            LabelTimes.Content = $"已經點了…… {times} 次";
        }

        private void ButtonReset_Click(object sender, RoutedEventArgs e)
        {
            times = 0;
            LabelTimes.Content = $"已經點了…… {times} 次";
        }
    }
}
