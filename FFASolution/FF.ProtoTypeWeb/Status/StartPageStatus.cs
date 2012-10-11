using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FF.Analysis.Core.UI.Attributes;
using FF.ProtoTypeWeb.Entity;

namespace FF.ProtoTypeWeb.Status
{
    [StatusName("Start")]
    public enum StartStatus
    { 
        [LayoutType(LayoutType=typeof(StartEntity),IsDefault=true)]
        Default
    }
}