using WPFDccPlugin.Manager;
using WPFDccPlugin.View;
using ManagedServices;

namespace WPFMaxPlugin
{
    public class MaxPluginManager
    {
        // Objects to keep around
        private MainWindow _wnd;

        public void Create()
        {
            PluginManager.Instance.Playground = new MaxPlayground();
            // Create the window to dock
            _wnd = new MainWindow();
            _wnd.Closing += Onclosing;
        }

        public void Show()
        {
            // Create an interop helper
            System.Windows.Interop.WindowInteropHelper windowHandle =
            new System.Windows.Interop.WindowInteropHelper(_wnd);

            // Assign the 3ds Max HWnd handle to the interop helper
            windowHandle.Owner = AppSDK.GetMaxHWND();

            // Setup 3ds Max to handle the WPF correctly
            AppSDK.ConfigureWindowForMax(_wnd);

            _wnd.Show();
        }

        private void Onclosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            _wnd.Hide();
        }
    }
    
}
