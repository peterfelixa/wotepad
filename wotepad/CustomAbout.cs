/*============================================================================================
 * ||              Author      : Peter Felix A
 * ||              Added On    : 05/22/2017, 15:43
 * ||              Class Name  : CustomAbout.cs
 * ||              Language    : CSharp
 * ||              Copyright   : Copyright(c)Symphion Inc 2003-2017 All Right Reserved
 * =============================================================================================*/
using System;
using System.Windows.Forms;

namespace wotepad
{
    public partial class CustomAbout : DevExpress.XtraEditors.XtraForm
    {
        public CustomAbout()
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
    }
}