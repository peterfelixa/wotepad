namespace wotepad
{
    partial class CustomFindForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomFindForm));
            this.lblCaptionFindWhat = new DevExpress.XtraEditors.LabelControl();
            this.txtFindString = new DevExpress.XtraEditors.TextEdit();
            this.chkMatchCase = new DevExpress.XtraEditors.CheckEdit();
            this.rdogrpSearchDirection = new DevExpress.XtraEditors.RadioGroup();
            this.lblCaptionSearchDirection = new DevExpress.XtraEditors.LabelControl();
            this.cmdFindNext = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtFindString.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMatchCase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdogrpSearchDirection.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaptionFindWhat
            // 
            this.lblCaptionFindWhat.Location = new System.Drawing.Point(13, 13);
            this.lblCaptionFindWhat.Name = "lblCaptionFindWhat";
            this.lblCaptionFindWhat.Size = new System.Drawing.Size(57, 13);
            this.lblCaptionFindWhat.TabIndex = 0;
            this.lblCaptionFindWhat.Text = "Find What ?";
            // 
            // txtFindString
            // 
            this.txtFindString.Location = new System.Drawing.Point(13, 32);
            this.txtFindString.Name = "txtFindString";
            this.txtFindString.Size = new System.Drawing.Size(365, 20);
            this.txtFindString.TabIndex = 0;
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.Location = new System.Drawing.Point(13, 58);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Properties.Caption = "Match Case";
            this.chkMatchCase.Size = new System.Drawing.Size(75, 19);
            this.chkMatchCase.TabIndex = 1;
            // 
            // rdogrpSearchDirection
            // 
            this.rdogrpSearchDirection.EditValue = "Down";
            this.rdogrpSearchDirection.Location = new System.Drawing.Point(207, 56);
            this.rdogrpSearchDirection.Name = "rdogrpSearchDirection";
            this.rdogrpSearchDirection.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Up", "Up"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Down", "Down")});
            this.rdogrpSearchDirection.Size = new System.Drawing.Size(171, 24);
            this.rdogrpSearchDirection.TabIndex = 2;
            // 
            // lblCaptionSearchDirection
            // 
            this.lblCaptionSearchDirection.Location = new System.Drawing.Point(115, 61);
            this.lblCaptionSearchDirection.Name = "lblCaptionSearchDirection";
            this.lblCaptionSearchDirection.Size = new System.Drawing.Size(78, 13);
            this.lblCaptionSearchDirection.TabIndex = 4;
            this.lblCaptionSearchDirection.Text = "Search Direction";
            // 
            // cmdFindNext
            // 
            this.cmdFindNext.Image = ((System.Drawing.Image)(resources.GetObject("cmdFindNext.Image")));
            this.cmdFindNext.Location = new System.Drawing.Point(115, 95);
            this.cmdFindNext.Name = "cmdFindNext";
            this.cmdFindNext.Size = new System.Drawing.Size(75, 23);
            this.cmdFindNext.TabIndex = 3;
            this.cmdFindNext.Text = "&Find Next";
            this.cmdFindNext.Click += new System.EventHandler(this.cmdFindNext_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancel.Image")));
            this.cmdCancel.Location = new System.Drawing.Point(196, 95);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // CustomFindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 127);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdFindNext);
            this.Controls.Add(this.lblCaptionSearchDirection);
            this.Controls.Add(this.rdogrpSearchDirection);
            this.Controls.Add(this.chkMatchCase);
            this.Controls.Add(this.txtFindString);
            this.Controls.Add(this.lblCaptionFindWhat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomFindForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find";
            this.Load += new System.EventHandler(this.CustomFindForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFindString.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMatchCase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdogrpSearchDirection.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCaptionFindWhat;
        private DevExpress.XtraEditors.TextEdit txtFindString;
        private DevExpress.XtraEditors.CheckEdit chkMatchCase;
        private DevExpress.XtraEditors.RadioGroup rdogrpSearchDirection;
        private DevExpress.XtraEditors.LabelControl lblCaptionSearchDirection;
        private DevExpress.XtraEditors.SimpleButton cmdFindNext;
        private DevExpress.XtraEditors.SimpleButton cmdCancel;
    }
}