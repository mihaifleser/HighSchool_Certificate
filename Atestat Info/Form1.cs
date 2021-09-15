using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; 
namespace Atestat_Info
{
    public partial class FormStart : Form
    {
        private int ok;
        string player1, player2;
        public int ct1, ct2;
        public bool turn;
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"D:\Proiecte de programare pt bossi\Atestat\Glorious_morning.wav");
        public FormStart()
        {
            InitializeComponent();
            ct1 = 0;
            ct2 = 0;
            turn = true;
            labelScor1.Text = "" + ct1;
            labelScor2.Text = "" + ct2;
            
        }

        public void AdaugaNume(string p1, string p2)
        {
            player1 = p1;
            player2 = p2;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp f = new FormHelp();
            f.ShowDialog();
        }

        public void getAnswer(int answer)
        {
            ok = answer;
        }

        private void endGame()
        {

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;

            buttonExit.Location = new Point(358, 336);
        }

        private void buttonP1Click(int a, Button b)
        {
            FormIntrebare f = new FormIntrebare(this, a, ct1, ct2, turn);
            f.ShowDialog();
            if (ok == 1)
            {
                ct1++;
                labelScor1.Text = "" + ct1;
                b.BackgroundImage = null;
                //b.BackColor = Color.DarkTurquoise;
                b.Enabled = false;

                if (ct1 == 10 && ct2 < 9)
                {
                    MessageBox.Show(labelP1.Text + " a castigat!");
                    buttonExit.Visible = true;
                    endGame();

                }
                else
                {
                    turn = !turn;
                    setTurn();
                }
                
            }
            else
            {
                turn = !turn;
                setTurn();
            }
        }

        private void buttonP2Click(int a, Button b)
        {
            FormIntrebare f = new FormIntrebare(this, a, ct1, ct2, turn);
            f.ShowDialog();
            if (ok == 1)
            {
                ct2++;
                labelScor2.Text = "" + ct2;
                b.BackgroundImage = null;
                b.Enabled = false;
                if (ct2 == 10 && ct1 < 10)
                {
                    MessageBox.Show(labelP2.Text + " a castigat!");
                    buttonExit.Visible = true;
                    endGame();
                }
                else if (ct1 == ct2 && ct1 == 10)
                {
                    MessageBox.Show("Egalitate!");
                    buttonExit.Visible = true;
                    endGame();
                }
                else
                {
                    turn = !turn;
                    setTurn();
                }
            }
            else
                if (ct1 == 10)
            {
                MessageBox.Show(labelP1.Text + " a castigat!");
                buttonExit.Visible = true;
                endGame();
            }
            else
            {
                turn = !turn;
                setTurn();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            buttonP2Click(1,button11);
        }

        private void setTurn()
        {
            if(turn)
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                button11.Visible = false;
                button12.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
                button15.Visible = false;
                button16.Visible = false;
                button17.Visible = false;
                button18.Visible = false;
                button19.Visible = false;
                button20.Visible = false;
            }
            else
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                button11.Visible = true;
                button12.Visible = true;
                button13.Visible = true;
                button14.Visible = true;
                button15.Visible = true;
                button16.Visible = true;
                button17.Visible = true;
                button18.Visible = true;
                button19.Visible = true;
                button20.Visible = true;
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonP1Click(2,button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonP1Click(3,button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonP1Click(4,button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonP1Click(5,button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonP1Click(6,button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonP1Click(7,button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonP1Click(8,button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonP1Click(9,button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            buttonP1Click(10,button10);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            buttonP2Click(2,button12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            buttonP2Click(3,button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            buttonP2Click(4,button14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            buttonP2Click(5,button15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            buttonP2Click(6,button16);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            buttonP2Click(7,button17);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            buttonP2Click(8,button18);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            buttonP2Click(9,button19);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            buttonP2Click(10,button20);
        }

        private void buttonStart_MouseDown(object sender, MouseEventArgs e)
        {
            buttonStart.Font = new Font("Courier New", 18, FontStyle.Italic);
           // buttonStart.Font = new Font("Courier New", 18, FontStyle.Bold);
        }

        private void buttonStart_MouseUp(object sender, MouseEventArgs e)
        {
            buttonStart.Font = new Font("Courier New", 18, FontStyle.Regular);
           // buttonStart.Font = new Font("Courier New", 18, FontStyle.Bold);
        }

        private void buttonStart_MouseEnter(object sender, EventArgs e)
        {
          //  buttonStart.Font = new Font("Courier New", 18, FontStyle.Bold);
        }

        private void buttonStart_MouseLeave(object sender, EventArgs e)
        {
           // buttonStart.Font = new Font("Courier New", 18, FontStyle.Regular);
        }

        private void buttonHelp_MouseDown(object sender, MouseEventArgs e)
        {
            buttonHelp.Font = new Font("Courier New", 18, FontStyle.Italic);
        }

        private void buttonHelp_MouseUp(object sender, MouseEventArgs e)
        {
            buttonHelp.Font = new Font("Courier New", 18, FontStyle.Regular);
        }

        private void buttonExit_MouseDown(object sender, MouseEventArgs e)
        {
            buttonExit.Font = new Font("Courier New", 18, FontStyle.Italic);
        }

        private void buttonExit_MouseUp(object sender, MouseEventArgs e)
        {
            buttonExit.Font = new Font("Courier New", 18, FontStyle.Regular);
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            sp.PlayLooping();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonP1Click(1,button1);
        }
      
        private void buttonStart_Click(object sender, EventArgs e)
        {
            FormNume fnume = new FormNume(this);
            fnume.ShowDialog();

            labelP1.Text = player1;
            labelP2.Text = player2;
            labelTitlu.Visible = false;
            buttonStart.Visible = false;
            buttonHelp.Visible = false;
            buttonExit.Visible = false;

            labelP1.Visible = true;
            labelP2.Visible = true;

            /*button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            */
            setTurn();
            labelScor1.Visible = true;
            labelScor2.Visible = true;
        }
    }
}
