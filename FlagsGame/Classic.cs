﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FlagGame;

namespace FlagsGame
{
    public partial class Classic : Form
    {
        string path = @"E:\Development\Kurs3\FlagsGame\FlagGame";
        Flag flag = new Flag(), flagBuffer = new Flag();
        FlagDatabase flagDb = new FlagDatabase();
        int count = 0;
        Button trueButton;
        List<Button> arrayBut = new List<Button>();

        int timeLeft = 15;

        public Classic()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
            tmAnswer.Enabled = false;
            string pathStats = path + @"\stats.txt";
            flagDb.LoadXml(path + @"\FlagDatabaseRU.xml");
            if (File.ReadAllText(pathStats).Length == 0)
                lbBest.Text = "0";
            else
                lbBest.Text = File.ReadAllText(pathStats);
            loadFlagForm();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            if ((sender as Button) == trueButton)
            {
                MessageBox.Show("Правильный ответ!", "Ответ");
                ++count;
                lbCount.Text = count.ToString();
                arrayBut.Clear();
                loadFlagForm();
            }
            else
            {
                MessageBox.Show("Неправильный ответ! Правильный: " + flag.Name, "Ответ");
                this.Close();
            }

        }

        private void Draw()
        {
            FlagPainter flagP = new FlagPainter();
            Bitmap flagBm = new Bitmap(pbFlag.Width, pbFlag.Height);
            using (Graphics g = Graphics.FromImage((Image)flagBm))
                g.DrawImage(flagP.Draw(flag), 0, 0, flagBm.Width, flagBm.Height);
            pbFlag.Image = flagBm;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            Draw();
            float currentSize;
            if (WindowState == FormWindowState.Maximized)
            {
                currentSize = btnVariantA.Font.Size;
                currentSize += 4.0F;
                foreach (var btn in arrayBut)
                    btn.Font = new Font(btn.Font.Name, currentSize, btn.Font.Style, btn.Font.Unit);

                btnFifty.Font = new Font(btnFifty.Font.Name, currentSize, btnFifty.Font.Style, btnFifty.Font.Unit);
                btnSkip.Font = new Font(btnFifty.Font.Name, currentSize, btnFifty.Font.Style, btnFifty.Font.Unit);

                lbCount.Font = new Font(lbCount.Font.Name, currentSize, lbCount.Font.Style, lbCount.Font.Unit);
                lbCountText.Font = new Font(lbCountText.Font.Name, currentSize, lbCountText.Font.Style, lbCountText.Font.Unit); 
                lbBest.Font = new Font(lbCountText.Font.Name, currentSize, lbCountText.Font.Style, lbCountText.Font.Unit);
                lbBestText.Font = new Font(lbCountText.Font.Name, currentSize, lbCountText.Font.Style, lbCountText.Font.Unit);
                gbHints.Font = new Font(lbCountText.Font.Name, currentSize, lbCountText.Font.Style, lbCountText.Font.Unit);
            }
            if (WindowState == FormWindowState.Normal)
            {
                currentSize = btnVariantA.Font.Size;
                currentSize -= 4.0F;
                foreach (var btn in arrayBut)
                    btn.Font = new Font(btn.Font.Name, currentSize, btn.Font.Style, btn.Font.Unit);

                btnFifty.Font = new Font(btnFifty.Font.Name, currentSize, btnFifty.Font.Style, btnFifty.Font.Unit);
                btnSkip.Font = new Font(btnFifty.Font.Name, currentSize, btnFifty.Font.Style, btnFifty.Font.Unit);

                lbCount.Font = new Font(lbCount.Font.Name, currentSize, lbCount.Font.Style, lbCount.Font.Unit);
                lbCountText.Font = new Font(lbCountText.Font.Name, currentSize, lbCountText.Font.Style, lbCountText.Font.Unit);
                lbBest.Font = new Font(lbCountText.Font.Name, currentSize, lbCountText.Font.Style, lbCountText.Font.Unit);
                lbBestText.Font = new Font(lbCountText.Font.Name, currentSize, lbCountText.Font.Style, lbCountText.Font.Unit);
                gbHints.Font = new Font(lbCountText.Font.Name, currentSize, lbCountText.Font.Style, lbCountText.Font.Unit);
            }
        }

        private void loadFlagForm()
        {
            timeLeft = 15;
            flag = flagDb.getConcreteFlag(count);
            Draw();
            arrayBut.Add(btnVariantA);
            arrayBut.Add(btnVariantB);
            arrayBut.Add(btnVariantC);
            arrayBut.Add(btnVariantD);
            foreach (var btn in arrayBut)
                btn.Enabled = true;
            ShuffleList.Shuffle(arrayBut);
            foreach (var btn in arrayBut)
                btn.Text = flagDb.getRandomFlag().Name;
            trueButton = arrayBut[0];
            arrayBut[0].Text = flag.Name;
            flagDb.clearWorkFlags();
        }

        private void btnFifty_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<Button> btns = arrayBut;
            btns.RemoveAt(0);
            int rndValue;
            try
            {
                for (int i = 0; i < 2; ++i)
                {
                    rndValue = rnd.Next(0, btns.Count());
                    btns[rndValue].Enabled = false;
                    btns.RemoveAt(rndValue);
                }
            }
            catch
            {
                throw new Exception();
            }

            //btnFifty.Enabled = false;
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            loadFlagForm();
            btnSkip.Enabled = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string outputPath = path + @"\stats.txt";
            if (count > Convert.ToInt32(File.ReadAllText(outputPath)))
                File.WriteAllText(outputPath, count.ToString());
        }

        private void tmAnswer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                lbTime.Text = "Time: " + timeLeft + " sec";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                tmAnswer.Stop();
                lbTime.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                this.Close();
            }
        }


    }
}