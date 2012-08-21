// -----------------------------------------------------------------------
// <copyright file="Option.cs" company="yuanta">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace DocBuilder.Options
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using CommandLine;
    using CommandLine.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Option
    {

        [Option("i",null, Required = true, HelpText = "xml config file to read.")]
        public string InputFile { get; set; }
        
        [Option("v", null, HelpText = "Print details during execution.")]
        public bool Verbose { get; set; }
                
        [HelpOption]
        public string GetUsage()
        {
            var usage = new StringBuilder();
            usage.AppendLine("Doc Builder Application 1.0");
            usage.AppendLine("Read user manual for usage instructions...");
            return usage.ToString();
        }

    }
}
