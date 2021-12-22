using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab123
{
    class Tree
    {
        private TreeNode Root;

        private Dictionary<int, List<Segment>> Dict;

        public int Depth { get; set; }

        public Tree(TreeNode root)
        {
            Root = root;
            Dict = new Dictionary<int, List<Segment>>();
            Depth = 0;
        }
        public Tree()
        {
            Root = null;
            Dict = new Dictionary<int, List<Segment>>();
            Depth = 0;
        }
        
        
        public void InOrderTraversal()
        {
            if (Root != null)
            {
                for (int i = 0; i < Depth; i++)
                {
                    Dict.Add(i, new List<Segment>());
                }
                Root.InOrderTraversal(null, Dict, 0);
            }
            else
                Console.WriteLine("Empty");
        }
        
        public void Insert(Segment data)
        {
            if (Root != null)
            {
                Depth = Root.Insert(data, Depth, Dict);                
            }
            else 
                Root = new TreeNode(data);
        }

        public void prettyPrint()
        {
            for(int i = 0; i < Depth; i++)
            {
                List<Segment> l = Dict[i];
                foreach(Segment s in l) {
                    string indent = new string(' ', i);
                    Console.WriteLine(indent + s);
                }
            }
        }
    }
    
}
