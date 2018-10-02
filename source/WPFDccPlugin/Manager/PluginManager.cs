using WPFDccPlugin.Interface;
using BaseViewModel = WPFDccPlugin.Interface.Impl.ViewModel;

namespace WPFDccPlugin.Manager
{
    public sealed class PluginManager : BaseViewModel
    {
        #region Singleton
        private static volatile PluginManager _instance;
        private static readonly object SyncRoot = new object();
        public static PluginManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (SyncRoot)
                    {
                        if (_instance == null)
                            _instance = new PluginManager();
                    }
                }
                return _instance;
            }
        }
        #endregion

        private PluginManager()
        {
            // here : objects to initate once
            UpdateUI("test");
        }

        public IPlayground Playground { get; set; }

        #region Test
        private string _name;
        public string Name
        {
            get { return _name; }
            internal set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        public void UpdateUI(string newName)
        {
            Name = newName;
        }
        #endregion
    }
}
