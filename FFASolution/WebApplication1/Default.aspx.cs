﻿using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            //
            if (!this.IsPostBack)
            {
                //DocHelper.Create("c:\\temp\\template.docx","c:\\temp\\aaa-1.docx");
                List<SdtBlock> list = DocHelper.GetTemplateBlocks();

                int count = list.Count;

            }
        }
    }
}
