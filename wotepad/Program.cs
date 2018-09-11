/*============================================================================================
 * ||              Author      : Peter Felix A
 * ||              Added On    : 05/12/2017, 14:38
 * ||              Class Name  : Program.cs
 * ||              Language    : CSharp
 * ||              Copyright   : Copyright(c)Symphion Inc 2003-2017 All Right Reserved
 * =============================================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Drawing;
using System.IO;
using wotepad.Helpers;
using wotepad.Objects;

namespace wotepad
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Comment added by peter to check Latest version check.
            string filepath = string.Empty;
            try
            {
                filepath = args[0];
                string createText = filepath + Environment.NewLine;
            }
            catch (Exception) { }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();

            try
            {
                AppSettingsHelper objAppSettingsHelper = new AppSettingsHelper();
                objAppSettingsHelper.LoadAppSettings();
                UserLookAndFeel.Default.SetSkinStyle(AppSettings.SkinName);
                DevExpress.Utils.AppearanceObject.DefaultFont = new Font(AppSettings.AppFont.Wotepad_FontName, AppSettings.AppFont.Wotepad_FontSize);
            }
            catch (Exception) { }

            Wotepad objWotepad = new Wotepad(filepath);
            objWotepad.StartPosition = FormStartPosition.Manual;
            objWotepad.Location = new Point(AppSettings.ApplicationStartup.FromLocation.X, AppSettings.ApplicationStartup.FromLocation.Y);
            objWotepad.Size = new Size(AppSettings.ApplicationStartup.FormSize.Width, AppSettings.ApplicationStartup.FormSize.Height);
            Application.Run(objWotepad);
        }
    }
}
