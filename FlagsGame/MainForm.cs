using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlagGame;

namespace FlagsGame
{
    public partial class MainForm : Form
    {
        string path = @"E:\Development\Kurs3\FlagsGame\FlagGame";
        Flag flag = new Flag(), flagBuffer = new Flag();
        FlagDatabase flagDb = new FlagDatabase();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            flagDb.LoadXml(path + @"\FlagDatabase.xml");
            loadFlagForm();
        }

        private void btnVariantA_Click(object sender, EventArgs e)
        {
            if (btnVariantA.Text == flag.Name)
            {
                MessageBox.Show("Правильный ответ!", "Ответ");
                loadFlagForm();
            }
            else
            {
                MessageBox.Show("Неправильный ответ!", "Ответ");
                this.Close();
            }

        }

        private void btnVariantB_Click(object sender, EventArgs e)
        {
            if (btnVariantB.Text == flag.Name)
            {
                MessageBox.Show("Правильный ответ!", "Ответ");
                loadFlagForm();
            }
            else
            {
                MessageBox.Show("Неправильный ответ!", "Ответ");
                this.Close();
            }
        }

        private void btnVariantC_Click(object sender, EventArgs e)
        {
             if (btnVariantC.Text == flag.Name)
             {
                 MessageBox.Show("Правильный ответ!", "Ответ");
                 loadFlagForm();
             }
             else
             {
                 MessageBox.Show("Неправильный ответ!", "Ответ");
                 this.Close();
             }
        }

        private void btnVariantD_Click(object sender, EventArgs e)
        {
            if (btnVariantD.Text == flag.Name)
            {
                MessageBox.Show("Правильный ответ!", "Ответ");
                loadFlagForm();
            }
            else
            {
                MessageBox.Show("Неправильный ответ!", "Ответ");
                this.Close();
            }

        }

        private void loadFlagForm()
        {
            FlagPainter flagP = new FlagPainter();
            flag = flagDb.getRandomFlag();
            Bitmap flagBm = flagP.Draw(flag);
            pbFlag.Image = flagBm;
            Random rnd = new Random();
            switch (rnd.Next(1, 4))
            {
                case 1: btnVariantA.Text = flag.Name;
                    flagBuffer = flagDb.getOtherRandomFlag();
                    btnVariantB.Text = flagBuffer.Name;
                    flagBuffer = flagDb.getOtherRandomFlag();
                    btnVariantC.Text = flagBuffer.Name;
                    flagBuffer = flagDb.getOtherRandomFlag();
                    btnVariantD.Text = flagBuffer.Name;
                    break;
                case 2: btnVariantB.Text = flag.Name;
                    flagBuffer = flagDb.getOtherRandomFlag();
                    btnVariantA.Text = flagBuffer.Name;
                    flagBuffer = flagDb.getOtherRandomFlag();
                    btnVariantC.Text = flagBuffer.Name;
                    flagBuffer = flagDb.getOtherRandomFlag();
                    btnVariantD.Text = flagBuffer.Name;
                    break;
                case 3: btnVariantC.Text = flag.Name;
                    flagBuffer = flagDb.getOtherRandomFlag();
                    btnVariantA.Text = flagBuffer.Name;
                    flagBuffer = flagDb.getOtherRandomFlag();
                    btnVariantB.Text = flagBuffer.Name;
                    flagBuffer = flagDb.getOtherRandomFlag();
                    btnVariantD.Text = flagBuffer.Name;
                    break;
                case 4: btnVariantD.Text = flag.Name;
                    flagBuffer = flagDb.getOtherRandomFlag();
                    btnVariantA.Text = flagBuffer.Name;
                    flagBuffer = flagDb.getOtherRandomFlag();
                    btnVariantB.Text = flagBuffer.Name;
                    flagBuffer = flagDb.getOtherRandomFlag();
                    btnVariantC.Text = flagBuffer.Name;
                    break;
                default: MessageBox.Show("Switch generated something wrong!", "Switch in loadForm"); break;
            }
            flagDb.clearWorkFlags();
        }

      
    }
}
