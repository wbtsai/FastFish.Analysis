using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandLine;
using DocBuilder.Options;
using log4net;
using FF.Helper.Log;
using System.Reflection;
using System.IO;

namespace DocBuilder
{
    /// <summary>
    /// Doc Builder Console Application
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();

            LogHelper.ToLog("Doc Builder Program ", 
                log => {

                    log.Info("Doc Builder Application: Now is：" + DateTime.Now);

                    log.Info("Get Version:" + Assembly.GetExecutingAssembly().GetName().Version);

                    var options = new Option();

                    ICommandLineParser parser = new CommandLineParser();

                    if (parser.ParseArguments(args, options))
                    {
                        if (options.Verbose)
                        {
                            log.Info("Input File="+options.InputFile);
                        }
                        else
                        {
                            log.Info("working ...");
                        }

                        if (!File.Exists(options.InputFile))
                        {
                            throw new Exception("InputFile 檔案不存在，請確認");
                        }


                    }
                    log.Info("程式執行成功");
                    Environment.Exit(0);
                }, 
                msgEx => {
                    Environment.Exit(-1);                     
                });


        }
    }
}
