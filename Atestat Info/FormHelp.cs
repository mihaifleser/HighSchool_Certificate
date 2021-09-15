using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Info
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBoxHelp_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOK_MouseDown(object sender, MouseEventArgs e)
        {
            buttonOK.Font = new Font("Courier New", 14, FontStyle.Italic);
        }

        private void buttonOK_MouseUp(object sender, MouseEventArgs e)
        {
            buttonOK.Font = new Font("Courier New", 14, FontStyle.Regular);
        }
    }
}
