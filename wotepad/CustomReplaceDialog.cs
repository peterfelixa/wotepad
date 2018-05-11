/*============================================================================================
 * ||              Author      : Peter Felix A
 * ||              Added On    : 05/22/2017, 15:44
 * ||              Class Name  : CustomReplaceDialog.cs
 * ||              Language    : CSharp
 * ||              Copyright   : Copyright(c)Symphion Inc 2003-2017 All Right Reserved
 * =============================================================================================*/
using System;
using System.Windows.Forms;
using wotepad.Objects;

namespace wotepad
{
    public partial class CustomReplaceDialog : DevExpress.XtraEditors.XtraForm
    {
        public delegate void FindHandler(string findString);
        public event FindHandler OnFindNextString;

        public delegate void ReplaceHandler(string findString);
        public event ReplaceHandler OnReplace;

        public delegate void ReplaceAllHandler(string findString, string replaceString);
        public event ReplaceAllHandler OnReplaceAll;


        private string _findString = string.Empty;
        private int _findHitCount = 0;

        public CustomReplaceDialog()
        {
            InitializeComponent();
        }

        private void CloseReplaceForm()
        {
            try
            {
                this.Close();
            }
            catch (Exception) { }
        }
        private void ProcessFind()
        {
            FindReplaceObjects.FindString = txtFindString.Text;
            FindReplaceObjects.MatchCase = chkMatchCase.Checked;
            FindReplaceObjects.SearchDirection = FindReplaceObjects.SearchDirections.Down;
            FindReplaceObjects.SearchCount = _findHitCount;
            OnFindNextString(txtFindString.Text);
            _findHitCount++;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                if (keyData == Keys.Escape)
                {
                    this.Close();
                }
                else if (keyData == Keys.Enter)
                {
                    ProcessFind();
                }
            }
            catch (Exception)
            {
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            CloseReplaceForm();
        }
        private void cmdFindNext_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessFind();
            }
            catch (Exception) { }
        }
        private void cmdReplace_Click(object sender, EventArgs e)
        {
            FindReplaceObjects.FindString = txtFindString.Text;
            FindReplaceObjects.MatchCase = chkMatchCase.Checked;
            FindReplaceObjects.SearchDirection = FindReplaceObjects.SearchDirections.Down;
            FindReplaceObjects.SearchCount = _findHitCount;
            OnReplace(txtReplaceString.Text);
        }
        private void cmdReplaceAll_Click(object sender, EventArgs e)
        {
            FindReplaceObjects.FindString = txtFindString.Text;
            FindReplaceObjects.MatchCase = chkMatchCase.Checked;
            FindReplaceObjects.SearchDirection = FindReplaceObjects.SearchDirections.Down;
            FindReplaceObjects.SearchCount = _findHitCount;
            OnReplaceAll(txtFindString.Text, txtReplaceString.Text);
        }
    }
}