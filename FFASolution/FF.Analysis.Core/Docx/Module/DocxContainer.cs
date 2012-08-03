// -----------------------------------------------------------------------
// <copyright file="DocxContainer.cs" company="yuanta">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace FF.Analysis.Core.Docx.Module
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// This is a Container
    /// </summary>
    public abstract class DocxContainer
    {
        /// <summary>
        /// Write to Word Docx
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public abstract void WriteToDocx();
    }
}
