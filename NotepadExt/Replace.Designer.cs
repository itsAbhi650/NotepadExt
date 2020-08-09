namespace NotepadExt
{
    partial class Replace
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
            this.btnRFindNext = new System.Windows.Forms.Button();
            this.btnRplc = new System.Windows.Forms.Button();
            this.btnRplcAll = new System.Windows.Forms.Button();
            this.btnRExit = new System.Windows.Forms.Button();
            this.tbRFind = new System.Windows.Forms.TextBox();
            this.tbRplc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRMatchCase = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnRFindNext
            // 
            this.btnRFindNext.Location = new System.Drawing.Point(258, 7);
            this.btnRFindNext.Name = "btnRFindNext";
            this.btnRFindNext.Size = new System.Drawing.Size(75, 23);
            this.btnRFindNext.TabIndex = 0;
            this.btnRFindNext.Text = "&Find Next";
            this.btnRFindNext.UseVisualStyleBackColor = true;
            this.btnRFindNext.Click += new System.EventHandler(this.btnRFindNext_Click);
            // 
            // btnRplc
            // 
            this.btnRplc.Location = new System.Drawing.Point(258, 36);
            this.btnRplc.Name = "btnRplc";
            this.btnRplc.Size = new System.Drawing.Size(75, 23);
            this.btnRplc.TabIndex = 1;
            this.btnRplc.Text = "Re&place";
            this.btnRplc.UseVisualStyleBackColor = true;
            // 
            // btnRplcAll
            // 
            this.btnRplcAll.Location = new System.Drawing.Point(258, 65);
            this.btnRplcAll.Name = "btnRplcAll";
            this.btnRplcAll.Size = new System.Drawing.Size(75, 23);
            this.btnRplcAll.TabIndex = 2;
            this.btnRplcAll.Text = "Replace &All";
            this.btnRplcAll.UseVisualStyleBackColor = true;
            // 
            // btnRExit
            // 
            this.btnRExit.Location = new System.Drawing.Point(258, 94);
            this.btnRExit.Name = "btnRExit";
            this.btnRExit.Size = new System.Drawing.Size(75, 23);
            this.btnRExit.TabIndex = 3;
            this.btnRExit.Text = "Cancel";
            this.btnRExit.UseVisualStyleBackColor = true;
            // 
            // tbRFind
            // 
            this.tbRFind.Location = new System.Drawing.Point(78, 10);
            this.tbRFind.Name = "tbRFind";
            this.tbRFind.Size = new System.Drawing.Size(171, 20);
            this.tbRFind.TabIndex = 4;
            // 
            // tbRplc
            // 
            this.tbRplc.Location = new System.Drawing.Point(78, 39);
            this.tbRplc.Name = "tbRplc";
            this.tbRplc.Size = new System.Drawing.Size(171, 20);
            this.tbRplc.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Find what:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Re&place with:";
            // 
            // cbRMatchCase
            // 
            this.cbRMatchCase.AutoSize = true;
            this.cbRMatchCase.Location = new System.Drawing.Point(6, 104);
            this.cbRMatchCase.Name = "cbRMatchCase";
            this.cbRMatchCase.Size = new System.Drawing.Size(83, 17);
            this.cbRMatchCase.TabIndex = 8;
            this.cbRMatchCase.Text = "Match Case";
            this.cbRMatchCase.UseVisualStyleBackColor = true;
            // 
            // Replace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 153);
            this.Controls.Add(this.cbRMatchCase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRplc);
            this.Controls.Add(this.tbRFind);
            this.Controls.Add(this.btnRExit);
            this.Controls.Add(this.btnRplcAll);
            this.Controls.Add(this.btnRplc);
            this.Controls.Add(this.btnRFindNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Replace";
            this.Text = "Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRFindNext;
        private System.Windows.Forms.Button btnRplc;
        private System.Windows.Forms.Button btnRplcAll;
        private System.Windows.Forms.Button btnRExit;
        private System.Windows.Forms.TextBox tbRFind;
        private System.Windows.Forms.TextBox tbRplc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbRMatchCase;
    }
}