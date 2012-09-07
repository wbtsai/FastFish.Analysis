// -----------------------------------------------------------------------
// <copyright file="DocxRender.cs" company="yuanta">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace FF.Analysis.Core.WikiRender
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using WikiPlex.Formatting.Renderers;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class DocxRender:Renderer
    {
        protected override string PerformExpand(string scopeName, string input, Func<string, string> htmlEncode, Func<string, string> attributeEncode)
        {
            throw new NotImplementedException();
        }

        protected override ICollection<string> ScopeNames
        {
            get { return new[] {"Docx" }; }
        }
    }
}
