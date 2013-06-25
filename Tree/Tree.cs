using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ical.Parser.Tree
{
    public class Tree 
    { 
        public Tree Parrent { get; set; }
        public string Value { get; set; }
        public List<Tree> Children { get; set; }
    }
}
