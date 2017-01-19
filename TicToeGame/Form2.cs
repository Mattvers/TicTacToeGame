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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //when you click button play the names from textboxes are saved to static strings and this form is closed
        private void button_Play_Click(object sender, EventArgs e)
        {
            Form1.setPlayerName(P1_textBox.Text, P2_textBox.Text);
            this.Close();            
        }

        // function that performs click ENTER button on keyboart as a result to click Play Button
        private void enter_Button(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                button_Play.PerformClick();
        }
    }
}
