using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ical.Parser.Tree
{
    public class ParserTree : IParserTree
    {
        private string _rawData;

        public ParserTree(string rawData)
        {
            this._rawData = rawData;
        }

        public Tree Parsing()
        {
            string rawString = this._rawData;
            Tree parrent = new Tree { Parrent = null,Value = "",Children = new List<Tree>()};
            Tree child = parrent;

            foreach (char c in rawString)
            {
                if (c == '{')
                {
                    child = new Tree { Parrent = child, Value = string.Empty, Children = new List<Tree>() };
                    child.Parrent.Children.Add(child);
                }
                else if (c == '}')
                {
                    child = new Tree { Parrent = child.Parrent.Parrent, Value = string.Empty, Children = new List<Tree>() };
                    if (child.Parrent != null)
                    {
                        child.Parrent.Children.Add(child);
                    }
                }
                else
                {
                    child.Value += c;
                }
            }

            return parrent;
        }

        public void RenderTree(Tree tree, string level)
        {
            if (tree.Value.Length > 0)
                Console.WriteLine(level + tree.Value);

            foreach (Tree t in tree.Children)
            {
                RenderTree(t, level + "-\\");
            }
        }
    }
}
