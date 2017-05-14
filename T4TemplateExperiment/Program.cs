using System;
using System.Linq;
using System.Reflection;

namespace T4TemplateExperiment
{
    class Program
    {
        static void Main(string[] args)
        {
            //            var myClass = new MyClass0();
            //            myClass.Run();

            var assembly = Assembly.GetExecutingAssembly();
            foreach (var type in assembly.GetExportedTypes().Where(t => t.GetCustomAttributes(typeof(WooMeAttribute)).Any()))
            {
                Console.WriteLine("Found type to intercept: " + type.Name);
                foreach (var property in type.GetProperties())
                {
                    Console.WriteLine("Got property: " + property.Name);
                }
                foreach (var method in type.GetMethods().Where(m => !m.IsSpecialName))
                {
                    Console.WriteLine("Got method: " + method.Name);
                    foreach (var parameter in method.GetParameters())
                    {
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
