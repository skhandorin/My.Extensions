using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Extensions.Samples.Demo5
{
    public static class TypeExtensions
    {
        public static TypeDescription GetDescription(this Type type)
        {
            return new TypeDescription
            {
                FullName = type.FullName,
                AssemblyQualifiedName = type.AssemblyQualifiedName
            };
        }
    }

    public class TypeDescription
    {
        public string FullName { get; set; }

        public string AssemblyQualifiedName { get; set; }
    }
}
