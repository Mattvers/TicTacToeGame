using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicToeGame
{
    public partial class Form1 : Form
    {
        bool turn = false; //who's turn FALSE-X, TRUE-O.
        int draw = 0;       //how many moves in the game 0-9
        static string player1_Name, player2_Name;  //strings to remember players names.

        public Form1()
        {
            InitializeComponent();
        }

        // shows the message when you click About option in menu
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a Tic Tac Toe Game, created by M.G. You're main goal is to have three the same chars in one line. ", "About");
        }

        // exits the game when you click Exit option in menu.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // starts a new game, clears everything when you click New Game in menu.
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = false;
            draw = 0;
            
                foreach (Control c in Controls)
                {
                    try
                    { 
                        Button button = (Button)c;
                        c.Enabled = true;
                        c.Text = "";
                    }
                    catch { }
                }           
        }

        // function when you click a button thats change whos turn (X or O), adding one move, disable button and checking winner.
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (turn == true)
            {
                button.Text = "X";
                turn = false;
            }
            else
            {
                button.Text = "O";
                turn = true;
            }
            button.Enabled = false;
            draw++;
            checkWinner();           
        }

        //function that checks if there is a winner(in vertical, horizontal and diagonal lines) and if there is a winner
        //function disable buttons and show information about wining player or draw, how many times everyone won.
        private void checkWinner()
        {
            bool ifIsAWinner = false;

            //HORIZONATAL winner checkout
            if ((buttonA1.Text == buttonA2.Text) && (buttonA3.Text == buttonA2.Text) && (!buttonA1.Enabled))
                ifIsAWinner = true;
            else if ((buttonB1.Text == buttonB2.Text) && (buttonB3.Text == buttonB2.Text) && (!buttonB1.Enabled))
                ifIsAWinner = true;
            else if ((buttonC1.Text == buttonC2.Text) && (buttonC3.Text == buttonC2.Text) && (!buttonC1.Enabled))
                ifIsAWinner = true;

            //VERTICAL winner checkout
            else if ((buttonA1.Text == buttonB1.Text) && (buttonB1.Text == buttonC1.Text) && (!buttonA1.Enabled))
                    ifIsAWinner = true;
            else if ((buttonA2.Text == buttonB2.Text) && (buttonB2.Text == buttonC2.Text) && (!buttonA2.Enabled))
                    ifIsAWinner = true;
            else if ((buttonA3.Text == buttonB3.Text) && (buttonB3.Text == buttonC3.Text) && (!buttonA3.Enabled))
                    ifIsAWinner = true;

            //DIAGONAlS winner checkout
            else if ((buttonA1.Text == buttonB2.Text) && (buttonB2.Text == buttonC3.Text) && (!buttonA1.Enabled))
                ifIsAWinner = true;
            else if ((buttonA3.Text == buttonB2.Text) && (buttonB2.Text == buttonC1.Text) && (!buttonC1.Enabled))
                ifIsAWinner = true;

            // IF checks if there is a winner of current game
            if (ifIsAWinner)
            {
                disableButtons();
                string whoWins = "";
                if (turn)
                {
                    whoWins = player1_Name;
                    labelOwins.Text = (Int32.Parse(labelOwins.Text) + 1).ToString();
                }
                else
                {
                    whoWins = player2_Name;
                    labelXwins.Text = (Int32.Parse(labelXwins.Text) + 1).ToString();
                }
                MessageBox.Show("Congratulation " + whoWins + " You WON", "EasyWin");      
            }
            else //if number of clicks = 9 there is a draw between players
            {
                if (draw == 9)
                {
                    labelDraws.Text = (Int32.Parse(labelDraws.Text) + 1).ToString();
                    MessageBox.Show("Draw!");
                }
            }
            
            
        }

        // function that disable all enabled buttons.
        private void disableButtons()
        {            
           foreach (Control c in Controls)
           {
                try
                {
                    Button button = (Button)c;
                    c.Enabled = false;
                }
                catch { }
           }           
        }

        //function thats clear text on button when you leave mouse
        private void button_Leave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {               
                    button.Text = "";
            }
        }

        //function that shows button text (X or Y) when you enter the mouse on button
        private void button_Enter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                if (turn)
                    button.Text = "X";
                else
                    button.Text = "O";
            }
        }

        //when you click reset on menu that resets all values
        private void resetCountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelDraws.Text = "0";
            labelOwins.Text = "0";
            labelXwins.Text = "0";
        }

        // when Form1 is load i create a new object called form2 and shows him to user. Next i change labels text to correct name texts.
        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            label3.Text = player1_Name + ":";
            label1.Text = player2_Name + ":";
        }

        // public static function to save the names in correct strings
        public static void setPlayerName(string n1, string n2)
        {
            player1_Name = n1;
            player2_Name = n2;           
        }
    }
}
