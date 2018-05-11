/*============================================================================================
 * ||              Author      : Peter Felix A
 * ||              Added On    : 05/22/2017, 15:44
 * ||              Class Name  : EnvironmentInstaller.cs
 * ||              Language    : CSharp
 * ||              Copyright   : Copyright(c)Symphion Inc 2003-2017 All Right Reserved
 * =============================================================================================*/
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;

namespace wotepadInstallerHelper
{
    [RunInstaller(true)]
    public partial class EnvironmentInstaller : System.Configuration.Install.Installer
    {
        public EnvironmentInstaller()
        {
            InitializeComponent();
        }
        protected override void OnBeforeInstall(IDictionary stateSaver)
        {
            try
            {
                base.OnBeforeInstall(stateSaver);
                string sProgram = Context.Parameters["assemblypath"];
                InsatllSystemSettings(sProgram);
            }
            catch (Exception ex)
            {
                Context.LogMessage(ex.ToString());
            }
        }
        protected override void OnBeforeUninstall(IDictionary stateSaver)
        {
            try
            {
                base.OnBeforeUninstall(stateSaver);
                string sProgram = Context.Parameters["assemblypath"];
                UninsatllSystemSettings(sProgram);
            }
            catch (Exception ex)
            {
                Context.LogMessage(ex.ToString());
            }
        }
        void InsatllSystemSettings(string sProgram)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo(sProgram);
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.Arguments = "Install";
                Process p = Process.Start(startInfo);
                //ShowWindow(p.MainWindowHandle, WindowShowStyle.Show); //otherwise it is not activated 
                //SetForegroundWindow(p.MainWindowHandle);
                //BringWindowToTop(p.MainWindowHandle); // Make sure the user will see the new window above of the setup.
                p.WaitForExit();
            }
            catch (Exception) { }
        }
        void UninsatllSystemSettings(string sProgram)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo(sProgram);
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.Arguments = "Uninstall";
                Process p = Process.Start(startInfo);
                //ShowWindow(p.MainWindowHandle, WindowShowStyle.Show); //otherwise it is not activated 
                //SetForegroundWindow(p.MainWindowHandle);
                //BringWindowToTop(p.MainWindowHandle); // Make sure the user will see the new window above of the setup.
                p.WaitForExit();
            }
            catch (Exception) { }
        }

        //#region  "showWindow"
        //// http://pinvoke.net/default.aspx/user32.BringWindowToTop
        //[DllImport("user32.dll")]
        //static extern bool BringWindowToTop(IntPtr hWnd);

        //[DllImport("user32.dll")]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //private static extern bool SetForegroundWindow(IntPtr hWnd);

        ////from http://pinvoke.net/default.aspx/user32.SwitchToThisWindow 
        //[DllImport("user32.dll")]
        //private static extern bool ShowWindow(IntPtr hWnd, WindowShowStyle nCmdShow);

        ///// <summary>Enumeration of the different ways of showing a window using 
        ///// ShowWindow</summary>
        //private enum WindowShowStyle : uint
        //{
        //    /// <summary>Hides the window and activates another window.</summary>
        //    /// <remarks>See SW_HIDE</remarks>
        //    Hide = 0,
        //    /// <summary>Activates and displays a window. If the window is minimized 
        //    /// or maximized, the system restores it to its original size and 
        //    /// position. An application should specify this flag when displaying 
        //    /// the window for the first time.</summary>
        //    /// <remarks>See SW_SHOWNORMAL</remarks>
        //    ShowNormal = 1,
        //    /// <summary>Activates the window and displays it as a minimized window.</summary>
        //    /// <remarks>See SW_SHOWMINIMIZED</remarks>
        //    ShowMinimized = 2,
        //    /// <summary>Activates the window and displays it as a maximized window.</summary>
        //    /// <remarks>See SW_SHOWMAXIMIZED</remarks>
        //    ShowMaximized = 3,
        //    /// <summary>Maximizes the specified window.</summary>
        //    /// <remarks>See SW_MAXIMIZE</remarks>
        //    Maximize = 3,
        //    /// <summary>Displays a window in its most recent size and position. 
        //    /// This value is similar to "ShowNormal", except the window is not 
        //    /// activated.</summary>
        //    /// <remarks>See SW_SHOWNOACTIVATE</remarks>
        //    ShowNormalNoActivate = 4,
        //    /// <summary>Activates the window and displays it in its current size 
        //    /// and position.</summary>
        //    /// <remarks>See SW_SHOW</remarks>
        //    Show = 5,
        //    /// <summary>Minimizes the specified window and activates the next 
        //    /// top-level window in the Z order.</summary>
        //    /// <remarks>See SW_MINIMIZE</remarks>
        //    Minimize = 6,
        //    /// <summary>Displays the window as a minimized window. This value is 
        //    /// similar to "ShowMinimized", except the window is not activated.</summary>
        //    /// <remarks>See SW_SHOWMINNOACTIVE</remarks>
        //    ShowMinNoActivate = 7,
        //    /// <summary>Displays the window in its current size and position. This 
        //    /// value is similar to "Show", except the window is not activated.</summary>
        //    /// <remarks>See SW_SHOWNA</remarks>
        //    ShowNoActivate = 8,
        //    /// <summary>Activates and displays the window. If the window is 
        //    /// minimized or maximized, the system restores it to its original size 
        //    /// and position. An application should specify this flag when restoring 
        //    /// a minimized window.</summary>
        //    /// <remarks>See SW_RESTORE</remarks>
        //    Restore = 9,
        //    /// <summary>Sets the show state based on the SW_ value specified in the 
        //    /// STARTUPINFO structure passed to the CreateProcess function by the 
        //    /// program that started the application.</summary>
        //    /// <remarks>See SW_SHOWDEFAULT</remarks>
        //    ShowDefault = 10,
        //    /// <summary>Windows 2000/XP: Minimizes a window, even if the thread 
        //    /// that owns the window is hung. This flag should only be used when 
        //    /// minimizing windows from a different thread.</summary>
        //    /// <remarks>See SW_FORCEMINIMIZE</remarks>
        //    ForceMinimized = 11
        //}
        //#endregion
    }
}
