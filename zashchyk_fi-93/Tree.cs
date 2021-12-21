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

        public Tree(TreeNode root) //Конструктор для Tree
        {
            Root = root;
        }
        public Tree() //Конструктор для Tree
        {
            Root = null;
        }

        /* public Segment Find(TreeNode root, Segment data)
         {
             return root.Find(data);
         }
        */
        
        public void prettyPrint()
        {
            if (Root != null)
            {
                Root.prettyPrint(0);
            }
            else
                Console.WriteLine("Empty");
        }
        
        
        public void InOrderTraversal()
        {
            if (Root != null)
            {
                Root.InOrderTraversal(null);
            }
            else
                Console.WriteLine("Empty");
        }
        
        public void Insert(Segment data)
        {
            if (Root != null)
            {
                Root.Insert(data);
            }
            else 
                Root = new TreeNode(data);
        }
        
    }
    
}
