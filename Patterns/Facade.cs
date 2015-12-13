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
using FlagsGame;

namespace FlagGame
{
    class Facade
    {
        static ClassicWithoutTime modeClassic1 = new ClassicWithoutTime();
        static ClassicWithTime modeClassic2 = new ClassicWithTime();
        static Multiple modeMultiple = new Multiple();

        public static void modeClassic1Enable()
        {
            modeClassic1.Show();
        }

        public static void modeClassic2Enable()
        {
            modeClassic2.Show();
        }

        public static void modeMultipleEnable()
        {
            modeMultiple.Show();
        }
    }
}

