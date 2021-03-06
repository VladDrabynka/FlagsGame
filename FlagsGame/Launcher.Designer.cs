﻿namespace FlagsGame
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.lbHeadline = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbGameMode = new System.Windows.Forms.Label();
            this.cbGameMode = new System.Windows.Forms.ComboBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHeadline
            // 
            this.lbHeadline.AutoSize = true;
            this.lbHeadline.BackColor = System.Drawing.Color.Transparent;
            this.lbHeadline.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeadline.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbHeadline.Location = new System.Drawing.Point(213, 0);
            this.lbHeadline.Name = "lbHeadline";
            this.lbHeadline.Size = new System.Drawing.Size(166, 59);
            this.lbHeadline.TabIndex = 0;
            this.lbHeadline.Text = "Flags";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(40, 103);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 50);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Новая Игра";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(300, 103);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(100, 50);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "Про Flags";
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(430, 103);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbGameMode);
            this.panel1.Controls.Add(this.cbGameMode);
            this.panel1.Controls.Add(this.btnContinue);
            this.panel1.Controls.Add(this.lbHeadline);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 180);
            this.panel1.TabIndex = 4;
            // 
            // lbGameMode
            // 
            this.lbGameMode.AutoSize = true;
            this.lbGameMode.Location = new System.Drawing.Point(145, 71);
            this.lbGameMode.Name = "lbGameMode";
            this.lbGameMode.Size = new System.Drawing.Size(73, 13);
            this.lbGameMode.TabIndex = 6;
            this.lbGameMode.Text = "Режим игры:";
            // 
            // cbGameMode
            // 
            this.cbGameMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGameMode.Items.AddRange(new object[] {
            "Классика",
            "Классика + время",
            "Соответствие"});
            this.cbGameMode.Location = new System.Drawing.Point(224, 68);
            this.cbGameMode.Name = "cbGameMode";
            this.cbGameMode.Size = new System.Drawing.Size(140, 21);
            this.cbGameMode.TabIndex = 5;
            // 
            // btnContinue
            // 
            this.btnContinue.Enabled = false;
            this.btnContinue.Location = new System.Drawing.Point(170, 103);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(100, 50);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Продолжить";
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 187);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Launcher";
            this.Text = "Flags Launcher";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbHeadline;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.ComboBox cbGameMode;
        private System.Windows.Forms.Label lbGameMode;
    }
}