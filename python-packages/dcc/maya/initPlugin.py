import sys
import os

import maya.cmds as cmds
import maya.mel as mel

rootpath = "D:/Dev/DccPlugin/"

# windows environement path
boostpath= rootpath+"extern/boost_1_65_1/stage/VS2017/x64/lib/"
os.environ["PATH"] += os.pathsep + boostpath
dllpath = rootpath+"bin/"
os.environ["PATH"] += os.pathsep + dllpath

# python path
sys.path.append(dllpath)
sys.path.append(rootpath+"python-packages/lib")
sys.path.append(rootpath+"python-packages/pythonNet")

import plateform
plateform.DCCplateform = 'maya'
import pluginEditor.pluginWindow as window

def customMayaMenu() :
    gMainWindow = mel.eval('$temp1 = $gMainWindow')
    customMenu = cmds.menu(parent = gMainWindow, label = " Ronan ")
    pluginDcc = cmds.menuItem( parent = customMenu, label = "Open plugin", c = openPlugin)

def openPlugin(*args):
    window.show()

def create():
    cmds.loadPlugin( 'WPFMayaPlugin.nll' )
    return customMayaMenu()
