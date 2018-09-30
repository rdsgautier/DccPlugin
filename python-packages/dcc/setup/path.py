import sys
import os

# root path to your plugin project
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

