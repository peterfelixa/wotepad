/*============================================================================================
 * ||              Author      : Peter Felix A
 * ||              Added On    : 05/22/2017, 15:43
 * ||              Class Name  : CustomFindForm.cs
 * ||              Language    : CSharp
 * ||              Copyright   : Copyright(c)Symphion Inc 2003-2017 All Right Reserved
 * =============================================================================================*/
using System;
using System.Windows.Forms;
using wotepad.Objects;

namespace wotepad
{
    public partial class CustomFindForm : DevExpress.XtraEditors.XtraForm
    {
        public delegate void FindHandler(string findString);
        public event FindHandler OnFindNextString;
        private string _findString = string.Empty;
        private int _findHitCount = 0;

        public CustomFindForm()
        {
            InitializeComponent();
        }

        private void ProcessFind()
        {
            FindReplaceObjects.FindString = txtFindString.Text;
            FindReplaceObjects.MatchCase = chkMatchCase.Checked;
            FindReplaceObjects.SearchDirection = (rdogrpSearchDirection.SelectedIndex == 0) ? FindReplaceObjects.SearchDirections.Up : FindReplaceObjects.SearchDirections.Down;
            FindReplaceObjects.SearchCount = _findHitCount;
            OnFindNextString(txtFindString.Text);
            _findHitCount++;
        }
        private void CloseFindForm()
        {
            try
            {
                this.Close();
            }
            catch (Exception) { }
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
        private void cmdFindNext_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessFind();
            }
            catch (Exception) { }
        }
        private void CustomFindForm_Load(object sender, EventArgs e)
        {
            txtFindString.Text = FindReplaceObjects.FindString;
            chkMatchCase.Checked = FindReplaceObjects.MatchCase;
            rdogrpSearchDirection.SelectedIndex = (FindReplaceObjects.SearchDirection == FindReplaceObjects.SearchDirections.Up) ? 0 : 1;
        }
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            CloseFindForm();
        }
    }
}