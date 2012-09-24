// -----------------------------------------------------------------------
// <copyright file="DocConfig.cs" company="yuanta">
// This is a mapping document for config.xml
// </copyright>
// -----------------------------------------------------------------------

namespace FF.Analysis.Core.Docx.Xml
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;

    /// <summary>
    /// Xml Root
    /// 
    /// </summary>
    /// <example>
    ///  <![CDATA[
    /// <FFADoc>
    ///     <!-- Word Tempalte File Path(include docx,image and others) -->
    ///     <TemplatePath>path0;path5</TemplatePath>
    ///     <!-- implement dll File Path ,support multi file path-->
    ///     <DllPath>path1;path2</DllPath>
    ///     <!-- output file folder(fullpath)-->
    ///     <OutputPath>path3</OutputPath>
    ///     <Documents>
    ///         <Document FileName="XXX.docx" TemplateName="XXX.docx" Copy="2" AddWaterMark="Y" PrintType="ALL">
    ///             <Requirement Show="Y">
    ///             <Dir Show="Y"  /> 
    ///             <ChangLog Show="Y" />
    ///             <Header Show="Y" />
    ///             <Section Seq="1" MapTo="Fany" ShowComponentApi="Y" />
    ///             <DBTable Show="Y" />
    ///             <Glossary Show="Y" />
    ///             <Footer Show="Y" />
    ///         </Document>
    ///         <Document FileName="XXX.docx" TemplateName="XXX.docx" Copy="2" AddWaterMark="Y" PrintType="ALL">
    ///             <Requirement Show="Y">
    ///             <Dir Show="Y"  /> 
    ///             <ChangLog Show="Y" />
    ///             <Header Show="Y" />
    ///             <Section Seq="1" MapTo="FUT.Bank" ShowComponentApi="Y" />
    ///             <DBTable Show="Y" />
    ///             <Glossary Show="Y" />
    ///             <Footer Show="Y" />
    ///         </Document>
    ///     </Documents>
    /// </FFADoc>              
    /// ]]>
    /// </example>
    [XmlRoot(ElementName="FFADoc")]
    public class DocConfig
    {
        /// <summary>
        /// template Path
        /// </summary>
        [XmlElement]
        public string TemplatePath { get; set; }

        /// <summary>
        /// Dll Path
        /// </summary>
        [XmlElement]
        public string DllPath { get; set; }

        /// <summary>
        /// Output Path
        /// </summary>
        [XmlElement]
        public string OutputPath { get; set; }

        /// <summary>
        /// Documents
        /// </summary>
        [XmlElement]
        public Documents Documents { get; set; }

    }


    public class Documents
    {
        /// <summary>
        /// Doc Item
        /// </summary>
        [XmlElement(ElementName = "Doc")]
        public List<FFDoc> DocList { get; set; }
    }

    /// <summary>
    /// FF Document 
    /// </summary>
    public class FFDoc
    {
        /// <summary>
        /// Sequence 
        /// </summary>
        [XmlAttribute(AttributeName="seq")]
        public int Seq{get;set;}

        /// <summary>
        /// Version
        /// </summary>
        [XmlAttribute(AttributeName="version")]
        public int Version{get;set;}

        /// <summary>
        /// Doc Mode
        /// </summary>
        [XmlAttribute(AttributeName="docMode")]
        public string DocMode{get;set;}

        /// <summary>
        /// Template Docx
        /// </summary>
        [XmlAttribute(AttributeName="templateName")]
        public string TemplateName{get;set;}

        /// <summary>
        /// Write Type
        /// Support Docx/Pdf/xps/chm/web
        /// </summary>
        [XmlAttribute(AttributeName="writeType")]
        public string WriteType{get;set;}

        /// <summary>
        /// Write File
        /// </summary>
        [XmlAttribute(AttributeName="writeTo")]
        public string WriteTo{get;set;}

        /// <summary>
        /// Copy File 
        /// </summary>
        [XmlAttribute(AttributeName="copy")]
        public int Copy{get;set;}

        /// <summary>
        /// Body 
        /// </summary>
        [XmlElement]
        public Body Body { get; set; }
    }


    public class Body
    {
        [XmlElement(ElementName="Add")]
        public List<Add> Add { get; set; }
    }

    /// <summary>
    /// Add Map To
    /// Include 
    /// </summary>
    public class Add
    {
        [XmlAttribute(AttributeName = "mode")]
        public string Mode { get; set; }

        [XmlAttribute(AttributeName = "useContent")]
        public string UseContent { get; set; }

        [XmlAttribute(AttributeName = "mapTo")]
        public string MapTo { get; set; }

        [XmlText]
        public string Text { get; set; }
        
    }
}
