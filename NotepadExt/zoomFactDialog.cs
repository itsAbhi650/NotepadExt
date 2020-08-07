using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadExt
{
    public partial class zoomFactDialog : Form
    {
    
        float _zoomfactor = 0.0f;
        
        public zoomFactDialog()
        {
            InitializeComponent();
            
        }

        public float zoomfactor
        {
            get {return _zoomfactor;}
            set { _zoomfactor = value; }
        }

        private void btnZoomFactorOK_Click(object sender, EventArgs e)
        {
            //if (tbZoomFactInput.Text.Length > 0)
                float.TryParse(tbZoomFactInput.Text, out _zoomfactor);
            //else
            //    MessageBox.Show("Empty");
            //    zoomFactDialog ZFD = new zoomFactDialog();
            //    ZFD.Show();
        }

    }
}
