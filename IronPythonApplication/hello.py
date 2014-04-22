#!/bin/env/python
import sys

def greet():
    print('Hello World from Python')

def versioninfo():
    print(sys.version_info)

if __name__=="__main__":
    greet()
    versioninfo()