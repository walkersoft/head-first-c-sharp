using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    abstract public class Location
    {
        public string Name { get; set; }
        public Location[] Exits { get; set; }

        public Location(string name)
        {
            Name = name;
        }

        public virtual string Description 
        {
            get
            {
                string description = "You are standing in the " + Name + ". You see exits to the following place(s):";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;
                    if (i != Exits.Length - 1)
                    {
                        description += ",";
                    }
                }
                description += ".";
                return description;
            }
        }
    }
}
