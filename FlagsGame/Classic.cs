using System;
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
        Facade facade = new Facade();
        //string path = @"D:\FlagsGame\FlagGame";
        Flag flag = new Flag();
        FlagDatabase flagDb = new FlagDatabase();
        int count = 0;
        Button trueButton;
        List<Button> arrayBut = new List<Button>();
        IFlagIterator flagIter;  

        bool time;
        int timeLeft = 15;

        public Classic(bool time)
        {
            this.time = time;
            flagIter = flagDb.getIterator(); 
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (time)
            {
                lbBest.Text = Convert.ToString(Properties.Settings.Default.bestStreakClassicTime);
                splitContainer1.Panel2Collapsed = false;
                tmAnswer.Enabled = true;
            }
            else
            {
                lbBest.Text = Convert.ToString(Properties.Settings.Default.bestStreakClassic);
                splitContainer1.Panel2Collapsed = true;
                tmAnswer.Enabled = false;
            }
            flagDb.LoadXml(path + @"\FlagDatabaseRU.xml");
            loadFlagForm();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            if (count + 1 == flagDb.flagsList().Count)
            {
                MessageBox.Show("Поздравляем! Вы прошли эту игру. Можете взять печеньку :)", "Конец игры");
                this.Close();
                return;
            }
            /*if ((sender as Button) == trueButton)*/
            if (facade.checkAnswerOne((sender as Button), trueButton))
            {
                MessageBox.Show("Правильный ответ!", "Ответ");
                ++count;
                flagIter.Next();
                arrayBut.Clear();
                loadFlagForm();
            }

            else
            {
                tmAnswer.Enabled = false;
                MessageBox.Show("Неправильный ответ! Правильный: " + flag.Name + ". Количество правильных ответов: " + count, "Ответ");
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
            lbCount.Text = count.ToString();
            lbTime.Text = "Время: 15 сек";
            timeLeft = 15;
            //flag = flagDb.getConcreteFlag(count);
            flag = flagIter.CurrentItem();
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

            btnFifty.Enabled = false;
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            if (count + 1 == flagDb.flagsList().Count)
            {
                MessageBox.Show("Поздравляем! Вы прошли эту игру. Можете взять печеньку :)", "Конец игры");
                this.Close();
                return;
            }
            arrayBut.Clear();
            count++;
            flagIter.Next();
            loadFlagForm();
            btnSkip.Enabled = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (count > Properties.Settings.Default.bestStreakClassic && !time)
            {
                Properties.Settings.Default.bestStreakClassic = count;
                Properties.Settings.Default.Save();
            }
            if (count > Properties.Settings.Default.bestStreakClassicTime && time)
            {
                Properties.Settings.Default.bestStreakClassicTime = count;
                Properties.Settings.Default.Save();
            }
        }

        private void tmAnswer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                lbTime.Text = "Время: " + timeLeft + " сек";
            }
            else
            {
                tmAnswer.Stop();
                lbTime.Text = "Время вышло!";
                MessageBox.Show("Вы не ответели за укзанное время. Вы проиграли.", "Конец игры");
                this.Close();
            }
        }


    }
}
