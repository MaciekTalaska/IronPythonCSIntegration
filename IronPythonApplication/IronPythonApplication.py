import sys
import clr
clr.AddReference('System')
import System

def get_system_information():
    info = System.String(sys.version_info)
    return info

@property
def system_information():
    info = System.String(sys.version_info)
    return info

def echo(something):
    return something

if __name__=="__main__":
    print(get_system_information())
    print(system_information)
    System.Console.ReadLine()