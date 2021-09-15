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
    public partial class FormNume : Form
    {
        FormStart form = new FormStart();
        public FormNume(FormStart form)
        {
            this.form = form;
            InitializeComponent();
            textBoxP1.Focus();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxP1.Text != string.Empty && textBoxP2.Text != string.Empty)
            {
                form.AdaugaNume(textBoxP1.Text, textBoxP2.Text);
                this.Close();
            }
        }

        private void textBoxP1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                if (textBoxP1.Text != string.Empty)
                {
                    textBoxP2.Focus();
                }
        }

        private void textBoxP2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (textBoxP1.Text != string.Empty && textBoxP2.Text != string.Empty)
                {
                    form.AdaugaNume(textBoxP1.Text, textBoxP2.Text);
                    this.Close();
                }
        }

        private void textBoxP1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelP2_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_MouseEnter(object sender, EventArgs e)
        {
            buttonOK.Font = new Font("Harrington",16,FontStyle.Italic);
        }

        private void buttonOK_MouseLeave(object sender, EventArgs e)
        {
            buttonOK.Font = new Font("Harrington", 16, FontStyle.Regular);
        }

        private void buttonOK_MouseDown(object sender, MouseEventArgs e)
        {
            buttonOK.BackColor = Color.DarkGray;
        }

        private void buttonOK_MouseUp(object sender, MouseEventArgs e)
        {
            buttonOK.BackColor = Color.Silver;
        }
    }
}
