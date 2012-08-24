using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FF.Analysis.Core.Docx;

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        /// <summary>
        /// Sample App Page Load 
        /// </summary>
        /// <document>
        ///     
        /// </document>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!this.IsPostBack)
            {
                
            }
        }
    }
}
