import MaxPlus

import plateform
plateform.DCCplateform = 'max'

import pluginEditor.pluginWindow as window

# menu actions
def openPlugin():
    window.show()
action = MaxPlus.ActionFactory.Create('Open plugin Action', 'Open plugin', openPlugin)

# create menus
def customMaxMenu(name):
    if not MaxPlus.MenuManager.MenuExists(name):
        mb = MaxPlus.MenuBuilder(name)
        mb.AddItem(action)
        menu = mb.Create(MaxPlus.MenuManager.GetMainMenu())
    else:
        print 'The menu ', name, ' already exists'

def main():
    print "Removing any previously left 'menu items'"
    MaxPlus.MenuManager.UnregisterMenu(u"DccPlugin")

    print "Creating a new menu"
    customMaxMenu(u"DccPlugin")

if __name__ == '__main__':
    main()
