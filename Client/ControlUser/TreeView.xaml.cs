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
using System.IO;
using Services;

namespace Client.ControlUser
{
    /// <summary>
    /// Logique d'interaction pour TreeView.xaml
    /// </summary>
    public sealed partial class TreeView : UserControl
    {
        private string _path;
        public String Path
        {
            get { return this._path; }
            set
            {
                if (!Directory.Exists(value))
                    Log.getInstance().error("Path is not a directory",new ArgumentException());
                else
                    this._path = value;
            }
        }

        private TreeView()
        {
            InitializeComponent();
        }

        public TreeView(String path)
        {
            InitializeComponent();
            this.Path = path;
        }

        private void Load(String path)
        {
            this.Path = path;
            if(String.IsNullOrEmpty(this.Path))
            {
                Log.getInstance().error("Path is not a directory", new ArgumentException());
            }
            else
            {
                
            }
        }
    }
}
