namespace Reflex
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Reflection;

    public class Helper
    {
        /// <summary>
        /// Returns all types derived from specified base class
        /// </summary>
        /// <param name="base_type">Base class</param>
        /// <returns>Types derived from base class</returns>
        public static List<Type> GetSubclasses(string base_type)
        {
            Type base_class = Assembly.GetExecutingAssembly().GetType(base_type);
            var result = from t in Assembly.GetExecutingAssembly().GetTypes()
                    where t.IsClass && t.IsSubclassOf(base_class)
                    select t;

            return result.ToList();
        }
    }
}
