using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandLine;
using DocBuilder.Options;

namespace DocBuilder
{
    /// <summary>
    /// Doc Builder Console Application
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var options = new Option();

                
                
                ICommandLineParser parser = new CommandLineParser();
                if (parser.ParseArguments(args, options))
                {
                    if (options.Verbose)
                    {
                        Console.WriteLine(options.InputFile);
                    }
                    else
                        Console.WriteLine("working ...");
                }

                throw new Exception("This is a test");

                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("程式發現不可預期之錯誤：");

                Console.WriteLine("Exception=" + DateTime.Now.ToString("yyyy/MM/dd"));

                Console.WriteLine(ex.InnerException + ex.Message + ex.StackTrace);
                
                Environment.Exit(-1);
            }
           
        }
    }
}
