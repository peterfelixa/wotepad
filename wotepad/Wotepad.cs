/*============================================================================================
 * ||              Author      : Peter Felix A
 * ||              Added On    : 05/12/2017, 14:38
 * ||              Class Name  : wotepad.cs
 * ||              Language    : CSharp
 * ||              Copyright   : Copyright(c)Symphion Inc 2003-2017 All Right Reserved
 * =============================================================================================*/
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using wotepad.Helpers;
using wotepad.Objects;

namespace wotepad
{
    public partial class Wotepad : DevExpress.XtraEditors.XtraForm
    {
        public static int GotoLine = 0;
        const int RetCaretSymbolsCount = 2;
        CustomFindForm objCustomFindForm = null;
        CustomReplaceDialog objCustomReplaceDialog = null;

        #region Global Variable
        string _filePath = string.Empty;
        bool IsSaved = true;
        #endregion Global Variable

        #region Constructor
        public Wotepad(string filepath = "")
        {
            InitializeComponent();
            _filePath = filepath;
            DevExpress.Utils.Paint.XPaintTextRender.UseExpandTabs = true;
            DevExpress.Utils.Paint.XPaint.ForceTextRenderPaint();
        }
        #endregion Constructor

        #region Private Methods
        private void AddEnvironmentalVariable()
        {
            try
            {
                string pathvar = System.Environment.GetEnvironmentVariable("PATH");
                var name = "PATH";
                if (!pathvar.Contains(@";C:\Program Files (x86)\Symphion Inc\Wotepad"))
                {
                    var value = pathvar + @";C:\Program Files (x86)\Symphion Inc\Wotepad";
                    var target = EnvironmentVariableTarget.Machine;
                    System.Environment.SetEnvironmentVariable(name, value, target);
                }
            }
            catch (Exception) { }
        }
        private void NewDocument()
        {
            try
            {
                if (CanCloseWotePad())
                {
                    _filePath = string.Empty;
                    medtContent.Text = "";
                    this.Text = "Untitled - Wotepad";
                    IsSaved = true;
                }
            }
            catch (Exception) { }
        }
        private void OpenDocument()
        {
            if (CanCloseWotePad())
            {
                try
                {
                    OpenFileDialog objOpenFileDialog = new OpenFileDialog();
                    objOpenFileDialog.Title = "Open Dialog - Wotepad File";
                    objOpenFileDialog.CheckPathExists = true;
                    objOpenFileDialog.DefaultExt = "wtxt";
                    objOpenFileDialog.Filter = "Wotepad File (*.wtxt)|*.wtxt";
                    objOpenFileDialog.FilterIndex = 1;
                    objOpenFileDialog.RestoreDirectory = true;

                    if (objOpenFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        medtContent.Text = File.ReadAllText(objOpenFileDialog.FileName);
                        _filePath = objOpenFileDialog.FileName;
                        string strfileName = Path.GetFileName(_filePath);
                        strfileName = strfileName.Replace(".wtxt", "");
                        this.Text = strfileName + " - Wotepad";
                        IsSaved = true;

                        medtContent.Focus();
                        medtContent.SelectAll();
                        medtContent.Select(medtContent.SelectionLength, 0);
                        medtContent.ScrollToCaret();
                    }
                }
                catch (Exception) { }
            }
        }
        private void SaveDocument()
        {
            try
            {
                if (_filePath == string.Empty)
                {
                    SaveFileDialog SaveFileDialgoObject = new SaveFileDialog();
                    string fileName = string.Empty;
                    if (medtContent.Text.Length > 0)
                    {
                        if (medtContent.Lines[0].Length > 50)
                            fileName = medtContent.Lines[0].Substring(0, 50);
                        else
                            fileName = medtContent.Lines[0];
                    }
                    else
                    {
                        fileName = "*";
                    }

                    SaveFileDialgoObject.FileName = fileName;
                    SaveFileDialgoObject.Title = "Save Dialog - Wotepad File";
                    SaveFileDialgoObject.CheckPathExists = true;
                    SaveFileDialgoObject.DefaultExt = "wtxt";
                    SaveFileDialgoObject.Filter = "Wotepad File (*.wtxt)|*.wtxt";
                    SaveFileDialgoObject.FilterIndex = 1;
                    SaveFileDialgoObject.RestoreDirectory = true;

                    if (SaveFileDialgoObject.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(SaveFileDialgoObject.FileName, medtContent.Text);
                        _filePath = SaveFileDialgoObject.FileName;

                        string strfileName = Path.GetFileName(_filePath);
                        strfileName = strfileName.Replace(".wtxt", "");
                        this.Text = strfileName + " - Wotepad";
                        IsSaved = true;
                    }
                }
                else
                {
                    File.WriteAllText(_filePath, medtContent.Text);
                    IsSaved = true;
                }
            }
            catch (Exception) { }
        }
        private void SaveAsDocument()
        {
            try
            {
                SaveFileDialog SaveFileDialgoObject = new SaveFileDialog();
                string fileName = string.Empty;
                if (medtContent.Lines[0].Length > 50)
                    fileName = medtContent.Lines[0].Substring(0, 50);
                else
                    fileName = medtContent.Lines[0];
                SaveFileDialgoObject.FileName = fileName;
                SaveFileDialgoObject.Title = "Save As Dialog - Wotepad File";
                SaveFileDialgoObject.CheckPathExists = true;
                SaveFileDialgoObject.DefaultExt = "wtxt";
                SaveFileDialgoObject.Filter = "Wotepad File (*.wtxt)|*.wtxt";
                SaveFileDialgoObject.FilterIndex = 1;
                SaveFileDialgoObject.RestoreDirectory = true;

                if (SaveFileDialgoObject.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(SaveFileDialgoObject.FileName, medtContent.Text);
                    _filePath = SaveFileDialgoObject.FileName;

                    string strfileName = Path.GetFileName(_filePath);
                    strfileName = strfileName.Replace(".wtxt", "");
                    this.Text = strfileName + " - Wotepad";
                    IsSaved = true;
                }
            }
            catch (Exception) { }
        }
        private bool CanCloseWotePad()
        {
            bool canClose = true;
            try
            {
                if (!IsSaved)
                {
                    if (_filePath == string.Empty) // If new wotepad document
                    {
                        if (medtContent.Text.Length > 0) //If new wotepad document has content(not erased completely after typing)
                        {
                            DialogResult dr = XtraMessageBox.Show("Do you want to save the Changes?", "Wotepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                            if (dr == System.Windows.Forms.DialogResult.Yes)
                            {
                                SaveDocument();
                                canClose = true;
                            }
                            else if (dr == System.Windows.Forms.DialogResult.Cancel)
                            {
                                canClose = false;
                            }
                            else if (dr == System.Windows.Forms.DialogResult.No)
                            {
                                //Application.Exit();
                                canClose = true;
                            }
                        }
                    }
                    else //Existing document change(we must save everything)
                    {
                        DialogResult dr = XtraMessageBox.Show("Do you want to save the Changes?", "Wotepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (dr == System.Windows.Forms.DialogResult.Yes)
                        {
                            SaveDocument();
                            canClose = true;
                        }
                        else if (dr == System.Windows.Forms.DialogResult.Cancel)
                        {
                            canClose = false;
                        }
                        else if (dr == System.Windows.Forms.DialogResult.No)
                        {
                            //Application.Exit();
                            canClose = true;
                        }
                    }
                }
            }
            catch (Exception) { }
            return canClose;
        }
        private void ApplyAppSettings()
        {
            try
            {
                bbiWrapWord.Checked = AppSettings.EditorSettings.Editor_WordWrap;
                bchkStatusBarVisibility.Checked = AppSettings.ShowStatusBar;

                FontStyle fs = AppSettings.EditorFont.Editor_FontStyle;
                if (AppSettings.EditorFont.Editor_UnderLine == true)
                    fs = fs | FontStyle.Underline;
                medtContent.Font = new Font(AppSettings.EditorFont.Editor_FontName, AppSettings.EditorFont.Editor_FontSize, fs);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void InsertCurrentDateTime()
        {
            try
            {
                medtContent.Text = medtContent.Text.Insert(medtContent.SelectionStart, DateTime.Now.ToString());
                medtContent.Focus();
                medtContent.SelectAll();
                medtContent.Select(medtContent.SelectionLength, 0);
                medtContent.ScrollToCaret();
            }
            catch (Exception) { }
        }
        private void SelectAllText()
        {
            try
            {
                medtContent.Focus();
                medtContent.SelectAll();
                medtContent.Select(0, medtContent.Text.Length);
                medtContent.ScrollToCaret();
            }
            catch (Exception) { }
        }
        private void DeleteSelected()
        {
            if (medtContent.SelectedText != string.Empty)
            {
                medtContent.SelectedText = string.Empty;
            }
        }
        private void GotoLineNumber()
        {
            try
            {
                if (medtContent.Lines.Count() > 0)
                {
                    CustomGoto objGoto = new CustomGoto(medtContent.Lines.Count(), medtContent.MaskBox.GetLineFromCharIndex(medtContent.SelectionStart) + 1);
                    DialogResult dr = objGoto.ShowDialog();
                    if (dr == System.Windows.Forms.DialogResult.OK)
                    {
                        SetCaretToLine(medtContent, GotoLine);
                    }
                }
            }
            catch (Exception) { }
        }
        private void ChangeCarrotPositionDisplay()
        {
            if (medtContent.SelectionLength == 0)
            {
                int lineIndex = medtContent.MaskBox.GetLineFromCharIndex(medtContent.SelectionStart) + 1;
                int colIndex = medtContent.MaskBox.MaskBoxSelectionStart - medtContent.MaskBox.GetFirstCharIndexOfCurrentLine() + 1;
                bblCursorPosition.Caption = "Ln " + lineIndex + ", Col " + colIndex;
            }
            else
            {
                int lineIndex = medtContent.MaskBox.GetLineFromCharIndex(medtContent.SelectionStart) + 1;
                int colIndex = medtContent.MaskBox.MaskBoxSelectionStart + 1;
                bblCursorPosition.Caption = "Ln " + lineIndex + ", Col " + colIndex;
            }
        }
        void SetCaretToLine(MemoEdit memoEdit, int lineIndex)
        {
            if (lineIndex >= memoEdit.Lines.Length) return;
            int lineStart = 0;
            for (int i = 0; i < lineIndex; i++)
            {
                lineStart += memoEdit.Lines[i].Length + RetCaretSymbolsCount;
            }
            memoEdit.SelectionStart = lineStart;
            memoEdit.SelectionLength = 0;
            memoEdit.ScrollToCaret();
        }

        #region Find Related Methods
        private void ShowFindForm()
        {
            try
            {
                if (objCustomFindForm == null)
                {
                    objCustomFindForm = new CustomFindForm();
                    objCustomFindForm.OnFindNextString += objCustomFindForm_OnFindNextString;
                }
                objCustomFindForm.ShowDialog();
            }
            catch (Exception) { }
        }
        private void DoFindDown(string searchText)
        {
            try
            {
                if (FindReplaceObjects.SearchCount == 0)
                {
                    medtContent.SelectionStart = 0;
                    medtContent.ScrollToCaret();

                    int startIndex = 0;
                    if (FindReplaceObjects.MatchCase)
                        startIndex = medtContent.Text.IndexOf(searchText);
                    else
                        startIndex = medtContent.Text.ToLower().IndexOf(searchText.ToLower());

                    if (startIndex >= 0)
                    {
                        medtContent.SelectionStart = startIndex;
                        medtContent.SelectionLength = searchText.Length;
                        medtContent.ScrollToCaret();
                        FindReplaceObjects.SearchCount = FindReplaceObjects.SearchCount + 1;
                    }
                    else
                    {
                        XtraMessageBox.Show("Can not find \"" + FindReplaceObjects.FindString + "\"", "Wotepad 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    int startIndex = 0;
                    if (FindReplaceObjects.MatchCase)
                        startIndex = medtContent.Text.Substring(medtContent.SelectionStart + medtContent.SelectionLength)
                        .IndexOf(searchText);
                    else
                        startIndex = medtContent.Text.Substring(medtContent.SelectionStart + medtContent.SelectionLength)
                        .ToLower().IndexOf(searchText.ToLower());

                    if (startIndex >= 0)
                    {
                        startIndex = startIndex + medtContent.SelectionStart + medtContent.SelectionLength;
                        medtContent.SelectionStart = startIndex;
                        medtContent.SelectionLength = searchText.Length;
                        medtContent.ScrollToCaret();
                        FindReplaceObjects.SearchCount = FindReplaceObjects.SearchCount + 1;
                    }
                    else
                    {
                        XtraMessageBox.Show("Can not find \"" + FindReplaceObjects.FindString + "\"", "Wotepad 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception) { }
        }
        private void DoFindUp(string searchText)
        {
            try
            {
                if (FindReplaceObjects.SearchCount == 0)
                {
                    medtContent.SelectionStart = medtContent.Text.Length;
                    medtContent.ScrollToCaret();

                    int startIndex = 0;
                    if (FindReplaceObjects.MatchCase)
                        startIndex = medtContent.Text.LastIndexOf(searchText);
                    else
                        startIndex = medtContent.Text.ToLower().LastIndexOf(searchText.ToLower());


                    if (startIndex >= 0)
                    {
                        medtContent.SelectionStart = startIndex;
                        medtContent.SelectionLength = searchText.Length;
                        medtContent.ScrollToCaret();
                        FindReplaceObjects.SearchCount = FindReplaceObjects.SearchCount + 1;
                    }
                    else
                    {
                        XtraMessageBox.Show("Can not find \"" + FindReplaceObjects.FindString + "\"", "Wotepad 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    int startIndex = 0;
                    if (FindReplaceObjects.MatchCase)
                        startIndex = medtContent.Text.Substring(0, medtContent.SelectionStart)
                             .LastIndexOf(searchText);
                    else
                        startIndex = medtContent.Text.Substring(0, medtContent.SelectionStart)
                         .ToLower().LastIndexOf(searchText.ToLower());

                    if (startIndex >= 0)
                    {
                        medtContent.SelectionStart = startIndex;
                        medtContent.SelectionLength = searchText.Length;
                        medtContent.ScrollToCaret();
                        FindReplaceObjects.SearchCount = FindReplaceObjects.SearchCount + 1;
                    }
                    else
                    {
                        XtraMessageBox.Show("Can not find \"" + FindReplaceObjects.FindString + "\"", "Wotepad 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception) { }
        }
        private void objCustomFindForm_OnFindNextString(string findString)
        {
            if (FindReplaceObjects.SearchDirection == FindReplaceObjects.SearchDirections.Down)
                DoFindDown(findString);
            else if (FindReplaceObjects.SearchDirection == FindReplaceObjects.SearchDirections.Up)
                DoFindUp(findString);
        }
        #endregion Find Related Methods

        #region Replace Related Methods
        private void ShowReplaceForm()
        {
            try
            {
                if (objCustomReplaceDialog == null)
                {
                    objCustomReplaceDialog = new CustomReplaceDialog();
                    objCustomReplaceDialog.OnFindNextString += objCustomReplaceDialog_OnFindNextString;
                    objCustomReplaceDialog.OnReplace += objCustomReplaceDialog_OnReplace;
                    objCustomReplaceDialog.OnReplaceAll += objCustomReplaceDialog_OnReplaceAll;
                }
                objCustomReplaceDialog.ShowDialog();
            }
            catch (Exception) { }
        }
        private void DoReplaceDown(string searchText, string replaceText)
        {
            try
            {
                int startIndex = 0;
                do
                {
                    if (FindReplaceObjects.SearchCount == 0)
                    {
                        medtContent.SelectionStart = 0;
                        medtContent.ScrollToCaret();

                        if (FindReplaceObjects.MatchCase)
                            startIndex = medtContent.Text.IndexOf(searchText);
                        else
                            startIndex = medtContent.Text.ToLower().IndexOf(searchText.ToLower());

                        if (startIndex >= 0)
                        {
                            medtContent.SelectionStart = startIndex;
                            medtContent.SelectionLength = searchText.Length;

                            medtContent.SelectedText = replaceText;

                            medtContent.ScrollToCaret();
                            FindReplaceObjects.SearchCount = FindReplaceObjects.SearchCount + 1;
                        }
                    }
                    else
                    {
                        if (FindReplaceObjects.MatchCase)
                            startIndex = medtContent.Text.Substring(medtContent.SelectionStart + medtContent.SelectionLength)
                            .IndexOf(searchText);
                        else
                            startIndex = medtContent.Text.Substring(medtContent.SelectionStart + medtContent.SelectionLength)
                            .ToLower().IndexOf(searchText.ToLower());

                        if (startIndex >= 0)
                        {
                            startIndex = startIndex + medtContent.SelectionStart + medtContent.SelectionLength;
                            medtContent.SelectionStart = startIndex;
                            medtContent.SelectionLength = searchText.Length;

                            medtContent.SelectedText = replaceText;

                            medtContent.ScrollToCaret();
                            FindReplaceObjects.SearchCount = FindReplaceObjects.SearchCount + 1;
                        }
                    }
                } while (startIndex > 0);
            }
            catch (Exception) { }
        }
        private void objCustomReplaceDialog_OnFindNextString(string findString)
        {
            if (FindReplaceObjects.SearchDirection == FindReplaceObjects.SearchDirections.Down)
                DoFindDown(findString);
            else if (FindReplaceObjects.SearchDirection == FindReplaceObjects.SearchDirections.Up)
                DoFindUp(findString);
        }
        private void objCustomReplaceDialog_OnReplace(string replaceString)
        {
            medtContent.SelectedText = replaceString;
        }
        private void objCustomReplaceDialog_OnReplaceAll(string findString, string replaceString)
        {
            DoReplaceDown(findString, replaceString);
        }
        #endregion Replace Related Methods

        private void PrintDocument()
        {
            try
            {
                PrintDocument _printdocument = new PrintDocument();
                prntDlg.ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        #endregion Private Methods

        #region Overridden Events
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                switch (keyData)
                {
                    case (Keys.Control | Keys.N):
                        NewDocument();
                        return true;
                    case (Keys.Control | Keys.O):
                        OpenDocument();
                        return true;
                    case (Keys.Control | Keys.S):
                        SaveDocument();
                        return true;


                    case (Keys.Control | Keys.Z):
                        medtContent.Undo();
                        return true;
                    case (Keys.Control | Keys.X):
                        medtContent.Cut();
                        return true;
                    case (Keys.Control | Keys.C):
                        medtContent.Copy();
                        return true;
                    case (Keys.Control | Keys.V):
                        medtContent.Paste();
                        return true;
                    case (Keys.Delete):
                        if (medtContent.SelectedText != string.Empty)
                        {
                            DeleteSelected();
                            return true;
                        }
                        break;
                    case (Keys.Control | Keys.F):
                        if (medtContent.Text.Length > 0)
                        {
                            ShowFindForm();
                        }
                        return true;
                    case (Keys.F3):
                        if (medtContent.Text.Length > 0)
                        {
                            objCustomFindForm_OnFindNextString(FindReplaceObjects.FindString);
                        }
                        return true;
                    case (Keys.Control | Keys.H):
                        if (medtContent.Text.Length > 0)
                        {
                            ShowReplaceForm();
                        }
                        return true;
                    case (Keys.Control | Keys.G):
                        if (medtContent.Text.Length > 0)
                        {
                            GotoLineNumber();
                        }
                        return true;
                    case (Keys.Control | Keys.A):
                        SelectAllText();
                        return true;
                    case (Keys.F5):
                        InsertCurrentDateTime();
                        return true;
                    case (Keys.Control | Keys.P):
                        PrintDocument();
                        return true;
                }
            }
            catch (Exception)
            {
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion Overridden Events

        private void wotepad_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.StyleChanged += new EventHandler(Default_StyleChanged);
            AddEnvironmentalVariable();
            try
            {
                ApplyAppSettings();
                if (_filePath != string.Empty)
                {
                    if (File.Exists(_filePath))
                    {
                        string readText = File.ReadAllText(_filePath);
                        medtContent.Text = readText;
                        string fileName = Path.GetFileName(_filePath);
                        fileName = fileName.Replace(".wtxt", "");
                        this.Text = fileName + " - Wotepad";
                        IsSaved = true;
                    }
                }
                else
                {
                    this.Text = "Untitled - Wotepad";
                }
            }
            catch (Exception) { }

            try
            {
                splchkrWotepad.Check(medtContent);
                medtContent.Focus();
                medtContent.SelectAll();
                medtContent.Select(medtContent.SelectionLength, 0);
                medtContent.ScrollToCaret();
            }
            catch (Exception) { }
        }
        private void wotepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool canclose = CanCloseWotePad();
            if (!canclose)
                e.Cancel = true;
        }
        private void medtContent_EditValueChanged(object sender, EventArgs e)
        {
            IsSaved = false;
            if (medtContent.Text.Length > 0 && bbiGoTo.Enabled == false)
            {
                bbiGoTo.Enabled = true;
            }
            else if (medtContent.Text.Length <= 0 && bbiGoTo.Enabled == true)
            {
                bbiGoTo.Enabled = false;
            }

            if (medtContent.Text.Length > 0)
            {
                bbiSelectAll.Enabled = true;
                bbiFind.Enabled = true;
                bbiFindNext.Enabled = true;
                bbiReplace.Enabled = true;
            }
            else
            {
                bbiSelectAll.Enabled = false;
                bbiFind.Enabled = false;
                bbiFindNext.Enabled = false;
                bbiReplace.Enabled = false;
            }
        }
        private void medtContent_KeyDown(object sender, KeyEventArgs e)
        {
            ChangeCarrotPositionDisplay();
            //Disable Following short cut keys if exists any already to memoedit control
            switch (e.KeyData)
            {
                case (Keys.Control | Keys.N):
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case (Keys.Control | Keys.O):
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case (Keys.Control | Keys.S):
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;


                case (Keys.Control | Keys.Z):
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case (Keys.Control | Keys.X):
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case (Keys.Control | Keys.C):
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case (Keys.Control | Keys.V):
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case (Keys.Delete):
                    if (medtContent.SelectedText != string.Empty)
                    {
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                    }
                    break;
                case (Keys.Control | Keys.F):
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case (Keys.F3):
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case (Keys.Control | Keys.H):
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case (Keys.Control | Keys.G):
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case (Keys.Control | Keys.A):
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;
                case (Keys.F5):
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    break;


                default:
                    e.Handled = false;
                    e.SuppressKeyPress = false;
                    break;
            }
        }
        private void medtContent_Click(object sender, EventArgs e)
        {
            ChangeCarrotPositionDisplay();
        }
        private void medtContent_KeyUp(object sender, KeyEventArgs e)
        {
            ChangeCarrotPositionDisplay();
        }

        #region File Menu Events
        //New
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewDocument();
        }
        //Open
        private void bbiOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenDocument();
        }
        //Save
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveDocument();
        }
        //Save As
        private void bbiSaveas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveAsDocument();
        }
        //Exit
        private void bbiExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool canclose = CanCloseWotePad();
            if (canclose)
                Application.Exit();
        }
        #endregion File Menu Events

        #region Edit Events
        private void bbiUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            medtContent.Undo();
        }
        private void bbiCut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            medtContent.Cut();
        }
        private void bbiCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            medtContent.Copy();
        }
        private void bbiPaste_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            medtContent.Paste();
        }
        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteSelected();
        }
        private void bbiFind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (medtContent.Text.Length > 0)
            {
                ShowFindForm();
            }
        }
        private void bbiFindNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (medtContent.Text.Length > 0)
            {
                objCustomFindForm_OnFindNextString(FindReplaceObjects.FindString);
            }
        }
        private void bbiReplace_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (medtContent.Text.Length > 0)
            {
                ShowReplaceForm();
            }
        }
        private void bbiGoTo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GotoLineNumber();
        }
        private void bbiSelectAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SelectAllText();
        }
        private void bbiTimeDate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InsertCurrentDateTime();
        }
        #endregion Edit Events

