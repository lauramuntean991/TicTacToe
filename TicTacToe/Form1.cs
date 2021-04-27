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
        bool turn = true; // true = X turn , false = O turn
        int count = 0;


        public Form1()
        {
            InitializeComponent();
        }

        

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else b.Text = "O";

            if (!turn)

                label4.Text = textBox1.Text + ", it's your turn";

            else label4.Text = textBox2.Text + ", it's your turn";

            turn = !turn;
            b.Enabled = false;
            count++;
            check();

            if (textBox1.Text.Equals("") && textBox2.Text.Equals(""))

                label4.Text = "Warning: Enter your name/names!";

            
        }

        private void check()
        {
            bool is_winner = false;

            // ≡
            if ((R1C1.Text == R1C2.Text) && (R1C2.Text == R1C3.Text) && (!R1C1.Enabled))
                is_winner = true;

            if ((R2C1.Text == R2C2.Text) && (R2C2.Text == R2C3.Text) && (!R2C1.Enabled))
                is_winner = true;

            if ((R3C1.Text == R3C2.Text) && (R3C2.Text == R3C3.Text) && (!R3C1.Enabled))
            
                is_winner = true;


            // |||
            if ((R1C1.Text == R2C1.Text) && (R2C1.Text == R3C1.Text) && (!R1C1.Enabled))
                is_winner = true;

            if ((R1C2.Text == R2C2.Text) && (R2C2.Text == R3C2.Text) && (!R1C2.Enabled))
                is_winner = true;

            if ((R1C3.Text == R2C3.Text) && (R2C3.Text == R3C3.Text) && (!R1C3.Enabled))
                is_winner = true;

            // \ /
            if ((R1C1.Text == R2C2.Text) && (R2C2.Text == R3C3.Text) && (!R1C1.Enabled))
                is_winner = true;

            if ((R1C3.Text == R2C2.Text) && (R2C2.Text == R3C1.Text) && (!R1C3.Enabled))

                is_winner = true;
                       

            if (is_winner)
            {
                disableButtons();

                String winner = "";

                if (turn)
                    winner = textBox2.Text + " (O)";
                else winner = textBox1.Text + " (X)";
                label4.Text = "";

                MessageBox.Show(winner + " Wins!", ":D");

            }
            else
            {
                if (count == 9)
                    MessageBox.Show("Draw", ":(");
            }

        }
        private void disableButtons()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                catch { }
            }
        }


        private void nEWGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            count = 0;
            try
            {
                foreach (Control c in Controls.OfType<Button>())
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    label4.Text = "";

                }
            }
            catch { }

        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else b.Text = "O";
            }

        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }

        }
    }
}
