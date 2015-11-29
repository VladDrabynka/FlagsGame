using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlagGame
{
    public interface IFlagPainter
    {
        Bitmap Draw(Flag flag);
    }
}
