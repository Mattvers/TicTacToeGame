namespace TicToeGame
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.P1_textBox = new System.Windows.Forms.TextBox();
            this.P2_textBox = new System.Windows.Forms.TextBox();
            this.button_Play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1 Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 2 Name:";
            // 
            // P1_textBox
            // 
            this.P1_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.P1_textBox.Location = new System.Drawing.Point(195, 6);
            this.P1_textBox.MaxLength = 5;
            this.P1_textBox.Name = "P1_textBox";
            this.P1_textBox.Size = new System.Drawing.Size(297, 34);
            this.P1_textBox.TabIndex = 2;
            this.P1_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_Button);
            // 
            // P2_textBox
            // 
            this.P2_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.P2_textBox.Location = new System.Drawing.Point(195, 57);
            this.P2_textBox.MaxLength = 5;
            this.P2_textBox.Name = "P2_textBox";
            this.P2_textBox.Size = new System.Drawing.Size(297, 34);
            this.P2_textBox.TabIndex = 3;
            this.P2_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_Button);
            // 
            // button_Play
            // 
            this.button_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Play.Location = new System.Drawing.Point(195, 100);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(105, 36);
            this.button_Play.TabIndex = 4;
            this.button_Play.Text = "Play!";
            this.button_Play.UseVisualStyleBackColor = true;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(499, 148);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.P2_textBox);
            this.Controls.Add(this.P1_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Write Names";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox P1_textBox;
        private System.Windows.Forms.TextBox P2_textBox;
        private System.Windows.Forms.Button button_Play;
    }
}