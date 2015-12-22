using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Collections.Generic;

namespace FlagGame
{
    public class FlagIterator : IFlagIterator
    {
        private FlagDatabase flagList;
        private int current;

        public FlagIterator(FlagDatabase mainElement)
        {
            this.flagList = mainElement;
        }

       

        public void Next()
        {            
            current++;
        }

        public Flag CurrentItem()
        {
            //return new Flag(flagList.ElementAt(current).Attribute("name").Value, flagList.ElementAt(current).Attribute("path").Value);
            return flagList[current];
        }
  
        public bool IsDone()
        {
            return current >= flagList.Size() ;
        }

        public bool IsExist()
        {
            return current < flagList.Size();
        }
    }
}
