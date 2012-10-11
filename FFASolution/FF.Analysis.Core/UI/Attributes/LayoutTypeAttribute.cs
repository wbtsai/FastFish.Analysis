using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF.Analysis.Core.UI.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class LayoutTypeAttribute:System.Attribute
    {
        public Type LayoutType { get; set; }

        public bool IsDefault { get; set; }
    }
}
