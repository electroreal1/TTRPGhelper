using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPGhelper
{
    public class PathwayAbility
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public PathwayAbility() { }

        public PathwayAbility(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
