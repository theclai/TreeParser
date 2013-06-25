using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ical.Parser.Tree;

namespace TreeParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawData = "{Parent{{ChildA{ChildC}{ChildD}}{ChildB{ChildE}{ChildF}}}}";
            IParserTree parseTree = new ParserTree(rawData);
         
            var ret = new Tree();
            ret = parseTree.Parsing();
            parseTree.RenderTree(ret," ");
        }
    }
}
