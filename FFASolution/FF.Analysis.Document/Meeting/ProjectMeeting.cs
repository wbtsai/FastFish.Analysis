﻿// -----------------------------------------------------------------------
// <copyright file="ProjectMeeting.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace FF.Analysis.Document.Meeting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FF.Analysis.Core.Docx.Attributes;
    using FF.Analysis.Core.Docx;
    using FF.Analysis.Core.Docx.Module;
    

    /// <summary>
    /// 會議記錄(支援多筆)
    /// </summary>
    [DocxTemplate(TemplateId="M01",TemplateName="Project Meeting",Group=DocxGroup.Meeting,IsEnable=true,Version=1,StartDate="2012/08/01",Description="Meeting Documemt",IsSupportList=true)]
    public class ProjectMeeting:DocxContainer
    {
        public List<ProjectM1> MList { get; set; }

        /// <summary>
        /// Class Write to Docx
        /// </summary>
        public override void WriteToDocx() 
        {
            //Write to docx
        }
    }

    /// <summary>
    /// Mapping to 
    /// </summary>
    [MapTo(MapId="AAA")]
    public class ProjectM1
    { 
        
    }
        
}
