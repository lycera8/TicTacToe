using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.DimGray;

            if (turn)
            {
                btn.Text = "X";
            }
            else
            {
                btn.Text = "O";
            }

            turn = !turn;
            btn.Enabled = false;

            winner_check();    
        }

        private void winner_check()
        {
            bool winner = false;

                //horizontal
            if (btn1.Text == btn2.Text && btn2.Text == btn3.Text && !btn1.Enabled)
            {
                winner = true;
            }
            else if (btn4.Text == btn5.Text && btn5.Text == btn6.Text && !btn4.Enabled)
            {
                winner = true;
            }
            else if (btn7.Text == btn8.Text && btn8.Text == btn9.Text && !btn7.Enabled)
            {
                winner = true;
            }

            if (winner)
            {
                stop_the_btns();

                string the_winner = "";
                if (turn)
                {
                    the_winner = "O";
                }
                else
                {
                    the_winner = "X";
                }

                MessageBox.Show("The winner is " + the_winner + "!!", "Congratulations!");


            }
        }
        private void stop_the_btns()
        {
            try
            {
                foreach (Control bttn in Controls)
                {
                    Button btn = (Button)bttn;
                    btn.Enabled = false;
                }
            }
            catch { }
        }

        private void ngBtn_Click(object sender, EventArgs e)
        {

        }

        private void extBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
