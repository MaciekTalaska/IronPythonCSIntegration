class simpleclass(object):
    """this is just a simple test class demonstarting decorators"""
    def __init__(self,id):
        self.id = id

    def instancemethod(self):
        return '[instance method] id: %s' % self.id

    @property
    def property(self):
        return '[property]'

    @staticmethod
    def staticmethod(argument):
        return '[staticmethod] argument: %s' % argument

    @classmethod
    def classmethod(cls, argument):
        return '[classmethod] argument: %s cls: %s' % (argument, cls)