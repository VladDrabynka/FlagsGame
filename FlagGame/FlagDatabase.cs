using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace FlagGame
{
    public class FlagDatabase
    {
        List<Flag> flags;

        //FlagDatabase();

        public void LoadXml(string path)
        {
            XDocument loadFile = XDocument.Load(path);
            XElement mainElement = loadFile.Element("flags");

            foreach (var flag in mainElement.Elements("flag"))
                flags.Add(new Flag(flag.Attribute("name").Value, flag.Attribute("path").Value));
        }

        public void SaveXml()
        { //to do 
        }

        public Flag getRandomFlag()
        {
            Random rnd = new Random();
            return flags[rnd.Next(0, flags.Count)];
        }

        public List<Flag> FlagsList()
        { 
            return flags;
        }
    }
}
