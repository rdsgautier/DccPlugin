using Autodesk.Maya.OpenMaya;
using WPFDccPlugin.Interface.Impl;

namespace WPFMayaPlugin
{
    public class MayaPlayground : DccPythonPlayground
    {
        public override void RunPythonCommand(string command)
        {
           var status = MGlobal.executePythonCommandStringResult(command);
        }
    }
}
