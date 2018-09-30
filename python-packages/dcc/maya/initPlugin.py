import maya.cmds as cmds
import maya.mel as mel

import plateform
plateform.DCCplateform = 'maya'

import pluginEditor.pluginWindow as window

def customMayaMenu() :
    gMainWindow = mel.eval('$temp1 = $gMainWindow')
    customMenu = cmds.menu(parent = gMainWindow, label = " DccPlugin ")
    pluginDcc = cmds.menuItem( parent = customMenu, label = "Open plugin", c = openPlugin)

def openPlugin(*args):
    window.show()

def create():
    cmds.loadPlugin( 'WPFMayaPlugin.nll' )
    return customMayaMenu()
