namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Reflection;

    class Program
    {
        int Run()
        {
            Reflex.Factory factory = new Reflex.Factory();
            List<Type> types = Reflex.Helper.GetSubclasses("Reflex.Models.Entity");

            foreach(Type type in types)
            {
                // Look for create method
                MethodInfo method = type.GetMethod("Find", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
                if (method != null)
                {
                    // object[] args = { "test" };
                    // Reflex.Models.Entity entity = method.Invoke(null, args) as Reflex.Models.Entity;
                    Console.WriteLine("Found {0}.{1}", type.Name, method.Name);
                }

                // Look for create method
                method = type.GetMethod("Create", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
                if (method != null)
                {
                    // object[] args = { "test" };
                    // Reflex.Models.Entity entity = method.Invoke(null, args) as Reflex.Models.Entity;
                    Console.WriteLine("Found {0}.{1}", type.Name, method.Name);
                }
            }

            return 0;
        }

        static int Main(string[] args)
        {
            Program app = new Program();
            return app.Run();
        }
    }
}
