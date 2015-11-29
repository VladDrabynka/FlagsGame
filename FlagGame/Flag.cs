using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace FlagGame
{
    public class Flag
    {
        string _name, _path;
        IFlagPainter _painter;

        public Flag()
        { 
            
        }

        public Flag(string name, string path)
        {
            _name = name;
            _path = path;
            _painter = new FlagPainter();
        }

        public Flag(string name, string path, FlagPainter painter)
        {
            _name = name;
            _path = path;
            _painter = painter;
        }

        public Flag(Flag flag)
        {
            _name = flag.Name;
            _path = flag.Path;
            _painter = flag._painter;
        }

        public override string ToString()
        {
            return _name;
        }

        public override int GetHashCode()
        {
            return _name.GetHashCode() ^ _path.GetHashCode();
        }

       public string Name
       {
           get 
           { 
               return _name; 
           }
       }

       public string Path
       {
           get 
           { 
               return _path; 
           }
       }

       
    }
}
