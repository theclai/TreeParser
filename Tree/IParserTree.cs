using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ical.Parser.Tree
{
    public interface IParserTree
    {
        Tree Parsing();
        void RenderTree(Tree tree, string level);
    }
}
