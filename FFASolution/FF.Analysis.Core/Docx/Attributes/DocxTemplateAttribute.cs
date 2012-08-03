using System;
using System.Collections.Generic;
using System.Text;

namespace FF.Analysis.Core.Docx.Attributes
{
    /// <summary>
    /// Doc Template Support
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class DocxTemplateAttribute:Attribute
    {
        /// <summary>
        /// Template ID
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// Template Name
        /// </summary>
        public string TemplateName { get; set; }

        /// <summary>
        /// Template Description
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// BeLong to Group
        /// </summary>
        public DocxGroup Group { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// Start Date
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// Is Enabled
        /// </summary>
        public bool IsEnable { get; set; }

        /// <summary>
        /// Is List Support
        /// </summary>
        public bool IsSupportList { get; set; }
    }
}
