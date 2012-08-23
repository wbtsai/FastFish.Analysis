namespace FF.Analysis.Core.Docx.Attributes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
        
    /// <summary>
    /// Mapping to Docx Attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Property)]
    public class MapToAttribute:Attribute
    {
        /// <summary>
        /// Mapping Id
        /// </summary>
        public string MapId { get; set; }
    }
}
