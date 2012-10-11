using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF.Analysis.Core.UI.Attributes
{
    [AttributeUsage(AttributeTargets.Enum)]
    public class StatusNameAttribute:System.Attribute
    {
        public StatusNameAttribute(string name)
        {
            this.Name = name;
        }
        
        public string Name { get; set; }
                
    }
}
