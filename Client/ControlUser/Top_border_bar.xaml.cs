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

namespace Client.ControlUser
{
    /// <summary>
    /// Logique d'interaction pour Top_border_bar.xaml
    /// </summary>
    public partial class Top_border_bar : UserControl
    {
        private bool mouseDown = false;
        private double iX = 0;
        private double iY = 0;

        public Top_border_bar()
        {
            InitializeComponent();
        }

        private void Top_border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mouseDown = true;
            iX = e.MouseDevice.GetPosition(null).X;
            iY = e.MouseDevice.GetPosition(null).Y;
        }

        private void Top_border_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mouseDown = false;
        }

        private void Top_border_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Application.Current.MainWindow.Top += (e.GetPosition(null).Y - iY);
                Application.Current.MainWindow.Left += (e.GetPosition(null).X - iX);
            }
        }

        private void Top_border_MouseLeave(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
