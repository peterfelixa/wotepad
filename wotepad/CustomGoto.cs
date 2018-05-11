/*============================================================================================
 * ||              Author      : Peter Felix A
 * ||              Added On    : 05/22/2017, 15:44
 * ||              Class Name  : CustomGoto.cs
 * ||              Language    : CSharp
 * ||              Copyright   : Copyright(c)Symphion Inc 2003-2017 All Right Reserved
 * =============================================================================================*/
using System;
using System.Windows.Forms;
using DevExpress.XtraEditors.DXErrorProvider;

namespace wotepad
{
    public partial class CustomGoto : DevExpress.XtraEditors.XtraForm
    {
        int _linesCount = 0;
        int _currentLine = 0;

        public CustomGoto(int lineCount = 0, int currentLine = 0)
        {
            InitializeComponent();
            _linesCount = lineCount;
            _currentLine = currentLine;
            dxValidationProvider1.Validate(txtLineNumber);
        }
        private void PerformGoto()
        {
            Wotepad.GotoLine = Convert.ToInt32(txtLineNumber.Text) - 1;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                if (keyData == Keys.Enter)
                {
                    PerformGoto();
                }
                else if(keyData == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Goto_Load(object sender, EventArgs e)
        {
            lblLineNumberCaption.Text = "Line Number (1 - " + _linesCount + ")";
            txtLineNumber.Text = _currentLine.ToString();
        }
        private void txtLineNumber_EditValueChanged(object sender, EventArgs e)
        {
            if (txtLineNumber.Text != string.Empty)
            {
                if (txtLineNumber.Text.Length > 0)
                {
                    int enteredNumber = 0;
                    if (int.TryParse(txtLineNumber.Text, out enteredNumber))
                    {
                        if (enteredNumber < 1 || enteredNumber > _linesCount)
                        {
                            dxErrorProvider1.SetError(txtLineNumber, "Must be between 1 and " + _linesCount, ErrorType.Critical);
                        }
                        else
                        {
                            dxErrorProvider1.RefreshControl(txtLineNumber);
                            dxErrorProvider1.RefreshControls();
                            dxErrorProvider1.ClearErrors();
                        }
                    }
                }
            }
        }
        private void cmdGoTo_Click(object sender, EventArgs e)
        {
            PerformGoto();
        }
    }
}