/*============================================================================================
 * ||              Author      : Peter Felix A
 * ||              Added On    : 05/22/2017, 15:44
 * ||              Class Name  : Program.cs
 * ||              Language    : CSharp
 * ||              Copyright   : Copyright(c)Symphion Inc 2003-2017 All Right Reserved
 * =============================================================================================*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wotepadInstallerHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string runMode = args[0].ToString();
                if (runMode.ToLower() == "install")
                {
                    string lastFolderName = Application.StartupPath;
                    AddEnvironmentalVariable(lastFolderName);
                }
                else if (runMode.ToLower() == "uninstall")
                {
                    //Console.WriteLine("Uninstall Initiated ...");
                    string lastFolderName = Application.StartupPath;
                    RemoveEnvironmentalVariable(lastFolderName);
                }
            }
            //Console.WriteLine("Press Enter to Continue Installation");
            //Console.ReadKey();
        }
        private static void AddEnvironmentalVariable(string directoryPath)
        {
            try
            {
                string pathvar = System.Environment.GetEnvironmentVariable("PATH");
                var name = "PATH";
                if (!pathvar.Contains(@";" + directoryPath + ""))
                {
                    var value = pathvar + @";" + directoryPath + "";
                    var target = EnvironmentVariableTarget.Machine;
                    System.Environment.SetEnvironmentVariable(name, value, target);
                }
            }
            catch (Exception) { }
        }
        private static void RemoveEnvironmentalVariable(string directoryPath)
        {
            try
            {
                //Console.WriteLine("Folder path : " + directoryPath);
                string pathvar = System.Environment.GetEnvironmentVariable("PATH");
                //Console.WriteLine("Environmental path value : " + pathvar);
                var name = "PATH";
                if (pathvar.Contains(@";" + directoryPath + ""))
                {
                    var value = pathvar.Replace(@";" + directoryPath + "", "");
                    //Console.WriteLine("Environmental path value : " + value);
                    var target = EnvironmentVariableTarget.Machine;
                    System.Environment.SetEnvironmentVariable(name, value, target);
                    //Console.WriteLine("Environmental path value : " + value + " set successfully...");
                }
                else
                {
                    //Console.WriteLine("Environmental path does not have wotepad directory...");
                }
            }
            catch (Exception) { }
        }
    }
}
