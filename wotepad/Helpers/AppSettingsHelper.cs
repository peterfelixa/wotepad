/*=============================================================================================================
 * ||              Author      : peterfelix
 * ||              Added On    : Tuesday, September 5, 2017 12:37:46 PM
 * ||              Class Name  : AppSettingsHelper.cs
 * ||              Language    : CSharp
 * ||              Copyright   : Copyright©Symphion Inc 2003-2017 All Right Reserved
 * ||              Purpose     : To Handle/Store/Reload App Level Settings into/from xml file.
 * ==========================================================================================================*/
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using wotepad.Objects;
using wotepad.Properties;

namespace wotepad.Helpers
{
    public class AppSettingsHelper
    {
        #region Member Variables
        private DataTable dtAppSettings = new DataTable();
        #endregion Member Variables

        #region Constructor
        public AppSettingsHelper()
        {
            IniatilizeAppSettingsSource();
        }
        #endregion Constructor

        #region Private Methods
        private void IniatilizeAppSettingsSource()
        {
            try
            {
                if (dtAppSettings.Columns.Count == 0)
                {
                    DataColumn dcApp_Skin = new DataColumn("App_Skin");
                    DataColumn dcApp_ShowStatus = new DataColumn("App_ShowStatus");
                    DataColumn dcApp_FontName = new DataColumn("App_FontName");
                    DataColumn dcApp_FontSize = new DataColumn("App_FontSize");

                    DataColumn dcEditor_FontName = new DataColumn("Editor_FontName");
                    DataColumn dcEditor_FontStyle = new DataColumn("Editor_FontStyle");
                    DataColumn dcEditor_FontSize = new DataColumn("Editor_FontSize");
                    DataColumn dcEditor_FontUnderline = new DataColumn("Editor_FontUnderline");

                    DataColumn dcEditor_WordWrap = new DataColumn("Editor_WordWrap");

                    if (!dtAppSettings.Columns.Contains(dcApp_Skin.ColumnName))
                        dtAppSettings.Columns.Add(dcApp_Skin);

                    if (!dtAppSettings.Columns.Contains(dcApp_ShowStatus.ColumnName))
                        dtAppSettings.Columns.Add(dcApp_ShowStatus);

                    if (!dtAppSettings.Columns.Contains(dcApp_FontName.ColumnName))
                        dtAppSettings.Columns.Add(dcApp_FontName);

                    if (!dtAppSettings.Columns.Contains(dcApp_FontSize.ColumnName))
                        dtAppSettings.Columns.Add(dcApp_FontSize);



                    if (!dtAppSettings.Columns.Contains(dcEditor_FontName.ColumnName))
                        dtAppSettings.Columns.Add(dcEditor_FontName);

                    if (!dtAppSettings.Columns.Contains(dcEditor_FontStyle.ColumnName))
                        dtAppSettings.Columns.Add(dcEditor_FontStyle);

                    if (!dtAppSettings.Columns.Contains(dcEditor_FontSize.ColumnName))
                        dtAppSettings.Columns.Add(dcEditor_FontSize);

                    if (!dtAppSettings.Columns.Contains(dcEditor_FontUnderline.ColumnName))
                        dtAppSettings.Columns.Add(dcEditor_FontUnderline);



                    if (!dtAppSettings.Columns.Contains(dcEditor_WordWrap.ColumnName))
                        dtAppSettings.Columns.Add(dcEditor_WordWrap);
                }
            }
            catch (Exception)
            {
            }
        }
        #endregion Private Methods

