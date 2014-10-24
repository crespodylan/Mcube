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
    /// Logique d'interaction pour TreeViewItem.xaml
    /// </summary>
    public partial class TreeViewItem : UserControl
    {
        public enum Type { DIRECTORY, FILE, VIDEO, MUSIC };

        private Type type;

        public TreeViewItem(Type type)
        {
            InitializeComponent();

            this.type = type;

            Init();
        }

        private void Init()
        {
            switch(this.type)
            {
                case Type.DIRECTORY:
                    //Background = this.FindResource("directory") as ImageBrush;
                    break;
                case Type.FILE:
                    Background = this.FindResource("file") as ImageBrush;
                    break;
                case Type.MUSIC:
                    //Background = this.FindResource("") as ImageBrush;
                    break;
                case Type.VIDEO:
                    //Background = this.FindResource("movie") as ImageBrush;
                    break;
            }
        }

    }
}
