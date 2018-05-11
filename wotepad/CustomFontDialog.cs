/*============================================================================================
 * ||              Author      : Peter Felix A
 * ||              Added On    : 05/22/2017, 15:44
 * ||              Class Name  : CustomFontDialog.cs
 * ||              Language    : CSharp
 * ||              Copyright   : Copyright(c)Symphion Inc 2003-2017 All Right Reserved
 * =============================================================================================*/
using System;
using System.Windows.Forms;
using wotepad.Objects;
using wotepad.Helpers;

namespace wotepad
{
    public partial class CustomFontDialog : DevExpress.XtraEditors.XtraForm
    {
        public CustomFontDialog()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                if (keyData == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        
        private void CustomFontDialog_Load(object sender, EventArgs e)
        {
            fntEdit.EditValue = AppSettings.EditorFont.Editor_FontName;
            imgcboFontStyle.EditValue = AppSettings.EditorFont.Editor_FontStyle.ToString();
            fontSize.EditValue = AppSettings.EditorFont.Editor_FontSize;
            chkUnderLine.Checked = AppSettings.EditorFont.Editor_UnderLine;
        }
        private void cmdOK_Click(object sender, EventArgs e)
        {
            AppSettings.EditorFont.Editor_FontName = fntEdit.EditValue.ToString();
            AppSettings.EditorFont.Editor_FontStyle = FontHelper.GetFontStyle(imgcboFontStyle.EditValue.ToString());
            AppSettings.EditorFont.Editor_FontSize = Convert.ToInt32(fontSize.EditValue.ToString());
            AppSettings.EditorFont.Editor_UnderLine = chkUnderLine.Checked;
            AppSettingsHelper objAppSettingsHelper = new AppSettingsHelper();
            objAppSettingsHelper.WriteAppSettings();
        }
    }
}