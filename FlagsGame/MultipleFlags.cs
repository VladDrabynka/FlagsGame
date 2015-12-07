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
        Flag flag = new Flag();
        FlagDatabase flagDb = new FlagDatabase();

        KeyValuePair<int, Flag> kwpFlags = new KeyValuePair<int, Flag>();
        List<Flag> arrayFlag = new List<Flag>();
        List<Button> arrayBut = new List<Button>();
        List<PictureBox> arrayPb = new List<PictureBox>();

        public MultipleFlags()
        {
            InitializeComponent();
        }

        private void MultipleFlags_Load(object sender, EventArgs e)
        {
            string pathStats = path + @"\stats.txt";
            flagDb.LoadXml(path + @"\FlagDatabaseRU.xml");
            //if (File.ReadAllText(pathStats).Length == 0)
            //    lbBest.Text = "0";
            //else
            //    lbBest.Text = File.ReadAllText(pathStats);
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
            arrayFlag.RemoveAt(arrayFlag.IndexOf(flag));
            pbFlag.Image = flagBm;
        }

        private void loadFlagForm()
        {
            arrayBut.Add(btnVariantA);
            arrayBut.Add(btnVariantB);
            arrayBut.Add(btnVariantC);
            arrayBut.Add(btnVariantD);
            ShuffleList.Shuffle(arrayBut);
           
            arrayPb.Add(pbFlag1);
            arrayPb.Add(pbFlag2);
            arrayPb.Add(pbFlag3);
            arrayPb.Add(pbFlag4);

            foreach (var btn in arrayBut)
            {
                btn.Text = flagDb.getRandomFlag().Name;

            }

            arrayFlag = flagDb.workingFlagsList();

            foreach (var pb in arrayPb)
                Draw(pb);

            arrayFlag = flagDb.workingFlagsList();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
       //     if(cbVariantA.SelectedIndex == )
        }
    }
}
