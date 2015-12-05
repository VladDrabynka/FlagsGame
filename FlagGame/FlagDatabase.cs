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
        List<Flag> workingFlags;
        //FlagDatabase();

        public void LoadXml(string path)
        {
            flags = new List<Flag>();
            workingFlags = new List<Flag>();
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
            Flag flag = new Flag();
            flag = flags[rnd.Next(0, flags.Count)];
            workingFlags.Add(flag);
            return flag;
        }

        public Flag getOtherRandomFlag()
        {
            Random rnd = new Random();
            Flag flag = new Flag();
            do
            {
                flag = flags[rnd.Next(0, flags.Count)];
            }
            while (workingFlags.IndexOf(flag) != -1);
            workingFlags.Add(flag);  
            return flag;
        }

        public void clearWorkFlags()
        {
            workingFlags.Clear();
        }

        public List<Flag> FlagsList()
        { 
            return flags;
        }
    }
}
