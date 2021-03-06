﻿namespace TicToeGame
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vsCOMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetCountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonA1 = new System.Windows.Forms.Button();
            this.buttonA2 = new System.Windows.Forms.Button();
            this.buttonA3 = new System.Windows.Forms.Button();
            this.buttonB3 = new System.Windows.Forms.Button();
            this.buttonB2 = new System.Windows.Forms.Button();
            this.buttonB1 = new System.Windows.Forms.Button();
            this.buttonC3 = new System.Windows.Forms.Button();
            this.buttonC2 = new System.Windows.Forms.Button();
            this.buttonC1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelXwins = new System.Windows.Forms.Label();
            this.labelDraws = new System.Windows.Forms.Label();
            this.labelOwins = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(327, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.vsCOMPToolStripMenuItem,
            this.resetCountsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // vsCOMPToolStripMenuItem
            // 
            this.vsCOMPToolStripMenuItem.Name = "vsCOMPToolStripMenuItem";
            this.vsCOMPToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.vsCOMPToolStripMenuItem.Text = "Vs. COMP";
            this.vsCOMPToolStripMenuItem.Click += new System.EventHandler(this.vsCOMPToolStripMenuItem_Click);
            // 
            // resetCountsToolStripMenuItem
            // 
            this.resetCountsToolStripMenuItem.Name = "resetCountsToolStripMenuItem";
            this.resetCountsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.resetCountsToolStripMenuItem.Text = "Reset Counts";
            this.resetCountsToolStripMenuItem.Click += new System.EventHandler(this.resetCountsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonA1
            // 
            this.buttonA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonA1.Location = new System.Drawing.Point(48, 49);
            this.buttonA1.Name = "buttonA1";
            this.buttonA1.Size = new System.Drawing.Size(75, 75);
            this.buttonA1.TabIndex = 1;
            this.buttonA1.UseVisualStyleBackColor = true;
            this.buttonA1.Click += new System.EventHandler(this.button_Click);
            this.buttonA1.MouseEnter += new System.EventHandler(this.button_Enter);
            this.buttonA1.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // buttonA2
            // 
            this.buttonA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonA2.Location = new System.Drawing.Point(129, 49);
            this.buttonA2.Name = "buttonA2";
            this.buttonA2.Size = new System.Drawing.Size(75, 75);
            this.buttonA2.TabIndex = 2;
            this.buttonA2.UseVisualStyleBackColor = true;
            this.buttonA2.Click += new System.EventHandler(this.button_Click);
            this.buttonA2.MouseEnter += new System.EventHandler(this.button_Enter);
            this.buttonA2.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // buttonA3
            // 
            this.buttonA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonA3.Location = new System.Drawing.Point(210, 49);
            this.buttonA3.Name = "buttonA3";
            this.buttonA3.Size = new System.Drawing.Size(75, 75);
            this.buttonA3.TabIndex = 3;
            this.buttonA3.UseVisualStyleBackColor = true;
            this.buttonA3.Click += new System.EventHandler(this.button_Click);
            this.buttonA3.MouseEnter += new System.EventHandler(this.button_Enter);
            this.buttonA3.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // buttonB3
            // 
            this.buttonB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonB3.Location = new System.Drawing.Point(210, 130);
            this.buttonB3.Name = "buttonB3";
            this.buttonB3.Size = new System.Drawing.Size(75, 75);
            this.buttonB3.TabIndex = 6;
            this.buttonB3.UseVisualStyleBackColor = true;
            this.buttonB3.Click += new System.EventHandler(this.button_Click);
            this.buttonB3.MouseEnter += new System.EventHandler(this.button_Enter);
            this.buttonB3.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // buttonB2
            // 
            this.buttonB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonB2.Location = new System.Drawing.Point(129, 130);
            this.buttonB2.Name = "buttonB2";
            this.buttonB2.Size = new System.Drawing.Size(75, 75);
            this.buttonB2.TabIndex = 5;
            this.buttonB2.UseVisualStyleBackColor = true;
            this.buttonB2.Click += new System.EventHandler(this.button_Click);
            this.buttonB2.MouseEnter += new System.EventHandler(this.button_Enter);
            this.buttonB2.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // buttonB1
            // 
            this.buttonB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonB1.Location = new System.Drawing.Point(48, 130);
            this.buttonB1.Name = "buttonB1";
            this.buttonB1.Size = new System.Drawing.Size(75, 75);
            this.buttonB1.TabIndex = 4;
            this.buttonB1.UseVisualStyleBackColor = true;
            this.buttonB1.Click += new System.EventHandler(this.button_Click);
            this.buttonB1.MouseEnter += new System.EventHandler(this.button_Enter);
            this.buttonB1.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // buttonC3
            // 
            this.buttonC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonC3.Location = new System.Drawing.Point(210, 211);
            this.buttonC3.Name = "buttonC3";
            this.buttonC3.Size = new System.Drawing.Size(75, 75);
            this.buttonC3.TabIndex = 9;
            this.buttonC3.UseVisualStyleBackColor = true;
            this.buttonC3.Click += new System.EventHandler(this.button_Click);
            this.buttonC3.MouseEnter += new System.EventHandler(this.button_Enter);
            this.buttonC3.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // buttonC2
            // 
            this.buttonC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonC2.Location = new System.Drawing.Point(129, 211);
            this.buttonC2.Name = "buttonC2";
            this.buttonC2.Size = new System.Drawing.Size(75, 75);
            this.buttonC2.TabIndex = 8;
            this.buttonC2.UseVisualStyleBackColor = true;
            this.buttonC2.Click += new System.EventHandler(this.button_Click);
            this.buttonC2.MouseEnter += new System.EventHandler(this.button_Enter);
            this.buttonC2.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // buttonC1
            // 
            this.buttonC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonC1.Location = new System.Drawing.Point(48, 211);
            this.buttonC1.Name = "buttonC1";
            this.buttonC1.Size = new System.Drawing.Size(75, 75);
            this.buttonC1.TabIndex = 7;
            this.buttonC1.UseVisualStyleBackColor = true;
            this.buttonC1.Click += new System.EventHandler(this.button_Click);
            this.buttonC1.MouseEnter += new System.EventHandler(this.button_Enter);
            this.buttonC1.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(206, 300);
            this.label1.MaximumSize = new System.Drawing.Size(77, 22);
            this.label1.MinimumSize = new System.Drawing.Size(77, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "X Wins:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(125, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Draws:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(46, 300);
            this.label3.MaximumSize = new System.Drawing.Size(77, 22);
            this.label3.MinimumSize = new System.Drawing.Size(77, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "O Wins:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelXwins
            // 
            this.labelXwins.AutoSize = true;
            this.labelXwins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelXwins.Location = new System.Drawing.Point(236, 331);
            this.labelXwins.Name = "labelXwins";
            this.labelXwins.Size = new System.Drawing.Size(17, 18);
            this.labelXwins.TabIndex = 13;
            this.labelXwins.Text = "0";
            // 
            // labelDraws
            // 
            this.labelDraws.AutoSize = true;
            this.labelDraws.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDraws.Location = new System.Drawing.Point(150, 331);
            this.labelDraws.Name = "labelDraws";
            this.labelDraws.Size = new System.Drawing.Size(17, 18);
            this.labelDraws.TabIndex = 14;
            this.labelDraws.Text = "0";
            // 
            // labelOwins
            // 
            this.labelOwins.AutoSize = true;
            this.labelOwins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOwins.Location = new System.Drawing.Point(74, 331);
            this.labelOwins.Name = "labelOwins";
            this.labelOwins.Size = new System.Drawing.Size(17, 18);
            this.labelOwins.TabIndex = 15;
            this.labelOwins.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(327, 358);
            this.Controls.Add(this.labelOwins);
            this.Controls.Add(this.labelDraws);
            this.Controls.Add(this.labelXwins);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonC3);
            this.Controls.Add(this.buttonC2);
            this.Controls.Add(this.buttonC1);
            this.Controls.Add(this.buttonB3);
            this.Controls.Add(this.buttonB2);
            this.Controls.Add(this.buttonB1);
            this.Controls.Add(this.buttonA3);
            this.Controls.Add(this.buttonA2);
            this.Controls.Add(this.buttonA1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonA1;
        private System.Windows.Forms.Button buttonA2;
        private System.Windows.Forms.Button buttonA3;
        private System.Windows.Forms.Button buttonB3;
        private System.Windows.Forms.Button buttonB2;
        private System.Windows.Forms.Button buttonB1;
        private System.Windows.Forms.Button buttonC3;
        private System.Windows.Forms.Button buttonC2;
        private System.Windows.Forms.Button buttonC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelXwins;
        private System.Windows.Forms.Label labelDraws;
        private System.Windows.Forms.Label labelOwins;
        private System.Windows.Forms.ToolStripMenuItem resetCountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vsCOMPToolStripMenuItem;
    }
}

