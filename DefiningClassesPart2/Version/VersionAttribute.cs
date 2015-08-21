using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
                    AttributeTargets.Interface | AttributeTargets.Enum |
                    AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {
        public VersionAttribute(string version)
        {
            this.Version = version;
        }

        public string Version { get; private set; }

        public override string ToString()
        {
            return this.Version;
        }
    }
}
