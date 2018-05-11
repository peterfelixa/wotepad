/*============================================================================================
 * ||              Author      : Peter Felix A
 * ||              Added On    : 05/22/2017, 15:44
 * ||              Class Name  : WotepadInstaller.cs
 * ||              Language    : CSharp
 * ||              Copyright   : Copyright(c)Symphion Inc 2003-2017 All Right Reserved
 * =============================================================================================*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wotepad
{
    [RunInstaller(true)]
    public partial class WotepadInstaller : System.Configuration.Install.Installer
    {
        public WotepadInstaller()
        {
            InitializeComponent();
        }
        public override void Install(IDictionary stateSaver)
        {
            try
            {
                base.Install(stateSaver);
                string executableName = Application.ExecutablePath;
                FileInfo executableFileInfo = new FileInfo(executableName);
                string executableDirectoryName = executableFileInfo.DirectoryName;
            }
            catch (Exception)
            {
            }
        }
    }
}
