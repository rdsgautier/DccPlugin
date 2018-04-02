using System.Windows;
using WPFDccPlugin.Interface.Impl;
using WPFDccPlugin.Manager;
using WPFDccPlugin.View;

namespace WPFDccPluginTest
{
    /// <summary>
    /// Interaction logic for TestApp.xaml
    /// </summary>
    public partial class TestApp
    {
        void App_Startup(object sender, StartupEventArgs e)
        {
            MainWindow = new MainWindow();
            PluginManager.Instance.Playground = new GamePlayground();
            MainWindow.Show();
        }
    }
}
