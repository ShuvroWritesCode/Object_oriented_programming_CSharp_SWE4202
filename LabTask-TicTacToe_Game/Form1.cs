using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToE1
{
    
    public partial class Form1 : Form
    {
        public void reset()
        {
            R1C1Button.BackColor = Color.White;
            R1C2Button.BackColor = Color.White;
            R1C3Button.BackColor = Color.White;
            R2C1Button.BackColor = Color.White;
            R2C2Button.BackColor = Color.White;
            R2C3Button.BackColor = Color.White;
            R3C1Button.BackColor = Color.White;
            R3C2Button.BackColor = Color.White;
            R3C3Button.BackColor = Color.White;
        }
       public int checkIt()
        {
            int winner=0;
            if(R1C1Button.BackColor == R1C2Button.BackColor && R1C1Button.BackColor == R1C3Button.BackColor)
            {
                if (R1C1Button.BackColor == Color.Black)
                {
                    winner = 1;
                }
                else if(R1C1Button.BackColor == Color.LimeGreen)
                {
                    winner = 2;
                }
            }
            else if (R1C1Button.BackColor == R2C1Button.BackColor && R1C1Button.BackColor == R3C1Button.BackColor)
            {
                if (R1C1Button.BackColor == Color.Black)
                {
                    winner = 1;
                }
                else if (R1C1Button.BackColor == Color.LimeGreen)
                {
                    winner = 2;
                }
            }
            else if (R1C1Button.BackColor == R2C2Button.BackColor && R1C1Button.BackColor == R3C3Button.BackColor)
            {
                if (R1C1Button.BackColor == Color.Black)
                {
                    winner = 1;
                }
                else if (R1C1Button.BackColor == Color.LimeGreen)
                {
                    winner = 2;
                }
            }
            else if (R1C2Button.BackColor == R2C2Button.BackColor && R3C2Button.BackColor == R1C2Button.BackColor)
            {
                if (R1C2Button.BackColor == Color.Black)
                {
                    winner = 1;
                }
                else if (R1C2Button.BackColor == Color.LimeGreen)
                {
                    winner = 2;
                }
            }
            else if (R1C3Button.BackColor == R2C3Button.BackColor && R1C3Button.BackColor == R3C3Button.BackColor)
            {
                if (R1C3Button.BackColor == Color.Black)
                {
                    winner = 1;
                }
                else if (R1C3Button.BackColor == Color.LimeGreen)
                {
                    winner = 2;
                }
            }
            else if (R1C3Button.BackColor == R2C2Button.BackColor && R1C3Button.BackColor == R3C1Button.BackColor)
            {
                if (R1C3Button.BackColor == Color.Black)
                {
                    winner = 1;
                }
                else if (R1C3Button.BackColor == Color.LimeGreen)
                {
                    winner = 2;
                }
            }
            else if (R2C1Button.BackColor == R2C2Button.BackColor && R2C1Button.BackColor == R2C3Button.BackColor)
            {
                if (R2C1Button.BackColor == Color.Black)
                {
                    winner = 1;
                }
                else if (R2C1Button.BackColor == Color.LimeGreen)
                {
                    winner = 2;
                }
            }
            else if (R3C1Button.BackColor == R3C2Button.BackColor && R3C1Button.BackColor == R3C3Button.BackColor)
            {
                if (R3C1Button.BackColor == Color.Black)
                {
                    winner = 1;
                }
                else if (R1C3Button.BackColor == Color.LimeGreen)
                {
                    winner = 2;
                }
            }
            else if(R)
            return winner;
        }
        
        public Form1()
        {
            InitializeComponent();
        }
        int i = 1;
        int player1Score=0;
        int player2Score=0;
        int temp = 0;
        private void R1C1Button_Click(object sender, EventArgs e)
        {
            if (i %2 == 1)
            {
                R1C1Button.BackColor = Color.Black;
                player2Label.Text = "Player 2's turn";
                player1Label.Text = "";
            }
            else if(i%2 == 0)
            {
                R1C1Button.BackColor = Color.LimeGreen;
                player1Label.Text = "Player 1's turn";
                player2Label.Text = "";
            }
            i++;
            temp = checkIt();
            if(temp == 1)
            {
                player1Score++;
                MessageBox.Show("Player 1 won!");
                reset();
                i = 1;
            }
            else if(temp == 2)
            {
                player2Score++;
                MessageBox.Show("Player 2 won!");
                reset();
                i = 1;
            }
            player1ScoreLabel.Text = Convert.ToString(player1Score);
            player2ScoreLabel.Text = Convert.ToString(player2Score);
        }

        private void R1C2Button_Click(object sender, EventArgs e)
        {
            if (i % 2 == 1)
            {
                R1C2Button.BackColor = Color.Black;
                player2Label.Text = "Player 2's turn";
                player1Label.Text = "";

            }
            else if (i % 2 == 0)
            {
                R1C2Button.BackColor = Color.LimeGreen;
                player1Label.Text = "Player 1's turn!";
                player2Label.Text = "";
            }
            i++;
            temp = checkIt();
            if (temp == 1)
            {
                player1Score++;
                MessageBox.Show("Player 1 won!");
                reset();
                i = 1;
            }
            else if (temp == 2)
            {
                player2Score++;
                MessageBox.Show("Player 2 won!");
                reset();
                i = 1;
            }
            player1ScoreLabel.Text = Convert.ToString(player1Score);
            player2ScoreLabel.Text = Convert.ToString(player2Score);
        }

        private void R1C3Button_Click(object sender, EventArgs e)
        {
            if (i % 2 == 1)
            {
                R1C3Button.BackColor = Color.Black;
                player2Label.Text = "Player 2's turn";
                player1Label.Text = "";
            }
            else if (i % 2 == 0)
            {
                R1C3Button.BackColor = Color.LimeGreen;
                player1Label.Text = "Player 1's turn!";
                player2Label.Text = "";
            }
            i++;
            temp = checkIt();
            if (temp == 1)
            {
                player1Score++;
                MessageBox.Show("Player 1 won!");
                reset();
                i = 1;
            }
            else if (temp == 2)
            {
                player2Score++;
                MessageBox.Show("Player 2 won!");
                reset();
                i = 1;
            }
            player1ScoreLabel.Text = Convert.ToString(player1Score);
            player2ScoreLabel.Text = Convert.ToString(player2Score);
        }

        private void R2C1Button_Click(object sender, EventArgs e)
        {
            if (i % 2 == 1)
            {
                R2C1Button.BackColor = Color.Black;
                player2Label.Text = "Player 2's turn";
                player1Label.Text = "";
            }
            else if (i % 2 == 0)
            {
                R2C1Button.BackColor = Color.LimeGreen;
                player1Label.Text = "Player 1's turn!";
                player2Label.Text = "";
            }
            i++;
            temp = checkIt();
            if (temp == 1)
            {
                player1Score++;
                MessageBox.Show("Player 1 won!");
                reset();
                i = 1;
            }
            else if (temp == 2)
            {
                player2Score++;
                MessageBox.Show("Player 2 won!");
                reset();
                i = 1;
            }
            player1ScoreLabel.Text = Convert.ToString(player1Score);
            player2ScoreLabel.Text = Convert.ToString(player2Score);
        }

        private void R2C2Button_Click(object sender, EventArgs e)
        {
            if (i % 2 == 1)
            {
                R2C2Button.BackColor = Color.Black;
                player2Label.Text = "Player 2's turn";
                player1Label.Text = "";
            }
            else if (i % 2 == 0)
            {
                R2C2Button.BackColor = Color.LimeGreen;
                player1Label.Text = "Player 1's turn!";
                player2Label.Text = "";

            }
            i++;
            temp = checkIt();
            if (temp == 1)
            {
                player1Score++;
                MessageBox.Show("Player 1 won!");
                reset();
                i = 1;
            }
            else if (temp == 2)
            {
                player2Score++;
                MessageBox.Show("Player 2 won!");
                reset();
                i = 1;
            }
            player1ScoreLabel.Text = Convert.ToString(player1Score);
            player2ScoreLabel.Text = Convert.ToString(player2Score);
        }

        private void R2C3Button_Click(object sender, EventArgs e)
        {
            if (i % 2 == 1)
            {
                R2C3Button.BackColor = Color.Black;
                player2Label.Text = "Player 2's turn";
                player1Label.Text = "";
            }
            else if (i % 2 == 0)
            {
                R2C3Button.BackColor = Color.LimeGreen;
                player1Label.Text = "Player 1's turn!";
                player2Label.Text = "";
            }
            i++;
            temp = checkIt();
            if (temp == 1)
            {
                player1Score++;
                MessageBox.Show("Player 1 won!");
                reset();
                i = 1;
            }
            else if (temp == 2)
            {
                player2Score++;
                MessageBox.Show("Player 2 won!");
                reset();
                i = 1;
            }
            player1ScoreLabel.Text = Convert.ToString(player1Score);
            player2ScoreLabel.Text = Convert.ToString(player2Score);
        }

        private void R3C1Button_Click(object sender, EventArgs e)
        {
            if (i % 2 == 1)
            {
                R3C1Button.BackColor = Color.Black;
                player2Label.Text = "Player 2's turn";
                player1Label.Text = "";
            }
            else if (i % 2 == 0)
            {
                R3C1Button.BackColor = Color.LimeGreen;
                player1Label.Text = "Player 1's turn!";
                player2Label.Text = "";
            }
            i++;
            temp = checkIt();
            if (temp == 1)
            {
                player1Score++;
                MessageBox.Show("Player 1 won!");
                reset();
                i = 1;
            }
            else if (temp == 2)
            {
                player2Score++;
                MessageBox.Show("Player 2 won!");
                reset();
                i = 1;
            }
            player1ScoreLabel.Text = Convert.ToString(player1Score);
            player2ScoreLabel.Text = Convert.ToString(player2Score);
        }

        private void R3C2Button_Click(object sender, EventArgs e)
        {
            if (i % 2 == 1)
            {
                R3C2Button.BackColor = Color.Black;
                player2Label.Text = "Player 2's turn";
                player1Label.Text = "";
            }
            else if (i % 2 == 0)
            {
                R3C2Button.BackColor = Color.LimeGreen;
                player1Label.Text = "Player 1's turn!";
                player2Label.Text = "";
            }
            i++;
            temp = checkIt();
            if (temp == 1)
            {
                player1Score++;
                MessageBox.Show("Player 1 won!");
                reset();
                i = 1;
            }
            else if (temp == 2)
            {
                player2Score++;
                MessageBox.Show("Player 2 won!");
                reset();
                i = 1;
            }
            player1ScoreLabel.Text = Convert.ToString(player1Score);
            player2ScoreLabel.Text = Convert.ToString(player2Score);
        }

        private void R3C3Button_Click(object sender, EventArgs e)
        {
            if (i % 2 == 1)
            {
                R3C3Button.BackColor = Color.Black;
                player2Label.Text = "Player 2's turn";
                player1Label.Text = "";
            }
            else if (i % 2 == 0)
            {
                R3C3Button.BackColor = Color.LimeGreen;
                player1Label.Text = "Player 1's turn!";
                player2Label.Text = "";
            }
            i++;
            temp = checkIt();
            if (temp == 1)
            {
                player1Score++;
                MessageBox.Show("Player 1 won!");
                reset();
                i = 1;
            }
            else if (temp == 2)
            {
                player2Score++;
                MessageBox.Show("Player 2 won!");
                reset();
                i = 1;
            }
            player1ScoreLabel.Text = Convert.ToString(player1Score);
            player2ScoreLabel.Text = Convert.ToString(player2Score);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player1Label.Text = "Player 1's turn!";
        }
    }
}
