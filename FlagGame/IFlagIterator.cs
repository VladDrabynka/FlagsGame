using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FlagGame
{
    public interface IFlagIterator
    {
        void Next();
        bool IsDone();
        Flag CurrentItem();
        bool IsExist();
    }
}
