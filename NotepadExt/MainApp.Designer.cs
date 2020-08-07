namespace NotepadExt
{
    partial class NotepadExt
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
            this.npExtMenuStrip = new System.Windows.Forms.MainMenu(this.components);
            this.mainFileList = new System.Windows.Forms.MenuItem();
            this.btnFile = new System.Windows.Forms.MenuItem();
            this.btnOpenFileDialog = new System.Windows.Forms.MenuItem();
            this.btnSave = new System.Windows.Forms.MenuItem();
            this.btnSaveas = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.btnPgSetup = new System.Windows.Forms.MenuItem();
            this.btnPrint = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.btnExit = new System.Windows.Forms.MenuItem();
            this.mainEditList = new System.Windows.Forms.MenuItem();
            this.btnUndo = new System.Windows.Forms.MenuItem();
            this.btnRedo = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.btnCut = new System.Windows.Forms.MenuItem();
            this.btnCopy = new System.Windows.Forms.MenuItem();
            this.btnPaste = new System.Windows.Forms.MenuItem();
            this.btnDelete = new System.Windows.Forms.MenuItem();
            this.menuItem22 = new System.Windows.Forms.MenuItem();
            this.btnFind = new System.Windows.Forms.MenuItem();
            this.btnFindNxt = new System.Windows.Forms.MenuItem();
            this.btnReplace = new System.Windows.Forms.MenuItem();
            this.btnGoto = new System.Windows.Forms.MenuItem();
            this.menuItem27 = new System.Windows.Forms.MenuItem();
            this.btnAllSelect = new System.Windows.Forms.MenuItem();
            this.btnDateTime = new System.Windows.Forms.MenuItem();
            this.mainFormatList = new System.Windows.Forms.MenuItem();
            this.btnWordWrap = new System.Windows.Forms.MenuItem();
            this.TypeArea = new System.Windows.Forms.RichTextBox();
            this.btnFontDialog = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.btnReadOnly = new System.Windows.Forms.MenuItem();
            this.mainViewList = new System.Windows.Forms.MenuItem();
            this.btnZoom = new System.Windows.Forms.MenuItem();
            this.btnInZoom = new System.Windows.Forms.MenuItem();
            this.btnOutZoom = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.btnZoomFactor = new System.Windows.Forms.MenuItem();
            this.btnZoomReset = new System.Windows.Forms.MenuItem();
            this.btnToggleStatusBar = new System.Windows.Forms.MenuItem();
            this.mainHelpList = new System.Windows.Forms.MenuItem();
            this.btnShowHelp = new System.Windows.Forms.MenuItem();
            this.menuItem34 = new System.Windows.Forms.MenuItem();
            this.btnAbout = new System.Windows.Forms.MenuItem();
            this.FileStat = new System.Windows.Forms.MenuItem();
            this.npExtStatusBar = new System.Windows.Forms.StatusStrip();
            this.StripLnColLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.npExtStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // npExtMenuStrip
            // 
            this.npExtMenuStrip.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mainFileList,
            this.mainEditList,
            this.mainFormatList,
            this.mainViewList,
            this.mainHelpList,
            this.FileStat});
            // 
            // mainFileList
            // 
            this.mainFileList.Index = 0;
            this.mainFileList.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.btnFile,
            this.btnOpenFileDialog,
            this.btnSave,
            this.btnSaveas,
            this.menuItem10,
            this.btnPgSetup,
            this.btnPrint,
            this.menuItem13,
            this.btnExit});
            this.mainFileList.Text = "File";
            // 
            // btnFile
            // 
            this.btnFile.Index = 0;
            this.btnFile.Text = "New";
            this.btnFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Index = 1;
            this.btnOpenFileDialog.Text = "Open...";
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // btnSave
            // 
            this.btnSave.Index = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveas
            // 
            this.btnSaveas.Index = 3;
            this.btnSaveas.Text = "Save As...";
            this.btnSaveas.Click += new System.EventHandler(this.btnSaveas_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 4;
            this.menuItem10.Text = "-";
            // 
            // btnPgSetup
            // 
            this.btnPgSetup.Index = 5;
            this.btnPgSetup.Text = "Page Setup...";
            // 
            // btnPrint
            // 
            this.btnPrint.Index = 6;
            this.btnPrint.Text = "Print";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 7;
            this.menuItem13.Text = "-";
            // 
            // btnExit
            // 
            this.btnExit.Index = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mainEditList
            // 
            this.mainEditList.Index = 1;
            this.mainEditList.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.btnUndo,
            this.btnRedo,
            this.menuItem17,
            this.btnCut,
            this.btnCopy,
            this.btnPaste,
            this.btnDelete,
            this.menuItem22,
            this.btnFind,
            this.btnFindNxt,
            this.btnReplace,
            this.btnGoto,
            this.menuItem27,
            this.btnAllSelect,
            this.btnDateTime});
            this.mainEditList.Text = "Edit";
            // 
            // btnUndo
            // 
            this.btnUndo.Index = 0;
            this.btnUndo.Text = "Undo";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Index = 1;
            this.btnRedo.Text = "Redo";
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 2;
            this.menuItem17.Text = "-";
            // 
            // btnCut
            // 
            this.btnCut.Index = 3;
            this.btnCut.Text = "Cut";
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Index = 4;
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Index = 5;
            this.btnPaste.Text = "Paste";
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Index = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // menuItem22
            // 
            this.menuItem22.Index = 7;
            this.menuItem22.Text = "-";
            // 
            // btnFind
            // 
            this.btnFind.Index = 8;
            this.btnFind.Text = "Find...";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnFindNxt
            // 
            this.btnFindNxt.Index = 9;
            this.btnFindNxt.Text = "Find next";
            this.btnFindNxt.Click += new System.EventHandler(this.btnFindNxt_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Index = 10;
            this.btnReplace.Text = "Replace...";
            // 
            // btnGoto
            // 
            this.btnGoto.Index = 11;
            this.btnGoto.Text = "Goto...";
            // 
            // menuItem27
            // 
            this.menuItem27.Index = 12;
            this.menuItem27.Text = "-";
            // 
            // btnAllSelect
            // 
            this.btnAllSelect.Index = 13;
            this.btnAllSelect.Text = "Select All";
            this.btnAllSelect.Click += new System.EventHandler(this.btnAllSelect_Click);
            // 
            // btnDateTime
            // 
            this.btnDateTime.Index = 14;
            this.btnDateTime.Text = "Time/&Date";
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            // 
            // mainFormatList
            // 
            this.mainFormatList.Index = 2;
            this.mainFormatList.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.btnWordWrap,
            this.btnFontDialog,
            this.menuItem1,
            this.btnReadOnly});
            this.mainFormatList.Text = "Format";
            // 
            // btnWordWrap
            // 
            this.btnWordWrap.Checked = this.TypeArea.WordWrap;
            this.btnWordWrap.Index = 0;
            this.btnWordWrap.Text = "Word Wrap";
            this.btnWordWrap.Click += new System.EventHandler(this.btnWordWrap_Click);
            // 
            // TypeArea
            // 
            this.TypeArea.AcceptsTab = true;
            this.TypeArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TypeArea.DetectUrls = false;
            this.TypeArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeArea.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.TypeArea.HideSelection = false;
            this.TypeArea.Location = new System.Drawing.Point(0, 0);
            this.TypeArea.Name = "TypeArea";
            this.TypeArea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.TypeArea.Size = new System.Drawing.Size(501, 271);
            this.TypeArea.TabIndex = 0;
            this.TypeArea.Text = "";
            this.TypeArea.SelectionChanged += new System.EventHandler(this.TypeArea_SelectionChanged);
            this.TypeArea.TextChanged += new System.EventHandler(this.TypeArea_TextChanged);
            // 
            // btnFontDialog
            // 
            this.btnFontDialog.Index = 1;
            this.btnFontDialog.Text = "Font...";
            this.btnFontDialog.Click += new System.EventHandler(this.btnFontDialog_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "-";
            // 
            // btnReadOnly
            // 
            this.btnReadOnly.Index = 3;
            this.btnReadOnly.Text = "Read Only";
            this.btnReadOnly.Click += new System.EventHandler(this.btnReadOnly_Click);
            // 
            // mainViewList
            // 
            this.mainViewList.Index = 3;
            this.mainViewList.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.btnZoom,
            this.btnToggleStatusBar});
            this.mainViewList.Text = "View";
            // 
            // btnZoom
            // 
            this.btnZoom.Index = 0;
            this.btnZoom.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.btnInZoom,
            this.btnOutZoom,
            this.menuItem4,
            this.btnZoomFactor,
            this.btnZoomReset});
            this.btnZoom.Text = "Zoom";
            // 
            // btnInZoom
            // 
            this.btnInZoom.Index = 0;
            this.btnInZoom.Text = "Zoom In";
            this.btnInZoom.Click += new System.EventHandler(this.btnInZoom_Click);
            // 
            // btnOutZoom
            // 
            this.btnOutZoom.Index = 1;
            this.btnOutZoom.Text = "Zoom Out";
            this.btnOutZoom.Click += new System.EventHandler(this.btnOutZoom_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "-";
            // 
            // btnZoomFactor
            // 
            this.btnZoomFactor.Index = 3;
            this.btnZoomFactor.Text = "Set Zoom Factor";
            this.btnZoomFactor.Click += new System.EventHandler(this.btnZoomFactor_Click);
            // 
            // btnZoomReset
            // 
            this.btnZoomReset.Index = 4;
            this.btnZoomReset.Text = "Restore Default Zoom";
            // 
            // btnToggleStatusBar
            // 
            this.btnToggleStatusBar.Index = 1;
            this.btnToggleStatusBar.Text = "Status Bar";
            this.btnToggleStatusBar.Click += new System.EventHandler(this.btnToggleStatusBar_Click);
            // 
            // mainHelpList
            // 
            this.mainHelpList.Index = 4;
            this.mainHelpList.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.btnShowHelp,
            this.menuItem34,
            this.btnAbout});
            this.mainHelpList.Text = "Help";
            // 
            // btnShowHelp
            // 
            this.btnShowHelp.Index = 0;
            this.btnShowHelp.Text = "View Help";
            // 
            // menuItem34
            // 
            this.menuItem34.Index = 1;
            this.menuItem34.Text = "-";
            // 
            // btnAbout
            // 
            this.btnAbout.Index = 2;
            this.btnAbout.Text = "About Notepad";
            // 
            // FileStat
            // 
            this.FileStat.Index = 5;
            this.FileStat.Text = "FileStat";
            // 
            // npExtStatusBar
            // 
            this.npExtStatusBar.AutoSize = false;
            this.npExtStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripLnColLabel});
            this.npExtStatusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.npExtStatusBar.Location = new System.Drawing.Point(0, 271);
            this.npExtStatusBar.Name = "npExtStatusBar";
            this.npExtStatusBar.Size = new System.Drawing.Size(501, 23);
            this.npExtStatusBar.TabIndex = 1;
            this.npExtStatusBar.Text = "NotepadExt";
            // 
            // StripLnColLabel
            // 
            this.StripLnColLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.StripLnColLabel.AutoSize = false;
            this.StripLnColLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.StripLnColLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.StripLnColLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StripLnColLabel.Margin = new System.Windows.Forms.Padding(0, 3, 25, 2);
            this.StripLnColLabel.Name = "StripLnColLabel";
            this.StripLnColLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.StripLnColLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.StripLnColLabel.Size = new System.Drawing.Size(76, 18);
            this.StripLnColLabel.Text = "Ln 1, Col 1";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "Untitled";
            this.saveFileDialog.Filter = "Text files|*.txt|All files|*.*";
            this.saveFileDialog.InitialDirectory = "Libraries\\Documents";
            this.saveFileDialog.SupportMultiDottedExtensions = true;
            // 
            // NotepadExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 294);
            this.Controls.Add(this.TypeArea);
            this.Controls.Add(this.npExtStatusBar);
            this.Menu = this.npExtMenuStrip;
            this.Name = "NotepadExt";
            this.Text = "NotepadExt";
            this.Load += new System.EventHandler(this.NotepadExt_Load);
            this.npExtStatusBar.ResumeLayout(false);
            this.npExtStatusBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu npExtMenuStrip;
        private System.Windows.Forms.MenuItem mainFileList;
        private System.Windows.Forms.MenuItem btnFile;
        private System.Windows.Forms.MenuItem btnOpenFileDialog;
        private System.Windows.Forms.MenuItem btnSave;
        private System.Windows.Forms.MenuItem btnSaveas;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem btnPgSetup;
        private System.Windows.Forms.MenuItem btnPrint;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem btnExit;
        private System.Windows.Forms.MenuItem mainEditList;
        private System.Windows.Forms.MenuItem btnUndo;
        private System.Windows.Forms.MenuItem btnRedo;
        private System.Windows.Forms.MenuItem menuItem17;
        private System.Windows.Forms.MenuItem btnCut;
        private System.Windows.Forms.MenuItem btnCopy;
        private System.Windows.Forms.MenuItem btnPaste;
        private System.Windows.Forms.MenuItem btnDelete;
        private System.Windows.Forms.MenuItem menuItem22;
        private System.Windows.Forms.MenuItem btnFind;
        private System.Windows.Forms.MenuItem btnFindNxt;
        private System.Windows.Forms.MenuItem btnReplace;
        private System.Windows.Forms.MenuItem btnGoto;
        private System.Windows.Forms.MenuItem menuItem27;
        private System.Windows.Forms.MenuItem btnAllSelect;
        private System.Windows.Forms.MenuItem btnDateTime;
        private System.Windows.Forms.MenuItem mainFormatList;
        private System.Windows.Forms.MenuItem btnWordWrap;
        private System.Windows.Forms.MenuItem btnFontDialog;
        private System.Windows.Forms.MenuItem mainViewList;
        private System.Windows.Forms.MenuItem btnToggleStatusBar;
        private System.Windows.Forms.MenuItem mainHelpList;
        private System.Windows.Forms.MenuItem btnShowHelp;
        private System.Windows.Forms.MenuItem menuItem34;
        private System.Windows.Forms.MenuItem btnAbout;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem btnReadOnly;
        private System.Windows.Forms.MenuItem btnZoom;
        private System.Windows.Forms.MenuItem btnInZoom;
        private System.Windows.Forms.MenuItem btnOutZoom;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem btnZoomReset;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.MenuItem btnZoomFactor;
        private System.Windows.Forms.StatusStrip npExtStatusBar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.MenuItem FileStat;
        protected System.Windows.Forms.RichTextBox TypeArea;
        private System.Windows.Forms.ToolStripStatusLabel StripLnColLabel;
    }
}

