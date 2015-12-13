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

        public void LoadXml(string path)
        {
            flags = new List<Flag>();
            workingFlags = new List<Flag>();
            XDocument loadFile = XDocument.Load(path);
            XElement mainElement = loadFile.Element("flags");

            foreach (var flag in mainElement.Elements("flag"))
                flags.Add(new Flag(flag.Attribute("name").Value, flag.Attribute("path").Value));

            ShuffleList.Shuffle(flags);
        }

        public void SaveXml()
        { //to do 
        }

        public Flag getRandomFlag()
        {
            Random rnd = new Random();
            Flag flag = new Flag();
            if (workingFlags.Capacity == 0)
            {
                flag = flags[rnd.Next(0, flags.Count)];
                workingFlags.Add(flag);
            }
            else
            {
                do
                {
                    flag = flags[rnd.Next(0, flags.Count)];
                }
                while (workingFlags.IndexOf(flag) != -1);
                workingFlags.Add(flag);  
            }
            return flag;
        }

        public Flag getConcreteFlag(int count)
        {
            Flag flag = new Flag();
            if (workingFlags.Capacity == 0)
            {
                flag = flags[count];
                workingFlags.Add(flag);
            }
            else
            {
                do
                {
                    flag = flags[count];
                }
                while (workingFlags.IndexOf(flag) != -1);
                workingFlags.Add(flag);
            }
            return flag;
        }

        
        public void clearWorkFlags()
        {
            workingFlags.Clear();
        }

       
        public List<Flag> workingFlagsList()
        { 
            return workingFlags;
        }

    }
}
