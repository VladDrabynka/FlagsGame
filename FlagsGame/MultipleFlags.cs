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
    public partial class MultipleFlags : Form
    {
        string path = @"E:\Development\Kurs3\FlagsGame\FlagGame";
        //string path = @"D:\FlagsGame\FlagGame";
        Flag flag = new Flag();
        FlagDatabase flagDb = new FlagDatabase();
        int globalFlagCount = 0, count = 0;

        List<string> arrayAnswers = new List<string>();
        List<Flag> arrayFlag = new List<Flag>(), flagBuf = new List<Flag>();
        List<PictureBox> arrayPb = new List<PictureBox>();
        List<ComboBox> arrayCb = new List<ComboBox>();

        Facade facade = new Facade();

        public MultipleFlags()
        {
            InitializeComponent();
        }

        private void MultipleFlags_Load(object sender, EventArgs e)
        {
            flagDb.LoadXml(path + @"\FlagDatabaseRU.xml");

            arrayPb.Add(pbFlag1);
            arrayPb.Add(pbFlag2);
            arrayPb.Add(pbFlag3);
            arrayPb.Add(pbFlag4);

            arrayCb.Add(cbVariantA);
            arrayCb.Add(cbVariantB);
            arrayCb.Add(cbVariantC);
            arrayCb.Add(cbVariantD);

            lbBest.Text = Convert.ToString(Properties.Settings.Default.bestStreakMultiple);

            loadFlagForm();
        }

        private void Draw(PictureBox pbFlag)
        {
            Random rnd = new Random();
            FlagPainter flagP = new FlagPainter();
            Bitmap flagBm = new Bitmap(pbFlag.Width, pbFlag.Height);
            flag = arrayFlag[rnd.Next(0, arrayFlag.Count)];
            using (Graphics g = Graphics.FromImage((Image)flagBm))
                g.DrawImage(flagP.Draw(flag), 0, 0, flagBm.Width, flagBm.Height);
            flagBuf.Add(flag);
            arrayFlag.RemoveAt(arrayFlag.IndexOf(flag));
            pbFlag.Image = flagBm;
        }



        private void loadFlagForm()
        {
            cbVariantA.Text = string.Empty;
            cbVariantB.Text = string.Empty;
            cbVariantC.Text = string.Empty;
            cbVariantD.Text = string.Empty;

            lbCount.Text = count.ToString();

            Flag flagB = new Flag();
            for (int countF = 0; globalFlagCount < flagDb.flagsList().Count() && countF < 4; globalFlagCount++, countF++)
            {
                flagB = flagDb.getConcreteFlag(globalFlagCount);
                arrayFlag.Add(flagB);
                arrayAnswers.Add(arrayFlag.ElementAt(countF).Name);
               
            }
            comboBoxLoad();

            foreach (var pb in arrayPb)
                Draw(pb);

            flagDb.clearWorkFlags();
        }

        private void comboBoxLoad()
        {
            List<string> arrayAnswersBuf = new List<string>(arrayAnswers);
            ShuffleList.Shuffle(arrayAnswersBuf);
            foreach (var cbA in arrayCb)
            {
                for (int i = 0; i < 4; i++)
                    cbA.Items.Add(arrayAnswersBuf.ElementAt(i));
            }
        }

        private void comboBoxClear()
        {
            foreach (var cbA in arrayCb)
                cbA.Items.Clear();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (count + 1 == flagDb.flagsList().Count)
            {
                MessageBox.Show("Поздравляем! Вы прошли эту игру. Можете взять печеньку :)", "Конец игры");
                this.Close();
            }
            string answers = "";
            if(cbVariantA.SelectedItem == null || cbVariantB.SelectedItem == null ||cbVariantC.SelectedItem == null ||cbVariantD.SelectedItem == null)
            { 
                MessageBox.Show("Вы не выбрали один из ответов! Попробуйте ещё раз.", "Ошибка");
                return;
            }
            /*int countA = 0;
            foreach (var cbA in arrayCb)
                if (cbA.SelectedItem.ToString() == flagBuf.ElementAt(countA).Name)
                    countA++;
            if (countA == 4)*/
            if (facade.checkAnswerFour(arrayCb, flagBuf))
            {
                MessageBox.Show("Правильный ответ!", "Ответ");
                count++;
                arrayAnswers.Clear();
                arrayFlag.Clear();
                flagBuf.Clear();
                comboBoxClear();
                loadFlagForm();
            }
            else
            {
                for (int i = 0; i < flagBuf.Count; i++ )
                    answers += flagBuf.ElementAt(i).Name + " ";
                MessageBox.Show("Неправильный ответ! Правильный: " + answers, "Ответ");
                this.Close();
            }
        }


        private void MultipleFlags_SizeChanged(object sender, EventArgs e)
        {
        }

        private void MultipleFlags_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (count > Properties.Settings.Default.bestStreakMultiple)
            {
                Properties.Settings.Default.bestStreakMultiple = count;
                Properties.Settings.Default.Save();
            }
        }

    }
}