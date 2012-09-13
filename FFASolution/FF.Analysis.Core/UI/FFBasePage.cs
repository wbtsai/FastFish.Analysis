// -----------------------------------------------------------------------
// <copyright file="FFBasePage.cs" company="yuanta">
// 
// </copyright>
// -----------------------------------------------------------------------

namespace FF.Analysis.Core.UI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Web.UI;

    /// <summary>
    /// Prototype Base Page
    /// </summary>
    public class FFBasePage:Page
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            this.Page.EnableViewState = false;
        }
        /// <summary>
        /// Remove 
        /// </summary>
        /// <param name="writer"></param>
        protected override void Render(HtmlTextWriter writer)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            HtmlTextWriter hWriter = new HtmlTextWriter(sw);
            base.Render(hWriter);
            string html = sb.ToString();
            html = Regex.Replace(html, "<input[^>]*id=\"(__VIEWSTATE)\"[^>]*>", string.Empty, RegexOptions.IgnoreCase);
            writer.Write(html);
        }
    }
}
