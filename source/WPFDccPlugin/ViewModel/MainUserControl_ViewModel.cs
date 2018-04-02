using WPFDccPlugin.Interface.Impl;
using WPFDccPlugin.Manager;
using BaseViewModel = WPFDccPlugin.Interface.Impl.ViewModel;

namespace WPFDccPlugin.ViewModel
{
    public class MainUserControlViewModel : BaseViewModel
    {
        public MainUserControlViewModel()
        {
            TestCommand = new SimpleCommand{ ExecuteDelegate = o =>Test() } ;
        }

        public SimpleCommand TestCommand { get; }
        private void Test()
        {
            PluginManager.Instance.Playground.Test();
        }
    }
}