        #region Public Methods
        public void WriteAppSettings()
        {
            try
            {
                dtAppSettings.Rows.Add(
                    AppSettings.SkinName                                //AppSettings.SkinName
                    , AppSettings.ShowStatusBar                         //AppSettings.ShowStatusBar
                    , AppSettings.AppFont.Wotepad_FontName              //AppSettings.AppFont.Wotepad_FontName
                    , AppSettings.AppFont.Wotepad_FontSize              //AppSettings.AppFont.Wotepad_FontSize

                    , AppSettings.EditorFont.Editor_FontName            //AppSettings.EditorFont.Editor_FontName
                    , AppSettings.EditorFont.Editor_FontStyle           //AppSettings.EditorFont.Editor_FontStyle
                    , AppSettings.EditorFont.Editor_FontSize            //AppSettings.EditorFont.Editor_FontSize
                    , AppSettings.EditorFont.Editor_UnderLine           //AppSettings.EditorFont.Editor_UnderLine

                    , AppSettings.EditorSettings.Editor_WordWrap        //AppSettings.EditorSettings.Editor_WordWrap
                    );
                dtAppSettings.TableName = "AppSettings";
                dtAppSettings.WriteXml(Application.StartupPath + @"\AppSettings.xml");


                //Settings.Default["Application_SkinName"] = AppSettings.SkinName.ToString();
                //Settings.Default["Application_ShowStatus"] = Convert.ToBoolean(AppSettings.ShowStatusBar.ToString());
                //Settings.Default["Application_FontName"] = AppSettings.AppFont.Wotepad_FontName.ToString();
                //Settings.Default["Application_FontSize"] = Convert.ToInt32(AppSettings.AppFont.Wotepad_FontSize.ToString());

                //Settings.Default["Editor_FontName"] = AppSettings.EditorFont.Editor_FontName.ToString();
                //Settings.Default["Editor_FontStyle"] = FontHelper.GetFontStyle(AppSettings.EditorFont.Editor_FontStyle.ToString());
                //Settings.Default["Editor_FontSize"] = Convert.ToInt32(AppSettings.EditorFont.Editor_FontSize.ToString());
                //Settings.Default["Editor_FontUnderline"] = Convert.ToBoolean(AppSettings.EditorFont.Editor_UnderLine.ToString());

                //Settings.Default["Editor_WordWrap"] = Convert.ToBoolean(AppSettings.EditorSettings.Editor_WordWrap.ToString());
                //try { Properties.Settings.Default.Save(); } catch (Exception) { }
                //try { Properties.Settings.Default.Upgrade(); } catch (Exception) { }
            }
            catch (Exception) { }
        }
        public void LoadAppSettings()
        {
            try
            {
                if (File.Exists(Application.StartupPath + @"\AppSettings.xml"))
                {
                    DataSet ds = new DataSet();
                    ds.ReadXml(Application.StartupPath + @"\AppSettings.xml");
                    dtAppSettings = ds.Tables[0];

                    AppSettings.SkinName = dtAppSettings.Rows[0]["App_Skin"].ToString();
                    AppSettings.ShowStatusBar = Convert.ToBoolean(dtAppSettings.Rows[0]["App_ShowStatus"].ToString());
                    AppSettings.AppFont.Wotepad_FontName = dtAppSettings.Rows[0]["App_FontName"].ToString();
                    AppSettings.AppFont.Wotepad_FontSize = Convert.ToInt32(dtAppSettings.Rows[0]["App_FontSize"].ToString());

                    AppSettings.EditorFont.Editor_FontName = dtAppSettings.Rows[0]["Editor_FontName"].ToString();
                    AppSettings.EditorFont.Editor_FontStyle = FontHelper.GetFontStyle(dtAppSettings.Rows[0]["Editor_FontStyle"].ToString());
                    AppSettings.EditorFont.Editor_FontSize = Convert.ToInt32(dtAppSettings.Rows[0]["Editor_FontSize"].ToString());
                    AppSettings.EditorFont.Editor_UnderLine = Convert.ToBoolean(dtAppSettings.Rows[0]["Editor_FontUnderline"].ToString());

                    AppSettings.EditorSettings.Editor_WordWrap = Convert.ToBoolean(dtAppSettings.Rows[0]["Editor_WordWrap"].ToString());
                }

                //AppSettings.SkinName = Settings.Default["Application_SkinName"].ToString();
                //AppSettings.ShowStatusBar = Convert.ToBoolean(Settings.Default["Application_ShowStatus"].ToString());
                //AppSettings.AppFont.Wotepad_FontName = Settings.Default["Application_FontName"].ToString();
                //AppSettings.AppFont.Wotepad_FontSize = Convert.ToInt32(Settings.Default["Application_FontSize"].ToString());

                //AppSettings.EditorFont.Editor_FontName = Settings.Default["Editor_FontName"].ToString();
                //AppSettings.EditorFont.Editor_FontStyle = FontHelper.GetFontStyle(Settings.Default["Editor_FontStyle"].ToString());
                //AppSettings.EditorFont.Editor_FontSize = Convert.ToInt32(Settings.Default["Editor_FontSize"].ToString());
                //AppSettings.EditorFont.Editor_UnderLine = Convert.ToBoolean(Settings.Default["Editor_FontUnderline"].ToString());

                //AppSettings.EditorSettings.Editor_WordWrap = Convert.ToBoolean(Settings.Default["Editor_WordWrap"].ToString());
            }
            catch (Exception) { }
        }
        #endregion Public Methods
    }
}