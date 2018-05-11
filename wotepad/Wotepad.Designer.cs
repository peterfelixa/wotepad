/*============================================================================================
 * ||              Author      : Peter Felix A
 * ||              Added On    : 05/12/2017, 14:38
 * ||              Class Name  : wotepad.Designer.cs
 * ||              Language    : CSharp
 * ||              Copyright   : Copyright(c)Symphion Inc 2003-2017 All Right Reserved
 * =============================================================================================*/
namespace wotepad
{
    partial class Wotepad
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
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling2 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wotepad));
            this.splchkrWotepad = new DevExpress.XtraSpellChecker.SpellChecker(this.components);
            this.medtContent = new DevExpress.XtraEditors.MemoEdit();
            this.bmMenus = new DevExpress.XtraBars.BarManager(this.components);
            this.menuBar = new DevExpress.XtraBars.Bar();
            this.mnuFile = new DevExpress.XtraBars.BarSubItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiOpen = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveas = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExit = new DevExpress.XtraBars.BarButtonItem();
            this.mnuEdit = new DevExpress.XtraBars.BarSubItem();
            this.bbiUndo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCut = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCopy = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPaste = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFind = new DevExpress.XtraBars.BarButtonItem();
            this.bbiFindNext = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReplace = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGoTo = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSelectAll = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTimeDate = new DevExpress.XtraBars.BarButtonItem();
            this.mnuFormat = new DevExpress.XtraBars.BarSubItem();
            this.bbiWrapWord = new DevExpress.XtraBars.BarCheckItem();
            this.bbiFont = new DevExpress.XtraBars.BarButtonItem();
            this.mnuView = new DevExpress.XtraBars.BarSubItem();
            this.bchkStatusBarVisibility = new DevExpress.XtraBars.BarCheckItem();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.mnuHelp = new DevExpress.XtraBars.BarSubItem();
            this.bbiAbout = new DevExpress.XtraBars.BarButtonItem();
            this.statusBar = new DevExpress.XtraBars.Bar();
            this.bblCursorPosition = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.prntDlg = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.medtContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmMenus)).BeginInit();
            this.SuspendLayout();
            // 
            // splchkrWotepad
            // 
            this.splchkrWotepad.Culture = new System.Globalization.CultureInfo("en-US");
            this.splchkrWotepad.ParentContainer = null;
            this.splchkrWotepad.SpellCheckMode = DevExpress.XtraSpellChecker.SpellCheckMode.AsYouType;
            this.splchkrWotepad.SpellingFormType = DevExpress.XtraSpellChecker.SpellingFormType.Word;
            // 
            // medtContent
            // 
            this.medtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medtContent.Location = new System.Drawing.Point(0, 20);
            this.medtContent.Name = "medtContent";
            this.medtContent.Properties.AcceptsTab = true;
            this.medtContent.Properties.HideSelection = false;
            this.medtContent.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.medtContent.Properties.WordWrap = false;
            this.splchkrWotepad.SetShowSpellCheckMenu(this.medtContent, true);
            this.medtContent.Size = new System.Drawing.Size(1006, 530);
            this.splchkrWotepad.SetSpellCheckerOptions(this.medtContent, optionsSpelling2);
            this.medtContent.TabIndex = 6;
            this.medtContent.EditValueChanged += new System.EventHandler(this.medtContent_EditValueChanged);
            this.medtContent.Click += new System.EventHandler(this.medtContent_Click);
            this.medtContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.medtContent_KeyDown);
            this.medtContent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.medtContent_KeyUp);
            // 
            // bmMenus
            // 
            this.bmMenus.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.menuBar,
            this.statusBar});
            this.bmMenus.DockControls.Add(this.barDockControlTop);
            this.bmMenus.DockControls.Add(this.barDockControlBottom);
            this.bmMenus.DockControls.Add(this.barDockControlLeft);
            this.bmMenus.DockControls.Add(this.barDockControlRight);
            this.bmMenus.Form = this;
            this.bmMenus.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mnuFile,
            this.bbiSave,
            this.mnuView,
            this.bchkStatusBarVisibility,
            this.bbiSaveas,
            this.bbiExit,
            this.bbiNew,
            this.bbiOpen,
            this.mnuEdit,
            this.mnuFormat,
            this.mnuHelp,
            this.bbiAbout,
            this.bbiWrapWord,
            this.bbiFont,
            this.bbiUndo,
            this.bbiCut,
            this.bbiCopy,
            this.bbiPaste,
            this.bbiDelete,
            this.bbiFind,
            this.bbiFindNext,
            this.bbiReplace,
            this.bbiGoTo,
            this.bbiSelectAll,
            this.bbiTimeDate,
            this.bblCursorPosition,
            this.skinBarSubItem1,
            this.bbiPrint});
            this.bmMenus.MainMenu = this.menuBar;
            this.bmMenus.MaxItemId = 38;
            this.bmMenus.StatusBar = this.statusBar;
            // 
            // menuBar
            // 
            this.menuBar.BarName = "Main menu";
            this.menuBar.DockCol = 0;
            this.menuBar.DockRow = 0;
            this.menuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.menuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuFormat),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuView),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuHelp)});
            this.menuBar.OptionsBar.AllowQuickCustomization = false;
            this.menuBar.OptionsBar.DrawBorder = false;
            this.menuBar.OptionsBar.DrawDragBorder = false;
            this.menuBar.OptionsBar.MultiLine = true;
            this.menuBar.OptionsBar.UseWholeRow = true;
            this.menuBar.Text = "Main menu";
            // 
            // mnuFile
            // 
            this.mnuFile.Caption = "&Menu";
            this.mnuFile.Id = 0;
            this.mnuFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuFile.ImageOptions.Image")));
            this.mnuFile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnuFile.ImageOptions.LargeImage")));
            this.mnuFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiOpen),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSaveas),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPrint, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExit, true)});
            this.mnuFile.Name = "mnuFile";
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "&New               Ctrl+N";
            this.bbiNew.Id = 11;
            this.bbiNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiNew.ImageOptions.Image")));
            this.bbiNew.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiNew.ImageOptions.LargeImage")));
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiOpen
            // 
            this.bbiOpen.Caption = "&Open             Ctrl+O";
            this.bbiOpen.Id = 12;
            this.bbiOpen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiOpen.ImageOptions.Image")));
            this.bbiOpen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiOpen.ImageOptions.LargeImage")));
            this.bbiOpen.Name = "bbiOpen";
            this.bbiOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiOpen_ItemClick);
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "&Save               Ctrl+S";
            this.bbiSave.Id = 3;
            this.bbiSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiSave.ImageOptions.Image")));
            this.bbiSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiSave.ImageOptions.LargeImage")));
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiSaveas
            // 
            this.bbiSaveas.Caption = "Save&As";
            this.bbiSaveas.Id = 9;
            this.bbiSaveas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiSaveas.ImageOptions.Image")));
            this.bbiSaveas.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiSaveas.ImageOptions.LargeImage")));
            this.bbiSaveas.Name = "bbiSaveas";
            this.bbiSaveas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSaveas_ItemClick);
            // 
            // bbiPrint
            // 
            this.bbiPrint.Caption = "Print ...";
            this.bbiPrint.Id = 37;
            this.bbiPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiPrint.ImageOptions.Image")));
            this.bbiPrint.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiPrint.ImageOptions.LargeImage")));
            this.bbiPrint.Name = "bbiPrint";
            this.bbiPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrint_ItemClick);
            // 
            // bbiExit
            // 
            this.bbiExit.Caption = "E&xit";
            this.bbiExit.Id = 10;
            this.bbiExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiExit.ImageOptions.Image")));
            this.bbiExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiExit.ImageOptions.LargeImage")));
            this.bbiExit.Name = "bbiExit";
            this.bbiExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExit_ItemClick);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Caption = "&Edit";
            this.mnuEdit.Id = 13;
            this.mnuEdit.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiUndo, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiCut, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiCopy),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPaste),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiFind, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiFindNext),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiReplace),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiGoTo),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiSelectAll, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiTimeDate)});
            this.mnuEdit.Name = "mnuEdit";
            // 
            // bbiUndo
            // 
            this.bbiUndo.Caption = "&Undo                    Ctrl+Z";
            this.bbiUndo.Id = 21;
            this.bbiUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiUndo.ImageOptions.Image")));
            this.bbiUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiUndo.ImageOptions.LargeImage")));
            this.bbiUndo.Name = "bbiUndo";
            this.bbiUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiUndo_ItemClick);
            // 
            // bbiCut
            // 
            this.bbiCut.Caption = "&Cut                       Ctrl+X";
            this.bbiCut.Hint = "Ctrl+X";
            this.bbiCut.Id = 22;
            this.bbiCut.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiCut.ImageOptions.Image")));
            this.bbiCut.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiCut.ImageOptions.LargeImage")));
            this.bbiCut.Name = "bbiCut";
            this.bbiCut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCut_ItemClick);
            // 
            // bbiCopy
            // 
            this.bbiCopy.Caption = "Copy                    Ctrl+C";
            this.bbiCopy.Id = 23;
            this.bbiCopy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiCopy.ImageOptions.Image")));
            this.bbiCopy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiCopy.ImageOptions.LargeImage")));
            this.bbiCopy.Name = "bbiCopy";
            this.bbiCopy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCopy_ItemClick);
            // 
            // bbiPaste
            // 
            this.bbiPaste.Caption = "Paste                    Ctrl+V";
            this.bbiPaste.Id = 24;
            this.bbiPaste.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiPaste.ImageOptions.Image")));
            this.bbiPaste.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiPaste.ImageOptions.LargeImage")));
            this.bbiPaste.Name = "bbiPaste";
            this.bbiPaste.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPaste_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete                  Del";
            this.bbiDelete.Id = 25;
            this.bbiDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDelete.ImageOptions.Image")));
            this.bbiDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDelete.ImageOptions.LargeImage")));
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiFind
            // 
            this.bbiFind.Caption = "Find                     Ctrl+F";
            this.bbiFind.Enabled = false;
            this.bbiFind.Id = 26;
            this.bbiFind.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiFind.ImageOptions.Image")));
            this.bbiFind.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiFind.ImageOptions.LargeImage")));
            this.bbiFind.Name = "bbiFind";
            this.bbiFind.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFind_ItemClick);
            // 
            // bbiFindNext
            // 
            this.bbiFindNext.Caption = "Find Next            F3";
            this.bbiFindNext.Enabled = false;
            this.bbiFindNext.Id = 27;
            this.bbiFindNext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiFindNext.ImageOptions.Image")));
            this.bbiFindNext.Name = "bbiFindNext";
            this.bbiFindNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFindNext_ItemClick);
            // 
            // bbiReplace
            // 
            this.bbiReplace.Caption = "Replace...            Ctrl+H";
            this.bbiReplace.Enabled = false;
            this.bbiReplace.Id = 28;
            this.bbiReplace.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiReplace.ImageOptions.Image")));
            this.bbiReplace.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiReplace.ImageOptions.LargeImage")));
            this.bbiReplace.Name = "bbiReplace";
            this.bbiReplace.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReplace_ItemClick);
            // 
            // bbiGoTo
            // 
            this.bbiGoTo.Caption = "Go To...               Ctrl+G";
            this.bbiGoTo.Enabled = false;
            this.bbiGoTo.Id = 29;
            this.bbiGoTo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiGoTo.ImageOptions.Image")));
            this.bbiGoTo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiGoTo.ImageOptions.LargeImage")));
            this.bbiGoTo.Name = "bbiGoTo";
            this.bbiGoTo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGoTo_ItemClick);
            // 
            // bbiSelectAll
            // 
            this.bbiSelectAll.Caption = "Select All             Ctrl+A";
            this.bbiSelectAll.Enabled = false;
            this.bbiSelectAll.Id = 30;
            this.bbiSelectAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiSelectAll.ImageOptions.Image")));
            this.bbiSelectAll.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiSelectAll.ImageOptions.LargeImage")));
            this.bbiSelectAll.Name = "bbiSelectAll";
            this.bbiSelectAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSelectAll_ItemClick);
            // 
            // bbiTimeDate
            // 
            this.bbiTimeDate.Caption = "Time/Date           F5";
            this.bbiTimeDate.Id = 31;
            this.bbiTimeDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiTimeDate.ImageOptions.Image")));
            this.bbiTimeDate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiTimeDate.ImageOptions.LargeImage")));
            this.bbiTimeDate.Name = "bbiTimeDate";
            this.bbiTimeDate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTimeDate_ItemClick);
            // 
            // mnuFormat
            // 
            this.mnuFormat.Caption = "F&ormat";
            this.mnuFormat.Id = 15;
            this.mnuFormat.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiWrapWord),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiFont)});
            this.mnuFormat.Name = "mnuFormat";
            // 
            // bbiWrapWord
            // 
            this.bbiWrapWord.Caption = "&Word Wrap";
            this.bbiWrapWord.Id = 19;
            this.bbiWrapWord.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiWrapWord.ImageOptions.Image")));
            this.bbiWrapWord.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiWrapWord.ImageOptions.LargeImage")));
            this.bbiWrapWord.Name = "bbiWrapWord";
            this.bbiWrapWord.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiWrapWord_CheckedChanged);
            // 
            // bbiFont
            // 
            this.bbiFont.Caption = "&Font...";
            this.bbiFont.Id = 20;
            this.bbiFont.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiFont.ImageOptions.Image")));
            this.bbiFont.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiFont.ImageOptions.LargeImage")));
            this.bbiFont.Name = "bbiFont";
            this.bbiFont.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiFont_ItemClick);
            // 
            // mnuView
            // 
            this.mnuView.Caption = "&View";
            this.mnuView.Id = 4;
            this.mnuView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuView.ImageOptions.Image")));
            this.mnuView.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnuView.ImageOptions.LargeImage")));
            this.mnuView.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bchkStatusBarVisibility),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1)});
            this.mnuView.Name = "mnuView";
            // 
            // bchkStatusBarVisibility
            // 
            this.bchkStatusBarVisibility.BindableChecked = true;
            this.bchkStatusBarVisibility.Caption = "&Status Bar";
            this.bchkStatusBarVisibility.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.bchkStatusBarVisibility.Checked = true;
            this.bchkStatusBarVisibility.Id = 5;
            this.bchkStatusBarVisibility.Name = "bchkStatusBarVisibility";
            this.bchkStatusBarVisibility.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bchkStatusBarVisibility_CheckedChanged);
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Skins";
            this.skinBarSubItem1.Id = 36;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // mnuHelp
            // 
            this.mnuHelp.Caption = "&Help";
            this.mnuHelp.Id = 16;
            this.mnuHelp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAbout)});
            this.mnuHelp.Name = "mnuHelp";
            // 
            // bbiAbout
            // 
            this.bbiAbout.Caption = "&About";
            this.bbiAbout.Id = 17;
            this.bbiAbout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiAbout.ImageOptions.Image")));
            this.bbiAbout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiAbout.ImageOptions.LargeImage")));
            this.bbiAbout.Name = "bbiAbout";
            this.bbiAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAbout_ItemClick);
            // 
            // statusBar
            // 
            this.statusBar.BarName = "Status bar";
            this.statusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.statusBar.DockCol = 0;
            this.statusBar.DockRow = 0;
            this.statusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.statusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bblCursorPosition)});
            this.statusBar.OptionsBar.AllowQuickCustomization = false;
            this.statusBar.OptionsBar.DrawDragBorder = false;
            this.statusBar.OptionsBar.UseWholeRow = true;
            this.statusBar.Text = "Status bar";
            // 
            // bblCursorPosition
            // 
            this.bblCursorPosition.Caption = "Ln 1, Col 1";
            this.bblCursorPosition.Id = 35;
            this.bblCursorPosition.Name = "bblCursorPosition";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bmMenus;
            this.barDockControlTop.Size = new System.Drawing.Size(1006, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 550);
            this.barDockControlBottom.Manager = this.bmMenus;
            this.barDockControlBottom.Size = new System.Drawing.Size(1006, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.bmMenus;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 530);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1006, 20);
            this.barDockControlRight.Manager = this.bmMenus;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 530);
            // 
            // prntDlg
            // 
            this.prntDlg.UseEXDialog = true;
            // 
            // Wotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 575);
            this.Controls.Add(this.medtContent);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Wotepad";
            this.Text = "Wotepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wotepad_FormClosing);
            this.Load += new System.EventHandler(this.wotepad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medtContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmMenus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraSpellChecker.SpellChecker splchkrWotepad;
        private DevExpress.XtraBars.BarManager bmMenus;
        private DevExpress.XtraBars.Bar menuBar;
        private DevExpress.XtraBars.BarSubItem mnuFile;
        private DevExpress.XtraBars.Bar statusBar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarSubItem mnuView;
        private DevExpress.XtraBars.BarCheckItem bchkStatusBarVisibility;
        private DevExpress.XtraBars.BarButtonItem bbiSaveas;
        private DevExpress.XtraBars.BarButtonItem bbiExit;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiOpen;
        private DevExpress.XtraBars.BarSubItem mnuEdit;
        private DevExpress.XtraBars.BarSubItem mnuFormat;
        private DevExpress.XtraBars.BarSubItem mnuHelp;
        private DevExpress.XtraBars.BarButtonItem bbiAbout;
        private DevExpress.XtraBars.BarCheckItem bbiWrapWord;
        private DevExpress.XtraBars.BarButtonItem bbiFont;
        private DevExpress.XtraBars.BarButtonItem bbiUndo;
        private DevExpress.XtraBars.BarButtonItem bbiCut;
        private DevExpress.XtraBars.BarButtonItem bbiCopy;
        private DevExpress.XtraBars.BarButtonItem bbiPaste;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiFind;
        private DevExpress.XtraBars.BarButtonItem bbiFindNext;
        private DevExpress.XtraBars.BarButtonItem bbiReplace;
        private DevExpress.XtraBars.BarButtonItem bbiGoTo;
        private DevExpress.XtraBars.BarButtonItem bbiSelectAll;
        private DevExpress.XtraBars.BarButtonItem bbiTimeDate;
        private DevExpress.XtraBars.BarStaticItem bblCursorPosition;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraEditors.MemoEdit medtContent;
        private DevExpress.XtraBars.BarButtonItem bbiPrint;
        private System.Windows.Forms.PrintDialog prntDlg;
    }
}

