using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagsGame
{
    public class CheckOne
    {
        public bool Check(Button btn, Button trueBtn)
        {
            return btn == trueBtn;
        }
    }
}
