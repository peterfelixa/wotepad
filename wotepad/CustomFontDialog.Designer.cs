namespace wotepad
{
    partial class CustomFontDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomFontDialog));
            this.fntEdit = new DevExpress.XtraEditors.FontEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.imgcollectionFonts = new DevExpress.Utils.ImageCollection(this.components);
            this.fontSize = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.chkUnderLine = new DevExpress.XtraEditors.CheckEdit();
            this.cmdOK = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancel = new DevExpress.XtraEditors.SimpleButton();
            this.imgcboFontStyle = new DevExpress.XtraEditors.ImageComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.fntEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcollectionFonts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUnderLine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcboFontStyle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fntEdit
            // 
            this.fntEdit.Location = new System.Drawing.Point(13, 26);
            this.fntEdit.Name = "fntEdit";
            this.fntEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fntEdit.Size = new System.Drawing.Size(263, 20);
            this.fntEdit.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(22, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Font";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Font Style";
            // 
            // imgcollectionFonts
            // 
            this.imgcollectionFonts.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgcollectionFonts.ImageStream")));
            this.imgcollectionFonts.Images.SetKeyName(0, "Bold16x16.png");
            this.imgcollectionFonts.Images.SetKeyName(1, "BoldItalic16x16.png");
            this.imgcollectionFonts.Images.SetKeyName(2, "Italic16x16.png");
            this.imgcollectionFonts.Images.SetKeyName(3, "Regular16x16.png");
            // 
            // fontSize
            // 
            this.fontSize.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.fontSize.Location = new System.Drawing.Point(63, 103);
            this.fontSize.Name = "fontSize";
            this.fontSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fontSize.Size = new System.Drawing.Size(105, 20);
            this.fontSize.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 106);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Font Size";
            // 
            // chkUnderLine
            // 
            this.chkUnderLine.Location = new System.Drawing.Point(201, 103);
            this.chkUnderLine.Name = "chkUnderLine";
            this.chkUnderLine.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.chkUnderLine.Properties.Appearance.Options.UseFont = true;
            this.chkUnderLine.Properties.Caption = "UnderLine";
            this.chkUnderLine.Size = new System.Drawing.Size(75, 19);
            this.chkUnderLine.TabIndex = 3;
            // 
            // cmdOK
            // 
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Location = new System.Drawing.Point(82, 143);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 4;
            this.cmdOK.Text = "&OK";
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(163, 143);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "&Cancel";
            // 
            // imgcboFontStyle
            // 
            this.imgcboFontStyle.Location = new System.Drawing.Point(13, 73);
            this.imgcboFontStyle.Name = "imgcboFontStyle";
            this.imgcboFontStyle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgcboFontStyle.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Regular", "Regular", 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bold", "Bold", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Italic", "Italic", 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Bold Italic", "Bold Italic", 1)});
            this.imgcboFontStyle.Properties.SmallImages = this.imgcollectionFonts;
            this.imgcboFontStyle.Size = new System.Drawing.Size(263, 20);
            this.imgcboFontStyle.TabIndex = 6;
            // 
            // CustomFontDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 177);
            this.Controls.Add(this.imgcboFontStyle);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.chkUnderLine);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.fontSize);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.fntEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomFontDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Font";
            this.Load += new System.EventHandler(this.CustomFontDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fntEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcollectionFonts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUnderLine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcboFontStyle.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.FontEdit fntEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.Utils.ImageCollection imgcollectionFonts;
        private DevExpress.XtraEditors.SpinEdit fontSize;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit chkUnderLine;
        private DevExpress.XtraEditors.SimpleButton cmdOK;
        private DevExpress.XtraEditors.SimpleButton cmdCancel;
        private DevExpress.XtraEditors.ImageComboBoxEdit imgcboFontStyle;
    }
}