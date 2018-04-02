namespace WPFDccPlugin.Interface.Impl
{
    public class DccPythonPlayground : IPlayground
    {
        public virtual void RunPythonCommand(string command) { }
        public void Test()
        {
            RunPythonCommand("import dccHelper.dccHelperBase as dcc; dcc.test()");
        }
    }
}
