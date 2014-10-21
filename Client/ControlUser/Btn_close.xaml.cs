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
    /// Logique d'interaction pour Btn_close.xaml : Changement d'images d'image pour le bouton , gère l'évennement click
    /// </summary>
    public partial class Btn_close : UserControl
    {
        public Btn_close()
        {
            InitializeComponent();
        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Background = this.FindResource("btn_close_clik") as ImageBrush;
            e.Handled = true;
        }

        private void Canvas_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Background = this.FindResource("btn_close_hover") as ImageBrush;
            e.Handled = true;
        }

        private void Canvas_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Background = this.FindResource("btn_close") as ImageBrush;
            e.Handled = true;
        }

        private void Canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.Background = this.FindResource("btn_close") as ImageBrush;
            e.Handled = true;
            Application.Current.Shutdown(0);
        }
    }
}
