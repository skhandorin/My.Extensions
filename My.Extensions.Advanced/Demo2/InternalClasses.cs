using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Extensions.Advanced.Demo2
{
    internal class Class1
    {
        public string GetString1()
        {
            return "a";
        }

        internal class Class2
        {
            internal string GetString2()
            {
                return "b";
            }

            private class Class3
            {
                private string GetString3()
                {
                    return "c";
                }
            }
        }
    }
}
