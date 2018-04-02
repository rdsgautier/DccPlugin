import clr
import plateform

plugin = None
if plateform.DCCplateform == 'maya':
    # maya plugin manager
    clr.AddReference("WPFMayaPlugin.nll")
    from WPFMayaPlugin import MayaPluginManager
    plugin = MayaPluginManager()

if plateform.DCCplateform == 'max':
    # max plugin manager
    clr.AddReference("WPFMaxPlugin")
    from WPFMaxPlugin import MaxPluginManager
    plugin = MaxPluginManager()

# create
plugin.Create()
