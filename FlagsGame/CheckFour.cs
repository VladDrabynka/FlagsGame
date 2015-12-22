using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlagGame;

namespace FlagsGame
{
    public class CheckFour
    {
        public bool Check(List<ComboBox> arrayCb, List<Flag> flagBuf)
        {
            int count = 0;
            foreach (var cbA in arrayCb)
                if (cbA.SelectedItem.ToString() == flagBuf.ElementAt(count).Name)
                    count++;
            return count == 4;
        }
    }
}
