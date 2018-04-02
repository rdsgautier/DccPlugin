
dcc = None
import plateform
if plateform.DCCplateform == 'maya':
    import dccHelperMaya as dcc

def test() :
    return dcc.test()
