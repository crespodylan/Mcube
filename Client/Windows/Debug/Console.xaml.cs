using System;
using System.Threading;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace Client.Windows.Debug
{
    /// <summary>
    /// Logique d'interaction pour Console.xaml
    /// </summary>
    public partial class Console : Window
    {
        private static Console singleton = new Console();
        private static Semaphore verroux = new Semaphore(0,1);

        private Console()
        {
            InitializeComponent();
        }

        public static Console GetInstance()
        {
            return singleton;
        }

        public void Write(string text)
        {
            Paragraph p = new Paragraph();
            p.Inlines.Add(text);
            Out.Document.Blocks.Add(p);
        }

        public void WriteLine(string text)
        {
            Paragraph p = new Paragraph();
            p.Inlines.Add(text+Environment.NewLine);
            Out.Document.Blocks.Add(p);
        }
    }
}
