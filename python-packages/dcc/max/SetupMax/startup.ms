------------------------------------------------------------------------------
-- copy me in %localappData%\Autodesk\3dsMax\2019 - 64bit\ENU\scripts\startup\
------------------------------------------------------------------------------

--root path to your plugin project
rootpath="D:/Dev/DccPlugin/"

python.ExecuteFile (rootpath+"python-packages/dcc/setup/path.py")
python.ExecuteFile (rootpath+"python-packages/dcc/max/initPlugin.py")