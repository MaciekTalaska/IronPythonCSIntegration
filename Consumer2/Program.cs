using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace Consumer2
{
    class Program
    {
        static void Main(string[] args)
        {
            //CallPythonScript();

            CallPythonCode();

            System.Console.ReadLine();
        }

        public static void CallPythonScript()
        {
            var ipy = Python.CreateRuntime();
            dynamic test = ipy.UseFile("..\\..\\..\\IronPythonApplication\\IronPythonApplication.py");
            System.Console.WriteLine(test.get_system_information());
            System.Console.WriteLine(test.system_information);
            System.Console.WriteLine(test.echo("IronPython test"));
        }

        public static void CallPythonCode()
        {
            string scriptPath = "..\\..\\..\\IronPythonApplication\\simpleclass.py";
            ScriptEngine engine = Python.CreateEngine();
            engine.SetSearchPaths(new string[] {"C:\\IronPython\\Lib"});
            ScriptSource source = engine.CreateScriptSourceFromFile(scriptPath);
            ScriptScope scope = engine.CreateScope();
            ObjectOperations op = engine.Operations;
            source.Execute(scope);

            dynamic simpleclass = scope.GetVariable("simpleclass");
            dynamic pythonclass = simpleclass("FromC#ToPython");
            
            // calling instance method of Python class
            System.Console.WriteLine(pythonclass.instancemethod());
            
            // calling property of Python class
            System.Console.WriteLine(pythonclass.property);

            // calling Python's static method
            System.Console.WriteLine(pythonclass.staticmethod("instance.staticmethod"));

            // calling Python's class method
            System.Console.WriteLine(pythonclass.classmethod("instance.classmethod"));

            // calling Python's class method
            System.Console.WriteLine(simpleclass.staticmethod("class.staticmethod"));

            // calling Python's class method
            System.Console.WriteLine(simpleclass.classmethod("class.classmethod"));


        }
    }
}
