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
        int count = 0;
        Button trueButton;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            flagDb.LoadXml(path + @"\FlagDatabase.xml");
            loadFlagForm();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            if ((sender as Button) == trueButton)
            {
                MessageBox.Show("Правильный ответ!", "Ответ");
                ++count;
                lbCount.Text = count.ToString();
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
        }

        private void loadFlagForm()
        {
            flag = flagDb.getRandomFlag();
            Draw();
            Random rnd = new Random();
            List<Button> array = new List<Button>();
            array.Add(btnVariantA);
            array.Add(btnVariantB);
            array.Add(btnVariantC);
            array.Add(btnVariantD);
            ShuffleList.Shuffle(array);
            foreach (var btn in array)
                btn.Text = flagDb.getRandomFlag().Name;
            trueButton = array[0];
            array[0].Text = flag.Name;
            flagDb.clearWorkFlags();
        }

        private void fillVariants(Flag flag)
        {
            Random rnd = new Random();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
