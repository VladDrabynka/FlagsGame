﻿namespace FlagsGame
{
    partial class Classic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Classic));
            this.pbFlag = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnVariantD = new System.Windows.Forms.Button();
            this.btnVariantC = new System.Windows.Forms.Button();
            this.btnVariantA = new System.Windows.Forms.Button();
            this.btnVariantB = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbCount = new System.Windows.Forms.Label();
            this.lbBest = new System.Windows.Forms.Label();
            this.lbBestText = new System.Windows.Forms.Label();
            this.lbCountText = new System.Windows.Forms.Label();
            this.gbHints = new System.Windows.Forms.GroupBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnFifty = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbTime = new System.Windows.Forms.Label();
            this.tmAnswer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbHints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFlag
            // 
            this.pbFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFlag.Location = new System.Drawing.Point(153, 3);
            this.pbFlag.Name = "pbFlag";
            this.pbFlag.Size = new System.Drawing.Size(446, 334);
            this.pbFlag.TabIndex = 1;
            this.pbFlag.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnVariantD, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnVariantC, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnVariantA, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnVariantB, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(153, 343);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(446, 141);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnVariantD
            // 
            this.btnVariantD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVariantD.Location = new System.Drawing.Point(226, 73);
            this.btnVariantD.Name = "btnVariantD";
            this.btnVariantD.Size = new System.Drawing.Size(217, 65);
            this.btnVariantD.TabIndex = 3;
            this.btnVariantD.Text = "button4";
            this.btnVariantD.UseVisualStyleBackColor = true;
            this.btnVariantD.Click += new System.EventHandler(this.buttonClick);
            // 
            // btnVariantC
            // 
            this.btnVariantC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVariantC.Location = new System.Drawing.Point(3, 73);
            this.btnVariantC.Name = "btnVariantC";
            this.btnVariantC.Size = new System.Drawing.Size(217, 65);
            this.btnVariantC.TabIndex = 2;
            this.btnVariantC.Text = "button3";
            this.btnVariantC.UseVisualStyleBackColor = true;
            this.btnVariantC.Click += new System.EventHandler(this.buttonClick);
            // 
            // btnVariantA
            // 
            this.btnVariantA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVariantA.Location = new System.Drawing.Point(3, 3);
            this.btnVariantA.Name = "btnVariantA";
            this.btnVariantA.Size = new System.Drawing.Size(217, 64);
            this.btnVariantA.TabIndex = 0;
            this.btnVariantA.Text = "button1";
            this.btnVariantA.UseVisualStyleBackColor = true;
            this.btnVariantA.Click += new System.EventHandler(this.buttonClick);
            // 
            // btnVariantB
            // 
            this.btnVariantB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVariantB.Location = new System.Drawing.Point(226, 3);
            this.btnVariantB.Name = "btnVariantB";
            this.btnVariantB.Size = new System.Drawing.Size(217, 64);
            this.btnVariantB.TabIndex = 1;
            this.btnVariantB.Text = "button2";
            this.btnVariantB.UseVisualStyleBackColor = true;
            this.btnVariantB.Click += new System.EventHandler(this.buttonClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbFlag, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbHints, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 487);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.375F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.625F));
            this.tableLayoutPanel3.Controls.Add(this.lbCount, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbBest, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbBestText, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbCountText, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.MaximumSize = new System.Drawing.Size(160, 334);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.47305F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.52695F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(144, 334);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(117, 15);
            this.lbCount.Margin = new System.Windows.Forms.Padding(3, 15, 0, 0);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(13, 13);
            this.lbCount.TabIndex = 1;
            this.lbCount.Text = "0";
            // 
            // lbBest
            // 
            this.lbBest.AutoSize = true;
            this.lbBest.Location = new System.Drawing.Point(117, 59);
            this.lbBest.Margin = new System.Windows.Forms.Padding(3, 15, 0, 0);
            this.lbBest.Name = "lbBest";
            this.lbBest.Size = new System.Drawing.Size(13, 13);
            this.lbBest.TabIndex = 3;
            this.lbBest.Text = "0";
            // 
            // lbBestText
            // 
            this.lbBestText.AutoSize = true;
            this.lbBestText.Location = new System.Drawing.Point(5, 59);
            this.lbBestText.Margin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.lbBestText.Name = "lbBestText";
            this.lbBestText.Size = new System.Drawing.Size(102, 13);
            this.lbBestText.TabIndex = 2;
            this.lbBestText.Text = "Лучший результат:";
            // 
            // lbCountText
            // 
            this.lbCountText.AutoSize = true;
            this.lbCountText.Location = new System.Drawing.Point(5, 15);
            this.lbCountText.Margin = new System.Windows.Forms.Padding(5, 15, 0, 0);
            this.lbCountText.Name = "lbCountText";
            this.lbCountText.Size = new System.Drawing.Size(73, 13);
            this.lbCountText.TabIndex = 0;
            this.lbCountText.Text = "Правильных:";
            // 
            // gbHints
            // 
            this.gbHints.AutoSize = true;
            this.gbHints.Controls.Add(this.btnSkip);
            this.gbHints.Controls.Add(this.btnFifty);
            this.gbHints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHints.Location = new System.Drawing.Point(605, 3);
            this.gbHints.Name = "gbHints";
            this.gbHints.Size = new System.Drawing.Size(146, 334);
            this.gbHints.TabIndex = 3;
            this.gbHints.TabStop = false;
            this.gbHints.Text = "Подсказки";
            // 
            // btnSkip
            // 
            this.btnSkip.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSkip.Location = new System.Drawing.Point(3, 56);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(140, 40);
            this.btnSkip.TabIndex = 1;
            this.btnSkip.Text = "Пропустить";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnFifty
            // 
            this.btnFifty.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFifty.Location = new System.Drawing.Point(3, 16);
            this.btnFifty.Name = "btnFifty";
            this.btnFifty.Size = new System.Drawing.Size(140, 40);
            this.btnFifty.TabIndex = 0;
            this.btnFifty.Text = "50/50";
            this.btnFifty.UseVisualStyleBackColor = true;
            this.btnFifty.Click += new System.EventHandler(this.btnFifty_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbTime);
            this.splitContainer1.Size = new System.Drawing.Size(879, 487);
            this.splitContainer1.SplitterDistance = 754;
            this.splitContainer1.TabIndex = 2;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime.Location = new System.Drawing.Point(12, 33);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(92, 13);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "Время: 15 сек";
            // 
            // tmAnswer
            // 
            this.tmAnswer.Enabled = true;
            this.tmAnswer.Interval = 1000;
            this.tmAnswer.Tick += new System.EventHandler(this.tmAnswer_Tick);
            // 
            // Classic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 487);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Classic";
            this.Text = "Flags";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gbHints.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFlag;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnVariantD;
        private System.Windows.Forms.Button btnVariantC;
        private System.Windows.Forms.Button btnVariantA;
        private System.Windows.Forms.Button btnVariantB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbCountText;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.GroupBox gbHints;
        private System.Windows.Forms.Button btnFifty;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Label lbBestText;
        private System.Windows.Forms.Label lbBest;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer tmAnswer;

    }
}

