using System;
using System.Windows.Forms;

namespace NotepadExt
{
    //-----------------------------------------------------------------------------------------------------
    public partial class DialogFind : Form
    {
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
<<<<<<< HEAD
        public FindNextPrefs FindNextProps
        {
            get { return FindNextConfigs; }
            internal set { FindNextConfigs = value; }
        }
        public DialogFind(NotepadExt mainapp)
=======
        public DialogFind()
>>>>>>> ReplaceText
        {
            InitializeComponent();

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
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnFindNext_Click(object sender, EventArgs e)
        {
            findNext(FindNextConfigs);
        }

        //-----------------------------------------------------------------------------------------------------
        /// <summary>
        /// Searches the richtextarea for the text specified by the configurations passed.
        /// </summary>
        /// <param name="Configs"></param>
        public void findNext(FindNextPrefs Configs)
        {
            //GenFindNextQuery();
            int StartPosition = -1;
            int SelectStartPosition = -1;
            StringComparison SearchType = Configs.HardMatch ?
            StringComparison.CurrentCulture :
            StringComparison.CurrentCultureIgnoreCase;

            if (Configs.SearchDirection == "UP")
            {
                SelectStartPosition = Editor.Text.LastIndexOf(Configs.SearchString, Editor.SelectionStart, SearchType);
                if (SelectStartPosition > -1 && (SelectStartPosition + Configs.SearchString.Length) <= Editor.Text.Length)
                {
                    Editor.Select(SelectStartPosition, Configs.SearchString.Length);
                }

            }
            else
            {
                StartPosition = Editor.SelectedText.Length > 0 ?
                Editor.SelectionStart + Configs.SearchString.Length :
                Editor.SelectionStart;

                SelectStartPosition = Editor.Text.IndexOf(Configs.SearchString, StartPosition, SearchType);

                if (SelectStartPosition > -1 && (SelectStartPosition + Configs.SearchString.Length) <= Editor.Text.Length)
                {
                    Editor.Select(SelectStartPosition, Configs.SearchString.Length);
                }

            }

        }


    }
}