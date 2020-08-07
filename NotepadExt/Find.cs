using System;
using System.Windows.Forms;


namespace NotepadExt
{
    //-----------------------------------------------------------------------------------------------------
    public partial class DialogFind : Form
    {
        NotepadExt mainapp;
        int startindex = 0;
        FindNextPrefs FindNextConfigs = new FindNextPrefs();
        public RichTextBox Editor { get; internal set; }

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
        }

        //-----------------------------------------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnFindNext_Click(object sender, EventArgs e)
        {
            //object TypeArea = Parent.TextArea;
            int SelectStartPosition;

            if (radioUp.Checked == true)
            {
                FindNextConfigs.SearchDirection = "UP";
                String textToFind = tbFind.Text;
                int len = textToFind.Length;

                SelectStartPosition = cbToggleMatch.Checked ?
                Editor.Text.LastIndexOf(textToFind, Editor.SelectionStart) :
                Editor.Text.LastIndexOf(textToFind, Editor.SelectionStart, StringComparison.CurrentCultureIgnoreCase);
                //String TextAreaText = Parent.TextArea.Text.Substring(0, Parent.TextArea.SelectionStart);
                //Parent.TextArea.Text = tbFind.Text
                //int startpos = Parent.TextArea.Find(searchtext, startindex, RichTextBoxFinds.None);
                if (SelectStartPosition > -1 && (SelectStartPosition + len) <= Editor.Text.Length)
                {
                    Editor.Select(SelectStartPosition, len);
                }
            }
            else
            {
                FindNextConfigs.SearchDirection = "DOWN";
                String textToFind = tbFind.Text;
                int len = textToFind.Length;

                //String TextAreaText = Parent.TextArea.Text.Substring(0, Parent.TextArea.SelectionStart);
            }
            
        }


    }
}


