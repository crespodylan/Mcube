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
using System.IO;
using System.Windows.Shapes;

namespace Client.Windows
{
    /// <summary>
    /// Logique d'interaction pour Explorer.xaml
    /// </summary>
    public partial class Explorer : Grid
    {
        public Explorer()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            DirectoryInfo dir = new DirectoryInfo(documentPath);
            TreeViewItem item = new TreeViewItem() { Foreground = Brushes.White, Header ="root" };

            TreeView.Items.Add(item);
            fillTreeView(dir as FileSystemInfo,item);
        }

        private void fillTreeView(FileSystemInfo file, TreeViewItem item) 
        {
            if(Directory.Exists(file.FullName))
            {
                DirectoryInfo dir = new DirectoryInfo(file.FullName);
                TreeViewItem itemB = new TreeViewItem() { Foreground = Brushes.White, Header = file.Name };
                FileSystemInfo[] array = new FileSystemInfo[0];

                try { array = dir.GetFileSystemInfos(); }
                catch (Exception e) {  }

                item.Items.Add(itemB);
                foreach (FileSystemInfo fi in array)
	            {
                    fillTreeView(fi,item);
	            }
            }
            else
            {
                WrapPanel wrap = new WrapPanel();
                Canvas image = new Canvas();
                TextBlock text = new TextBlock() { Foreground = Brushes.White, Text = file.Name };
                
                image.Background = TreeView.FindResource("file") as ImageBrush;
                wrap.Children.Add(image);                
                wrap.Children.Add(text);
                item.Items.Add(wrap);
            }
        }
    }
}
