using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFDccPlugin.Interface.Impl
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
    }
}
