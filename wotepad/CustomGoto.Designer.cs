namespace wotepad
{
    partial class CustomGoto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomGoto));
            this.lblLineNumberCaption = new DevExpress.XtraEditors.LabelControl();
            this.txtLineNumber = new DevExpress.XtraEditors.TextEdit();
            this.cmdGoTo = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancel = new DevExpress.XtraEditors.SimpleButton();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtLineNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLineNumberCaption
            // 
            this.lblLineNumberCaption.Location = new System.Drawing.Point(13, 13);
            this.lblLineNumberCaption.Name = "lblLineNumberCaption";
            this.lblLineNumberCaption.Size = new System.Drawing.Size(59, 13);
            this.lblLineNumberCaption.TabIndex = 0;
            this.lblLineNumberCaption.Text = "Line Number";
            // 
            // txtLineNumber
            // 
            this.txtLineNumber.EditValue = "1";
            this.txtLineNumber.Location = new System.Drawing.Point(13, 33);
            this.txtLineNumber.Name = "txtLineNumber";
            this.txtLineNumber.Properties.Mask.EditMask = "n0";
            this.txtLineNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtLineNumber.Size = new System.Drawing.Size(268, 20);
            this.txtLineNumber.TabIndex = 0;
            this.txtLineNumber.EditValueChanged += new System.EventHandler(this.txtLineNumber_EditValueChanged);
            // 
            // cmdGoTo
            // 
            this.cmdGoTo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdGoTo.Image = ((System.Drawing.Image)(resources.GetObject("cmdGoTo.Image")));
            this.cmdGoTo.Location = new System.Drawing.Point(67, 59);
            this.cmdGoTo.Name = "cmdGoTo";
            this.cmdGoTo.Size = new System.Drawing.Size(75, 23);
            this.cmdGoTo.TabIndex = 1;
            this.cmdGoTo.Text = "&Go To";
            this.cmdGoTo.Click += new System.EventHandler(this.cmdGoTo_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancel.Image")));
            this.cmdCancel.Location = new System.Drawing.Point(158, 59);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "&Cancel";
            // 
            // dxValidationProvider1
            // 
            this.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // Goto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 92);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdGoTo);
            this.Controls.Add(this.txtLineNumber);
            this.Controls.Add(this.lblLineNumberCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Goto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Go To Line";
            this.Load += new System.EventHandler(this.Goto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtLineNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblLineNumberCaption;
        private DevExpress.XtraEditors.TextEdit txtLineNumber;
        private DevExpress.XtraEditors.SimpleButton cmdGoTo;
        private DevExpress.XtraEditors.SimpleButton cmdCancel;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}