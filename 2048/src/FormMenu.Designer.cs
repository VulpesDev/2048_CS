﻿namespace _2048.src
{
    partial class FormMenu
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonWHScore = new System.Windows.Forms.Button();
            this.panelWorldLeaderboard = new System.Windows.Forms.Panel();
            this.buttonLatest = new System.Windows.Forms.Button();
            this.buttonTop = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.worldLeaderboardMenu1 = new _2048.src.WorldLeaderboardMenu();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelWorldLeaderboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.AutoSize = true;
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPlay.Location = new System.Drawing.Point(184, 171);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(292, 80);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonWHScore
            // 
            this.buttonWHScore.AutoSize = true;
            this.buttonWHScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonWHScore.Location = new System.Drawing.Point(184, 312);
            this.buttonWHScore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonWHScore.Name = "buttonWHScore";
            this.buttonWHScore.Size = new System.Drawing.Size(292, 80);
            this.buttonWHScore.TabIndex = 2;
            this.buttonWHScore.Text = "World Leaderboard";
            this.buttonWHScore.UseVisualStyleBackColor = true;
            this.buttonWHScore.Click += new System.EventHandler(this.buttonWHScore_Click);
            // 
            // panelWorldLeaderboard
            // 
            this.panelWorldLeaderboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWorldLeaderboard.AutoSize = true;
            this.panelWorldLeaderboard.Controls.Add(this.buttonLatest);
            this.panelWorldLeaderboard.Controls.Add(this.buttonTop);
            this.panelWorldLeaderboard.Controls.Add(this.buttonBack);
            this.panelWorldLeaderboard.Controls.Add(this.worldLeaderboardMenu1);
            this.panelWorldLeaderboard.Location = new System.Drawing.Point(594, 460);
            this.panelWorldLeaderboard.Name = "panelWorldLeaderboard";
            this.panelWorldLeaderboard.Size = new System.Drawing.Size(685, 649);
            this.panelWorldLeaderboard.TabIndex = 3;
            this.panelWorldLeaderboard.Visible = false;
            // 
            // buttonLatest
            // 
            this.buttonLatest.Location = new System.Drawing.Point(498, 14);
            this.buttonLatest.Name = "buttonLatest";
            this.buttonLatest.Size = new System.Drawing.Size(144, 75);
            this.buttonLatest.TabIndex = 3;
            this.buttonLatest.Text = "Latest";
            this.buttonLatest.UseVisualStyleBackColor = true;
            this.buttonLatest.Click += new System.EventHandler(this.buttonLatest_Click);
            // 
            // buttonTop
            // 
            this.buttonTop.Location = new System.Drawing.Point(29, 14);
            this.buttonTop.Name = "buttonTop";
            this.buttonTop.Size = new System.Drawing.Size(144, 75);
            this.buttonTop.TabIndex = 2;
            this.buttonTop.Text = "Top";
            this.buttonTop.UseVisualStyleBackColor = true;
            this.buttonTop.Click += new System.EventHandler(this.buttonTop_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(29, 558);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(144, 75);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Go Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // worldLeaderboardMenu1
            // 
            this.worldLeaderboardMenu1.Enabled = false;
            this.worldLeaderboardMenu1.Location = new System.Drawing.Point(105, 106);
            this.worldLeaderboardMenu1.Name = "worldLeaderboardMenu1";
            this.worldLeaderboardMenu1.Size = new System.Drawing.Size(477, 403);
            this.worldLeaderboardMenu1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 117);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Anonymous";
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(135, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(194)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(681, 647);
            this.Controls.Add(this.panelWorldLeaderboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonWHScore);
            this.Controls.Add(this.buttonPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelWorldLeaderboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonWHScore;
        private System.Windows.Forms.Panel panelWorldLeaderboard;
        private WorldLeaderboardMenu worldLeaderboardMenu1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLatest;
        private System.Windows.Forms.Button buttonTop;
    }
}