using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Info
{
    public partial class FormIntrebare : Form
    {
        private int time;
        string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Proiecte de programare pt bossi\Atestat\Atestat Info\Atestat Info\Questions.mdf;Integrated Security = True";
        DataSet intrebari;
        SqlConnection connection;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        FormStart form = new FormStart();
        int id;
        int ok;
        private int nrintrebare;
        string raspcorect;
        string subanswer;
        int ct1, ct2;
        bool turn;
        public FormIntrebare(FormStart fstart, int num, int ct1, int ct2, bool turn)
        {
            this.form = fstart;
            nrintrebare = num;
            ok = 0;
            connection = new SqlConnection(connectionstring);
            InitializeComponent();
            timerIntrebare.Start();
            this.ct1 = ct1;
            this.ct2 = ct2;
            this.turn = turn;
            if (ct1 >= 5 && turn || ct2 >= 5 && !turn)
                time = 8;
            else
                time = 15;
            labelTime.Text = time.ToString();
            intrebari = new DataSet();
            connection.Open();
            cmd = new SqlCommand("Select * from [Questions]", connection);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(intrebari);
            connection.Close();
            citit_intrebare();
  
        }

        private void citit_intrebare()
        {
            Random rdm = new Random();
            id = rdm.Next((nrintrebare - 1) * 3, (nrintrebare - 1) * 3 + 3);
            labelIntrebare.Text = intrebari.Tables[0].Rows[id][1].ToString();
            radioButton1.Text = intrebari.Tables[0].Rows[id][2].ToString();
            radioButton2.Text = intrebari.Tables[0].Rows[id][3].ToString();
            radioButton3.Text = intrebari.Tables[0].Rows[id][4].ToString();
            radioButton4.Text = intrebari.Tables[0].Rows[id][5].ToString();
            raspcorect = intrebari.Tables[0].Rows[id][6].ToString();
            //intrebari.Rows.RemoveAt(id);
        }
        private void timerIntrebare_Tick(object sender, EventArgs e)
        {
            time--;
            labelTime.Text = time.ToString();
            if (time == 5)
                labelTime.ForeColor = Color.Red;
            if (time == 0)
            {
                timerIntrebare.Stop();
                this.Close();
                if (subanswer.CompareTo(raspcorect) == 0)
                    ok = 1;
                if (ok == 1)
                    MessageBox.Show("Raspuns corect!");
                else
                    MessageBox.Show("Raspuns gresit!");
                form.getAnswer(ok);
               
            }
                
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            subanswer = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            subanswer = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            subanswer = radioButton3.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            subanswer = radioButton4.Text;
        }

        private void buttonRaspuns_MouseDown(object sender, MouseEventArgs e)
        {
            buttonRaspuns.Font = new Font("Courier New", 12, FontStyle.Italic);
        }

        private void buttonRaspuns_MouseUp(object sender, MouseEventArgs e)
        {
            buttonRaspuns.Font = new Font("Courier New", 12, FontStyle.Regular);
        }

        private void FormIntrebare_Load(object sender, EventArgs e)
        {
            //timerIntrebare.Stop();
        }

        private void FormIntrebare_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerIntrebare.Stop();
        }

        private void buttonRaspuns_Click(object sender, EventArgs e)
        {
            if (subanswer == raspcorect)
                ok = 1;
            form.getAnswer(ok);
            timerIntrebare.Stop();
            if (ok == 1)
                MessageBox.Show("Raspuns corect!");
            else
                MessageBox.Show("Raspuns gresit!");
            this.Close();
        }
    }
}
