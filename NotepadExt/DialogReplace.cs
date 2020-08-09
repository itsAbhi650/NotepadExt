using System;
using System.Windows.Forms;

namespace NotepadExt
{
    //-----------------------------------------------------------------------------------------------------
    public partial class DialogReplace : Form
    {
        FindNextPrefs ReplaceConfigs = new FindNextPrefs();
        DialogFind FindDialog = new DialogFind();
        public RichTextBox Editor { get; internal set; }
        //-----------------------------------------------------------------------------------------------------
        public DialogReplace()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------------------------------------------
        /// <summary>
        /// Updates find preferences as per the changes made by the user.
        /// </summary>
        public void UpdateReplaceQuery()
        {
            ReplaceConfigs.SearchString = tbRFind.Text;
            ReplaceConfigs.SearchDirection = rbRUp.Checked ? "UP" : "Down";
            ReplaceConfigs.HardMatch = cbRMatchCase.Checked;
            ReplaceConfigs.CurrentPosition = Editor.SelectionStart;
        }

        //-----------------------------------------------------------------------------------------------------
        private void DialogReplace_Load(object sender, EventArgs e)
        {
            if (FindDialog != null)
            {
                cbRMatchCase.Checked = FindDialog.FindNextProps.HardMatch;
                if (FindDialog.FindNextProps.SearchDirection == "UP")
                {
                    rbRUp.Checked = true;
                }
                else
                {
                    rbRDown.Checked = true;
                }
            }

        }

        //-----------------------------------------------------------------------------------------------------
        private void cbRMatchCase_CheckedChanged(object sender, EventArgs e)
        {
            UpdateReplaceQuery();
        }

        //-----------------------------------------------------------------------------------------------------
        private void rbRDown_CheckedChanged(object sender, EventArgs e)
        {
            UpdateReplaceQuery();
        }

        //-----------------------------------------------------------------------------------------------------
        private void rbRUp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateReplaceQuery();
        }
        //-----------------------------------------------------------------------------------------------------
        private void btnRFindNext_Click(object sender, EventArgs e)
        {
            UpdateReplaceQuery();
            FindDialog.Editor = this.Editor;
            FindDialog.findNext(ReplaceConfigs);
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnRplc_Click(object sender, EventArgs e)
        {
            if (Editor.SelectionLength != 0)
                Editor.SelectedText = tbRplc.Text;
            else
                btnRFindNext.PerformClick();
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnRplcAll_Click(object sender, EventArgs e)
        {
            Editor.Text = Editor.Text.Replace(tbRFind.Text, tbRplc.Text);
        }

        //-----------------------------------------------------------------------------------------------------
        private void btnRExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



