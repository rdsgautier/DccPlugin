
dcc = None
import plateform
if plateform.DCCplateform == 'maya':
    import dccHelperMaya as dcc
if plateform.DCCplateform == 'max':
    import dccHelperMax as dcc

def test() :
    return dcc.test()
