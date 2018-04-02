using WPFDccPlugin.ViewModel;

namespace WPFDccPlugin.View
{
    /// <summary>
    /// Interaction logic for MainUserControl.xaml
    /// </summary>
    public partial class MainUserControl
    {
        public MainUserControl()
        {
            DataContext = new MainUserControlViewModel();
            InitializeComponent();
        }
    }
}
