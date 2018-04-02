
using System;
using Autodesk.Maya.OpenMaya;
using Autodesk.Maya;
using WPFDccPlugin.Manager;
using WPFDccPlugin.View;

[assembly: ExtensionPlugin(typeof(WPFMayaPlugin.MayaPlugin), "Any")]

namespace WPFMayaPlugin
{
    public class MayaPluginManager
    {
        // Objects to keep around
        private MDockingStation _mI;
        private MainWindow _wnd;

        public void Create()
        {
            PluginManager.Instance.Playground = new MayaPlayground();
            // Create the window to dock
            _wnd = new MainWindow();
            _wnd.Closing += Onclosing;
        }

        public void Show()
        {
            _wnd.Show();
            // Extract the window handle of the window we want to dock
            var mWindowHandle = new System.Windows.Interop.WindowInteropHelper(_wnd).Handle;
            // Dock it in Maya using the docking station
            _mI = new MDockingStation(mWindowHandle, true,
                MDockingStation.BottomDock | MDockingStation.TopDock | MDockingStation.LeftDock |
                MDockingStation.RightDock, MDockingStation.LeftDock);
        }

        private void Onclosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            _wnd.Hide();
            _mI = null;
        }
    }

    // This class is instantiated by Maya once and kept alive for the duration of the session.
    public class MayaPlugin : IExtensionPlugin
    {
        bool IExtensionPlugin.InitializePlugin()
        {
            return true;
        }

        bool IExtensionPlugin.UninitializePlugin()
        {
            return true;
        }

        string IExtensionPlugin.GetMayaDotNetSdkBuildVersion()
        {
            String version = "201353";
            return version;
        }
    }
}
