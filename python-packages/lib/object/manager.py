import cppplugin # pyd file containing interface on c++ code through boost python

def Test():
    ui = cppplugin.UITest()
    ui.set('Hello')
    ui.updateUI()
    return ui.greet()

