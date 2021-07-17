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
            turn_count++;

            winner_check();
        }

        private void winner_check()
        {
            bool winner = false;

            //Rows
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


            //Column
            if (btn1.Text == btn4.Text && btn4.Text == btn7.Text && !btn1.Enabled)
            {
                winner = true;
            }
            else if (btn2.Text == btn5.Text && btn5.Text == btn8.Text && !btn2.Enabled)
            {
                winner = true;
            }
            else if (btn3.Text == btn6.Text && btn6.Text == btn9.Text && !btn3.Enabled)
            {
                winner = true;
            }

            //Diagonal
            else if (btn1.Text == btn5.Text && btn5.Text == btn9.Text && !btn1.Enabled)
            {
                winner = true;
            }
            else if (btn3.Text == btn5.Text && btn5.Text == btn7.Text && !btn3.Enabled)
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
                turn_count = 0;

            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("It's a draw!", "Try Again");
                }


            }

        }
        private void stop_the_btns()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

        private void ngBtn_Click(object sender, EventArgs e)
        {

            btn1.Enabled = true; btn1.Text = ""; btn1.BackColor = Color.Khaki;
            btn2.Enabled = true; btn2.Text = ""; btn2.BackColor = Color.Khaki;
            btn3.Enabled = true; btn3.Text = ""; btn3.BackColor = Color.Khaki;
            btn4.Enabled = true; btn4.Text = ""; btn4.BackColor = Color.Khaki;
            btn5.Enabled = true; btn5.Text = ""; btn5.BackColor = Color.Khaki;
            btn6.Enabled = true; btn6.Text = ""; btn6.BackColor = Color.Khaki;
            btn7.Enabled = true; btn7.Text = ""; btn7.BackColor = Color.Khaki;
            btn8.Enabled = true; btn8.Text = ""; btn8.BackColor = Color.Khaki;
            btn9.Enabled = true; btn9.Text = ""; btn9.BackColor = Color.Khaki;

        }

        private void extBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
