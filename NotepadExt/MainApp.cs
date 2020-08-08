using System;
using System.IO;
using System.Windows.Forms;

namespace NotepadExt
{

    //-----------------------------------------------------------------------------------------------------
    public partial class NotepadExt : Form
    {
        NpExtFileStruct FileStruct = new NpExtFileStruct();
        float ZoomFactor = 1.0f;
        static String _AppName = "NotepadExt";
        FindNextPrefs FindNextConfig = new FindNextPrefs();
        DialogFind FindDialog;

        //-----------------------------------------------------------------------------------------------------
        public NotepadExt()
        {
            InitializeComponent();

            FileStruct.InitializeStruct();
            this.Text = FileStruct.FileName + " - " + _AppName;
            FindDialog = new DialogFind(this);
            FindDialog.Editor = TypeArea;
        }
        //-----------------------------------------------------------------------------------------------------
        private void btnReadOnly_Click(object sender, EventArgs e)
        {
            TypeArea.ReadOnly = !TypeArea.ReadOnly;
            btnReadOnly.Checked = TypeArea.ReadOnly;
        }

        //-----------------------------------------------------------------------------------------------------
        private void NotepadExt_Load(object sender, EventArgs e)
        {
            btnToggleStatusBar.Checked = npExtStatusBar.Visible;
            npExtStatusBar.Visible = !btnWordWrap.Checked;
            FileStruct.StatusStripState = !btnWordWrap.Checked ? true : false;
            btnToggleStatusBar.Checked = !btnWordWrap.Checked ? true : false;
            btnToggleStatusBar.Enabled = !btnWordWrap.Checked ? true : false;
            //FileStruct.StatusStripState = btnToggleStatusBar.Checked;
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnWordWrap_Click(object sender, EventArgs e)
        {
            TypeArea.WordWrap = !TypeArea.WordWrap;
            btnWordWrap.Checked = TypeArea.WordWrap;
            if (npExtStatusBar.Visible == true)
            {
                npExtStatusBar.Visible = false;
                btnToggleStatusBar.Enabled = false;
            }
            else
            {

                if (FileStruct.StatusStripState == true)
                {
                    btnToggleStatusBar.Enabled = true;
                    npExtStatusBar.Visible = true;
                }
                else
                {
                    btnToggleStatusBar.Enabled = !btnToggleStatusBar.Enabled;
                }

            }

        }

        //-----------------------------------------------------------------------------------------------------
        private void btnFontDialog_Click(object sender, EventArgs e)
        {
            FontDialog fntDialog = new FontDialog();
            fntDialog.ShowDialog();
            TypeArea.Font = fntDialog.Font;
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnUndo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TypeArea.CanUndo.ToString());
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            TypeArea.Text = String.Empty;
            fileDialog.InitialDirectory = Application.StartupPath;
            fileDialog.ShowDialog();
            if (fileDialog.FileName != String.Empty)
            {
                String[] content = File.ReadAllLines(fileDialog.FileName);
                int linecount = content.Length - 1;
                for (int i = 0; i < content.Length; i++)
                {
                    TypeArea.AppendText(content[i]);
                    if (i + 1 != content.Length)
                        TypeArea.AppendText(Environment.NewLine);
                }
                NotepadExt.ActiveForm.Text = fileDialog.SafeFileName + " - " + _AppName;
                FileStruct.UpdateFileStruct(fileDialog);
            }
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnInZoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ZoomFactor.ToString());
            if (ZoomFactor == 64)
            {
                TypeArea.ZoomFactor = 63.9999f;
                MessageBox.Show("Maximum Zoom In Achieved",
                "Zoom Level",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
            else if (TypeArea.ZoomFactor + ZoomFactor < 64.0f)
                TypeArea.ZoomFactor = TypeArea.ZoomFactor + ZoomFactor;
            else
                MessageBox.Show("Maximum Zoom In Achieved",
                "Zoom Level",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnOutZoom_Click(object sender, EventArgs e)
        {
            if (ZoomFactor == 64)
            {
                TypeArea.ZoomFactor = 1.0f;
                MessageBox.Show("Maximum Zoom Out Achieved",
                "Zoom Level",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
            else if (TypeArea.ZoomFactor - ZoomFactor > 0)
                TypeArea.ZoomFactor = TypeArea.ZoomFactor - ZoomFactor;
            else
                MessageBox.Show("Maximum Zoom Out Achieved",
                "Zoom Level",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnZoomFactor_Click(object sender, EventArgs e)
        {
            using (zoomFactDialog ZFD = new zoomFactDialog())
            {
                if (ZFD.ShowDialog() == DialogResult.OK && ZFD.zoomfactor >= 1.0f && ZFD.zoomfactor <= 64.0f)
                {
                    ZoomFactor = ZFD.zoomfactor;
                }
                else
                {
                    MessageBox.Show("Invalid Zoom Factor. Must be between 1.0 to 64.0. Using Defaults",
                    "Invalid Zoom Factor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    ZoomFactor = 1.0f;
                }
                //MessageBox.Show(ZoomFactor.ToString());
            }
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnToggleStatusBar_Click(object sender, EventArgs e)
        {
            npExtStatusBar.Visible = !npExtStatusBar.Visible;
            btnToggleStatusBar.Checked = npExtStatusBar.Visible;
            FileStruct.StatusStripState = npExtStatusBar.Visible ? true : false;
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnAllSelect_Click(object sender, EventArgs e)
        {
            TypeArea.SelectAll();
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnCut_Click(object sender, EventArgs e)
        {
            TypeArea.Cut();
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnCopy_Click(object sender, EventArgs e)
        {
            TypeArea.Copy();
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnPaste_Click(object sender, EventArgs e)
        {
            TypeArea.Paste();
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DELETE}");
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnDateTime_Click(object sender, EventArgs e)
        {
            TypeArea.AppendText(System.DateTime.Now.ToString());
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnSaveas_Click(object sender, EventArgs e)
        {

            SaveFile();
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnNewFile_Click(object sender, EventArgs e)
        {
            //_NpExtFileStruct FileStruct = new _NpExtFileStruct();
            if (FileStruct.SaveState == false)
            {
                DialogResult ResultDialog = MessageBox.Show("Sure?", "Unsaved Document", MessageBoxButtons.YesNoCancel);
                if (ResultDialog == DialogResult.Yes)
                {
                    SaveFile();
                }
                else if (ResultDialog == DialogResult.No)
                {
                    TypeArea.Clear();
                    FileStruct.InitializeStruct();
                }
            }

        }
        //-----------------------------------------------------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFile();

        }
        //-----------------------------------------------------------------------------------------------------
        private void TypeArea_TextChanged(object sender, EventArgs e)
        {
            FileStruct.SaveState = false;
        }

        //-----------------------------------------------------------------------------------------------------
        private void SaveFile()
        {
            String DiskPath = FileStruct.ActualFile;
            String[] textLines = TypeArea.Text.Split('\n');
            if (FileStruct.SaveState == false && FileStruct.LoadfromDisk == true)
            {
                //File.WriteAllText(DiskPath, "");
                File.WriteAllLines(DiskPath, textLines);
            }
            else
            {
                SaveAsFile();

            }
        }

        //-----------------------------------------------------------------------------------------------------
        private void SaveAsFile()
        {
            String[] textLines = null;
            if (TypeArea.Lines.Length > 0)
            {
                textLines = TypeArea.Text.Split('\n');
            }
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string File_DiskPath = saveFileDialog.FileName;
                File.WriteAllLines(File_DiskPath, textLines);
            }
        }
        //-----------------------------------------------------------------------------------------------------
        struct NpExtFileStruct
        {

            bool _preExist,
            _isDiskLoaded,
            _isSaved,
            _StripState;

            String _FilePath,
            _FileName,
            _FileExt,
            _actuaFileName;

            //Methods for updating/modifying file structure
            //-----------------------------------------------------------------------------------------------------
            public void InitializeStruct()
            {
                this._preExist = false;
                this._isDiskLoaded = false;
                this._isSaved = false;

                this._FilePath = null;
                this._FileName = "Untitled";
                this._FileExt = null;
                this._actuaFileName = null;
            }
            //-----------------------------------------------------------------------------------------------------
            public void UpdateFileStruct(OpenFileDialog filedialog)
            {
                //Updating file structure fields from opened file via file dialog
                this._actuaFileName = filedialog.FileName;
                this._FileName = filedialog.SafeFileName;
                this._FilePath = filedialog.FileName.Substring(0, filedialog.FileName.LastIndexOf("\\"));
                this._FileExt = filedialog.SafeFileName.Substring(filedialog.SafeFileName.LastIndexOf(".") + 1);
                //MessageBox.Show(this._FileExt);
                //updating necessary structure booleans
                this._preExist = false;
                this._isDiskLoaded = true;
                this._isSaved = true;
            }
            //Methods

            //-----------------------------------------------------------------------------------------------------
            public String FileName
            {
                get { return this._FileName; }
            }
            //-----------------------------------------------------------------------------------------------------
            public String FileNameExtn
            {
                get { return this._FileName + "." + this._FileExt; }
            }
            //-----------------------------------------------------------------------------------------------------
            public String Resident
            {
                get { return this._FilePath; }
            }
            //-----------------------------------------------------------------------------------------------------
            public bool StatusStripState
            {
                get { return this._StripState; }
                set { this._StripState = value; }
            }

            //-----------------------------------------------------------------------------------------------------
            public String ActualFile
            {
                get { return this._actuaFileName; }
            }
            //-----------------------------------------------------------------------------------------------------
            public bool SaveState
            {
                get
                {
                    return this._isSaved;
                }
                set
                {
                    this._isSaved = value;
                }
            }
            //-----------------------------------------------------------------------------------------------------
            public bool LoadfromDisk
            {
                get { return this._isDiskLoaded; }
                set { this._isDiskLoaded = value; }
            }
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnFind_Click(object sender, EventArgs e)
        {
            //DialogFind FD = new DialogFind(this);
            FindDialog.Editor = TypeArea;
            if (FindDialog == null)
            {
                FindDialog = new DialogFind(this);
                FindDialog.Editor = TypeArea;
            }
            FindDialog.Show();
            //FindDialog.Editor.Text = TypeArea.Text;
            //FD.Show();
            //int startpos = Find();
        }

        //-----------------------------------------------------------------------------------------------------
        private void TypeArea_SelectionChanged(object sender, EventArgs e)
        {
            int line = TypeArea.GetLineFromCharIndex(TypeArea.SelectionStart) + 1;
            int column = TypeArea.SelectionStart - TypeArea.GetFirstCharIndexOfCurrentLine() + 1;
            StripLnColLabel.Text = String.Format("Ln {0}, Col {1}", line, column);

        }

        //-----------------------------------------------------------------------------------------------------
        private void btnFindNxt_Click(object sender, EventArgs e)
        {
            //FindDialog.GenFindNextQuery();
            //FindDialog.QryFindNext();
            //FindDialog.Editor.Select(0, 2);
        }
    }
}

//int pos = TypeArea.Text.LastIndexOf("\n", TypeArea.SelectionStart);
//int line = TypeArea.GetLineFromCharIndex(TypeArea.SelectionStart) + 1;
//tStripLn.Text = String.Format("Ln {0},", line);
////LIndexLabel.Text = TypeArea.SelectionStart.ToString();
//if (pos != TypeArea.SelectionStart)
//    tStripCol.Text = String.Format("Col {0}", TypeArea.SelectionStart - pos);
//else
//{
//    int LineBeginIndex = TypeArea.Text.LastIndexOf("\n", TypeArea.SelectionStart - 1);
//    //altcol.Text = "@" + LineBeginIndex.ToString();
//    tStripCol.Text = String.Format("Col {0}", pos - LineBeginIndex);
//}
//coldebug.Text = TypeArea.SelectionStart.ToString();
//lioff.Text = pos.ToString();


