// -----------------------------------------------------------------------
// <copyright file="WikiExtension.cs" company="yuanta">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace FF.Analysis.Core.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using WikiPlex;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class WikiExtension
    {
        /// <summary>
        /// Render Wiki To Html
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string WikiRenderToHtml(this string text)
        {
            var engine = new WikiPlex.WikiEngine();
            string output = engine.Render(text);

            return output;
        }

        /// <summary>
        /// Render wiki text to docx
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string WikiRenderToDocx(this string text)
        {
            return string.Empty;
        }
    }
}
