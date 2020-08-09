using System;
using System.Windows.Forms;

namespace NotepadExt
{
    //-----------------------------------------------------------------------------------------------------
    public partial class DialogFind : Form
    {
        NotepadExt mainapp;
        //int startindex = 0;
        FindNextPrefs FindNextConfigs = new FindNextPrefs();
        public RichTextBox Editor { get; internal set; }

        //-----------------------------------------------------------------------------------------------------
        public FindNextPrefs FindNextProps
        {
            get { return FindNextConfigs; }
            internal set { FindNextConfigs = value; }
        }
        //-----------------------------------------------------------------------------------------------------
        public void GenFindNextQuery()
        {
            FindNextConfigs.SearchString = tbFind.Text;
            FindNextConfigs.SearchDirection = radioUp.Checked ? "UP" : "Down";
            FindNextConfigs.CurrentPosition = Editor.SelectionStart;
            FindNextConfigs.HardMatch = cbToggleMatch.Checked;
            FindNextConfigs.content = Editor.Text;
        }

        //-----------------------------------------------------------------------------------------------------
        public DialogFind(NotepadExt mainapp)
        {
            InitializeComponent();
            this.mainapp = mainapp;
        }

        //-----------------------------------------------------------------------------------------------------
        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            btnFindNext.Enabled = tbFind.Text.Length > 0 ? true : false;
            GenFindNextQuery();
        }

        //-----------------------------------------------------------------------------------------------------
        private void cbToggleMatch_CheckedChanged(object sender, EventArgs e)
        {
            GenFindNextQuery();
        }

        //-----------------------------------------------------------------------------------------------------
        private void radioUp_CheckedChanged(object sender, EventArgs e)
        {
            GenFindNextQuery();
        }

        //-----------------------------------------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnFindNext_Click(object sender, EventArgs e)
        {
            findNext(FindNextConfigs);
            //int SelectStartPosition;
            //String textToFind = tbFind.Text;
            //int len = textToFind.Length;
            //if (radioUp.Checked == true)
            //{
            //    //FindNextConfigs.SearchDirection = true;
            //    SelectStartPosition = cbToggleMatch.Checked ?
            //    Editor.Text.LastIndexOf(textToFind, Editor.SelectionStart) :
            //    Editor.Text.LastIndexOf(textToFind, Editor.SelectionStart, StringComparison.CurrentCultureIgnoreCase);
            //    if (SelectStartPosition > -1 && (SelectStartPosition + len) <= Editor.Text.Length)
            //    {
            //        Editor.Select(SelectStartPosition, len);
            //    }
            //}
            //else
            //{
            //    int startIndex = Editor.SelectionStart + Editor.SelectionLength;
            //    //FindNextConfigs.SearchDirection = false;
            //    SelectStartPosition = cbToggleMatch.Checked ?
            //    Editor.Text.IndexOf(textToFind, startIndex) :
            //    Editor.Text.IndexOf(textToFind, startIndex, StringComparison.CurrentCultureIgnoreCase);

            //    if (SelectStartPosition > -1 && (SelectStartPosition + len) <= Editor.Text.Length)
            //    {
            //        Editor.Select(SelectStartPosition, len);
            //    }
            //    //String TextAreaText = Parent.TextArea.Text.Substring(0, Parent.TextArea.SelectionStart);
            //}
        }

        //-----------------------------------------------------------------------------------------------------
        public void findNext(FindNextPrefs FindNextConfigs)
        {
            GenFindNextQuery();
            int StartPosition = -1;
            int SelectStartPosition = -1;
            StringComparison SearchType = FindNextConfigs.HardMatch ?
            StringComparison.CurrentCulture :
            StringComparison.CurrentCultureIgnoreCase;

            if (FindNextConfigs.SearchDirection == "UP")
            {
                SelectStartPosition = Editor.Text.LastIndexOf(FindNextConfigs.SearchString, Editor.SelectionStart, SearchType);
                if (SelectStartPosition > -1 && (SelectStartPosition + FindNextConfigs.SearchString.Length) <= Editor.Text.Length)
                {
                    Editor.Select(SelectStartPosition, FindNextConfigs.SearchString.Length);
                }

            }
            else
            {
                StartPosition = Editor.SelectedText.Length > 0 ?
                Editor.SelectionStart + FindNextConfigs.SearchString.Length :
                Editor.SelectionStart;

                SelectStartPosition = Editor.Text.IndexOf(FindNextConfigs.SearchString, StartPosition, SearchType);

                if (SelectStartPosition > -1 && (SelectStartPosition + FindNextConfigs.SearchString.Length) <= Editor.Text.Length)
                {
                    Editor.Select(SelectStartPosition, FindNextConfigs.SearchString.Length);
                }

            }

        }

    }
}



