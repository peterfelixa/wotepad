namespace wotepad
{
    partial class CustomReplaceDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomReplaceDialog));
            this.lblFindWhatCaption = new DevExpress.XtraEditors.LabelControl();
            this.lblReplaceWithCaption = new DevExpress.XtraEditors.LabelControl();
            this.txtFindString = new DevExpress.XtraEditors.TextEdit();
            this.txtReplaceString = new DevExpress.XtraEditors.TextEdit();
            this.chkMatchCase = new DevExpress.XtraEditors.CheckEdit();
            this.cmdFindNext = new DevExpress.XtraEditors.SimpleButton();
            this.cmdReplace = new DevExpress.XtraEditors.SimpleButton();
            this.cmdReplaceAll = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtFindString.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReplaceString.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMatchCase.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFindWhatCaption
            // 
            this.lblFindWhatCaption.Location = new System.Drawing.Point(13, 13);
            this.lblFindWhatCaption.Name = "lblFindWhatCaption";
            this.lblFindWhatCaption.Size = new System.Drawing.Size(57, 13);
            this.lblFindWhatCaption.TabIndex = 7;
            this.lblFindWhatCaption.Text = "Find What ?";
            // 
            // lblReplaceWithCaption
            // 
            this.lblReplaceWithCaption.Location = new System.Drawing.Point(12, 42);
            this.lblReplaceWithCaption.Name = "lblReplaceWithCaption";
            this.lblReplaceWithCaption.Size = new System.Drawing.Size(63, 13);
            this.lblReplaceWithCaption.TabIndex = 8;
            this.lblReplaceWithCaption.Text = "Replace With";
            // 
            // txtFindString
            // 
            this.txtFindString.Location = new System.Drawing.Point(91, 10);
            this.txtFindString.Name = "txtFindString";
            this.txtFindString.Size = new System.Drawing.Size(266, 20);
            this.txtFindString.TabIndex = 0;
            // 
            // txtReplaceString
            // 
            this.txtReplaceString.Location = new System.Drawing.Point(91, 39);
            this.txtReplaceString.Name = "txtReplaceString";
            this.txtReplaceString.Size = new System.Drawing.Size(266, 20);
            this.txtReplaceString.TabIndex = 1;
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.Location = new System.Drawing.Point(91, 66);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Properties.Caption = "&Match Case";
            this.chkMatchCase.Size = new System.Drawing.Size(75, 19);
            this.chkMatchCase.TabIndex = 2;
            // 
            // cmdFindNext
            // 
            this.cmdFindNext.Image = ((System.Drawing.Image)(resources.GetObject("cmdFindNext.Image")));
            this.cmdFindNext.Location = new System.Drawing.Point(12, 96);
            this.cmdFindNext.Name = "cmdFindNext";
            this.cmdFindNext.Size = new System.Drawing.Size(75, 23);
            this.cmdFindNext.TabIndex = 3;
            this.cmdFindNext.Text = "&Find Next";
            this.cmdFindNext.Click += new System.EventHandler(this.cmdFindNext_Click);
            // 
            // cmdReplace
            // 
            this.cmdReplace.Image = ((System.Drawing.Image)(resources.GetObject("cmdReplace.Image")));
            this.cmdReplace.Location = new System.Drawing.Point(93, 96);
            this.cmdReplace.Name = "cmdReplace";
            this.cmdReplace.Size = new System.Drawing.Size(88, 23);
            this.cmdReplace.TabIndex = 4;
            this.cmdReplace.Text = "&Replace";
            this.cmdReplace.Click += new System.EventHandler(this.cmdReplace_Click);
            // 
            // cmdReplaceAll
            // 
            this.cmdReplaceAll.Image = ((System.Drawing.Image)(resources.GetObject("cmdReplaceAll.Image")));
            this.cmdReplaceAll.Location = new System.Drawing.Point(187, 96);
            this.cmdReplaceAll.Name = "cmdReplaceAll";
            this.cmdReplaceAll.Size = new System.Drawing.Size(86, 23);
            this.cmdReplaceAll.TabIndex = 5;
            this.cmdReplaceAll.Text = "Replace &All";
            this.cmdReplaceAll.Click += new System.EventHandler(this.cmdReplaceAll_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancel.Image")));
            this.cmdCancel.Location = new System.Drawing.Point(279, 96);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 6;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // CustomReplaceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 129);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdReplaceAll);
            this.Controls.Add(this.cmdReplace);
            this.Controls.Add(this.cmdFindNext);
            this.Controls.Add(this.chkMatchCase);
            this.Controls.Add(this.txtReplaceString);
            this.Controls.Add(this.txtFindString);
            this.Controls.Add(this.lblReplaceWithCaption);
            this.Controls.Add(this.lblFindWhatCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomReplaceDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Replace";
            ((System.ComponentModel.ISupportInitialize)(this.txtFindString.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReplaceString.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMatchCase.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblFindWhatCaption;
        private DevExpress.XtraEditors.LabelControl lblReplaceWithCaption;
        private DevExpress.XtraEditors.TextEdit txtFindString;
        private DevExpress.XtraEditors.TextEdit txtReplaceString;
        private DevExpress.XtraEditors.CheckEdit chkMatchCase;
        private DevExpress.XtraEditors.SimpleButton cmdFindNext;
        private DevExpress.XtraEditors.SimpleButton cmdReplace;
        private DevExpress.XtraEditors.SimpleButton cmdReplaceAll;
        private DevExpress.XtraEditors.SimpleButton cmdCancel;
    }
}