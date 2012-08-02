// -----------------------------------------------------------------------
// <copyright file="DocHelper.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace FF.Analysis.Core.Docx
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    using System.IO.Packaging;
    using System.Xml.Linq;
    using DocumentFormat.OpenXml.Packaging;
    using DocumentFormat.OpenXml;
    using DocumentFormat.OpenXml.Wordprocessing;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class DocHelper
    {
        /// <summary>
        /// Create New Default Docx
        /// Sample:Hello World
        /// </summary>
        /// <returns></returns>
        public static void Create(string saveAsFileName)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Create(saveAsFileName, WordprocessingDocumentType.Document))
            {
                // Add a new main document part. 
                package.AddMainDocumentPart();

                // Create the Document DOM. 
                package.MainDocumentPart.Document =
                  new Document(
                    new Body(
                      new Paragraph(
                        new Run(
                          new Text("Hello World!")))));

                // Save changes to the main document part. 
                package.MainDocumentPart.Document.Save();
            } 
            
        }

        public static void Create(string templateFileName,string saveAsFileName)
        {
            File.Copy(templateFileName, saveAsFileName);

            using (WordprocessingDocument package = WordprocessingDocument.Open(saveAsFileName, true))
            {
                Body body = package.MainDocumentPart.Document.Body;

                // Create the Document DOM. 
                Paragraph para = body.AppendChild(new Paragraph());
                Run run = para.AppendChild(new Run());
                run.AppendChild(new Text("Example Text"));
                // Close the handle explicitly.
                package.Close();
            } 
         }

        public static void Open(string openFileName)
        {
            using (WordprocessingDocument package = WordprocessingDocument.Open(openFileName, true))
            {
                Body body = package.MainDocumentPart.Document.Body;

                // Create the Document DOM. 
                Paragraph para = body.AppendChild(new Paragraph());
                Run run = para.AppendChild(new Run());
                run.AppendChild(new Text("Example Text"));
                // Close the handle explicitly.
                package.Close();
            } 
        }

        public static void Open(string openFileName,string saveAsFileName)
        {
            File.Copy(openFileName, saveAsFileName);

            using (WordprocessingDocument package = WordprocessingDocument.Open(saveAsFileName, true))
            {
                Body body = package.MainDocumentPart.Document.Body;

                // Create the Document DOM. 
                Paragraph para = body.AppendChild(new Paragraph());
                Run run = para.AppendChild(new Run());
                run.AppendChild(new Text("Example Text"));
                // Close the handle explicitly.
                package.Close();
            }
        }

    }
}
