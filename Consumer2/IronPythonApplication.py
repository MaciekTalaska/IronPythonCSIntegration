import sys
import clr
clr.AddReference('System')
import System

def show_sys_info():
    info = System.String('ala ma kota')
    return info
    

if __name__=="__main__":
    print(show_sys_info())
    System.Console.ReadLine()