        #region Format Menu Events
        //Word Wrap
        private void bbiWrapWord_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            medtContent.Properties.WordWrap = bbiWrapWord.Checked;
            AppSettings.EditorSettings.Editor_WordWrap = bbiWrapWord.Checked;
            AppSettingsHelper objAppSettingsHelper = new AppSettingsHelper();
            objAppSettingsHelper.WriteAppSettings();
        }
        //Font
        private void bbiFont_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CustomFontDialog objCustomFontDialog = new CustomFontDialog();
            DialogResult dr = objCustomFontDialog.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                ApplyAppSettings();
            }
        }
        #endregion Format Menu Events

        #region View Menu Events
        private void bchkStatusBarVisibility_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            statusBar.Visible = bchkStatusBarVisibility.Checked;
            AppSettings.ShowStatusBar = bchkStatusBarVisibility.Checked;
            AppSettingsHelper objAppSettingsHelper = new AppSettingsHelper();
            objAppSettingsHelper.WriteAppSettings();
        }
        #endregion View Menu Events

        #region Help Menu Events
        private void bbiAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CustomAbout objAbout = new CustomAbout();
            objAbout.ShowDialog();
        }

        private void Default_StyleChanged(object sender, EventArgs e)
        {
            AppSettings.SkinName = UserLookAndFeel.Default.SkinName;
            AppSettingsHelper objAppSettingsHelper = new AppSettingsHelper();
            objAppSettingsHelper.WriteAppSettings();
        }
        #endregion Help Menu Events

        private void bbiPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintDocument();
        }
    }
}