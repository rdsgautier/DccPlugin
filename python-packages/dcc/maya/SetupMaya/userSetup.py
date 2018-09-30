#------------------------------------------------------------------------------
#-- copy me in C:\Users\%USERNAME%\Documents\maya\scripts
#------------------------------------------------------------------------------

import sys

# root path to your plugin project
dccpackagepath = "D:/Dev/DccPlugin/python-packages/dcc/"

sys.path.append(dccpackagepath+'setup')
import path

sys.path.append(dccpackagepath+'maya')
import startup