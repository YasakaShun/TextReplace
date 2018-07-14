using IronRuby;
using Microsoft.Scripting.Hosting;
using System.Windows;

namespace TextReplace
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ScriptEngine engine = Ruby.CreateEngine();
            engine.ExecuteFile("Test.rb");
        }
    }
}
