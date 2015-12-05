using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace FlagGame
{
    public class FlagPainter : IFlagPainter
    {
        public Bitmap Draw(Flag flag)
        {
            return new Bitmap(flag.Path);
        }
    }
}
