import clr
import plateform

plugin = None
if plateform.DCCplateform == 'maya':
    # maya plugin manager
    clr.AddReference("WPFMayaPlugin.nll")
    from WPFMayaPlugin import MayaPluginManager
    plugin = MayaPluginManager()

# create
plugin.Create()
