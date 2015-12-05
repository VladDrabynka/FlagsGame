namespace FlagsGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnVariantD = new System.Windows.Forms.Button();
            this.btnVariantC = new System.Windows.Forms.Button();
            this.btnVariantA = new System.Windows.Forms.Button();
            this.btnVariantB = new System.Windows.Forms.Button();
            this.pbFlag = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbFlag, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 487);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(169, 343);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(494, 141);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnVariantD
            // 
            this.btnVariantD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVariantD.Location = new System.Drawing.Point(250, 73);
            this.btnVariantD.Name = "btnVariantD";
            this.btnVariantD.Size = new System.Drawing.Size(241, 65);
            this.btnVariantD.TabIndex = 3;
            this.btnVariantD.Text = "button4";
            this.btnVariantD.UseVisualStyleBackColor = true;
            this.btnVariantD.Click += new System.EventHandler(this.btnVariantD_Click);
            // 
            // btnVariantC
            // 
            this.btnVariantC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVariantC.Location = new System.Drawing.Point(3, 73);
            this.btnVariantC.Name = "btnVariantC";
            this.btnVariantC.Size = new System.Drawing.Size(241, 65);
            this.btnVariantC.TabIndex = 2;
            this.btnVariantC.Text = "button3";
            this.btnVariantC.UseVisualStyleBackColor = true;
            this.btnVariantC.Click += new System.EventHandler(this.btnVariantC_Click);
            // 
            // btnVariantA
            // 
            this.btnVariantA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVariantA.Location = new System.Drawing.Point(3, 3);
            this.btnVariantA.Name = "btnVariantA";
            this.btnVariantA.Size = new System.Drawing.Size(241, 64);
            this.btnVariantA.TabIndex = 0;
            this.btnVariantA.Text = "button1";
            this.btnVariantA.UseVisualStyleBackColor = true;
            this.btnVariantA.Click += new System.EventHandler(this.btnVariantA_Click);
            // 
            // btnVariantB
            // 
            this.btnVariantB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVariantB.Location = new System.Drawing.Point(250, 3);
            this.btnVariantB.Name = "btnVariantB";
            this.btnVariantB.Size = new System.Drawing.Size(241, 64);
            this.btnVariantB.TabIndex = 1;
            this.btnVariantB.Text = "button2";
            this.btnVariantB.UseVisualStyleBackColor = true;
            this.btnVariantB.Click += new System.EventHandler(this.btnVariantB_Click);
            // 
            // pbFlag
            // 
            this.pbFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFlag.Location = new System.Drawing.Point(169, 3);
            this.pbFlag.Name = "pbFlag";
            this.pbFlag.Size = new System.Drawing.Size(494, 334);
            this.pbFlag.TabIndex = 1;
            this.pbFlag.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 487);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Flags";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnVariantD;
        private System.Windows.Forms.Button btnVariantC;
        private System.Windows.Forms.Button btnVariantA;
        private System.Windows.Forms.Button btnVariantB;
        private System.Windows.Forms.PictureBox pbFlag;
    }
}

