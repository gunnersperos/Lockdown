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
    public partial class frmAddProfile : Form
    {
        public Form pForm;
        public frmAddProfile()
        {
            InitializeComponent();
        }

        private void btnNewProfile_Click(object sender, EventArgs e)
        {
            // Create new profile if profile name isn't blank
            if (!string.IsNullOrWhiteSpace(txtNewProfile.Text))
            {
                Profiles newProfile = new Profiles();
                newProfile.CreateProfile(txtNewProfile.Text);
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
