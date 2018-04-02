import plugin

def Test():
    world = plugin.World()
    world.set('Hello')
    world.updateUI()
    return world.greet()

