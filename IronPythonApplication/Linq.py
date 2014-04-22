import clr
clr.AddReference("System.Core")
import System
clr.ImportExtensions(System.Linq)

l = [i for i in range(10)]
#[2, 3, 4].Where(lambda x: x % 2 == 0).ToList().ForEach(System.Console.Write)
l.Where(lambda x: x % 2 == 0).ToList().ForEach(System.Console.Write)
System.Console.ReadLine()