using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lockdown
{
    public partial class frmBlockWebsite : Form
    {
        public string url { get; set; }
        public frmBlockWebsite()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnURLSubmit_Click(object sender, EventArgs e)
        {
            //We want this to submit the url and put it in the list of blocked sites.
            this.url = txtURL.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
