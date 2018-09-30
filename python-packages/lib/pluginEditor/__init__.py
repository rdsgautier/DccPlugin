import clr
import plateform

managedplugin = None
if plateform.DCCplateform == 'maya':
    # maya plugin manager
    clr.AddReference("WPFMayaPlugin.nll")
    from WPFMayaPlugin import MayaPluginManager
    managedplugin = MayaPluginManager()

if plateform.DCCplateform == 'max':
    # max plugin manager
    clr.AddReference("WPFMaxPlugin")
    from WPFMaxPlugin import MaxPluginManager
    managedplugin = MaxPluginManager()

# create
managedplugin.Create()
