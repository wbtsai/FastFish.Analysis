using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FF.Analysis.Core.UI;
using FF.Analysis.Core.UI.Attributes;
using FF.ProtoTypeWeb.Entity;
using FF.Analysis.Core.Extensions;

namespace FF.ProtoTypeWeb.UserControl
{
    /// <summary>
    /// Layout 
    /// </summary>
    public enum PTState
    {
        /// <summary>
        /// Start Page
        /// </summary>
        [LayoutType(LayoutType = typeof(StartEntity))]
        Start


    }

    public partial class PTUserControl : BaseUserControl
    {
                
    }
}