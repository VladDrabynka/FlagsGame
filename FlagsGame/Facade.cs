using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlagGame;

namespace FlagsGame
{
    public class Facade
    {
        CheckOne chOne = new CheckOne();
        CheckFour chFour = new CheckFour();

        public bool checkAnswerOne(Button btn, Button trueBtn)
        {
            return chOne.Check(btn, trueBtn);
        }
        public bool checkAnswerFour(List<ComboBox> arrayCb, List<Flag> flagBuf)
        {
            return chFour.Check(arrayCb, flagBuf);
        }
    }
}
