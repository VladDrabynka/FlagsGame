using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace FlagGame
{
    class FlagDatabase
    {
        List<Flag> flags;

        FlagDatabase();

        public void LoadXml()
        {
            XDocument xdocument = new XDocument();
            IEnumerable<XElement> mainElement = xdocument.Elements();

            foreach (var flags in mainElement)
                foreach (var flag in flags.Elements())
                     flags.Add(new Flag(flag.FirstAttribute.Value.ToString(), flag.LastAttribute.Value.ToString()));
        }

        public void SaveXml()
        { //to do 
        }

        public Flag getRandomFlag()
        {//to do
            return new Flag("", "");
        }

        public List<Flag> FlagsList()
        { 
            return flags;
        }
    }
}
