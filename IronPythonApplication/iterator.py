def simpleiterator():
    yield 2
    yield 4
    yield 6

for element in simpleiterator():
    print('iterator returned: %d' % element)
input("press enter to continue")
