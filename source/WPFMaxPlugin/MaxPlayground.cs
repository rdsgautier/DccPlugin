using ManagedServices;
using WPFDccPlugin.Interface.Impl;

namespace WPFMaxPlugin
{
    public class MaxPlayground : DccPythonPlayground
    {
        public override void RunPythonCommand(string command)
        {
            var pythonCommand = "python.Execute " + command;
            MaxscriptSDK.ExecuteMaxscriptCommand(pythonCommand);
        }
    }
}

