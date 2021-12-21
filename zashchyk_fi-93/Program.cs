using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab123
{
    class Program
    {
        public void parseCommand(string command)
        {
            command.Replace(" ", "");
            command.Replace(Environment.NewLine, "");
        }

        static void Main(string[] args)
        {
            string command;
            while (command != "EXIT")
            {
                command.enterCommand(Console.ReadLine());

                Console.WriteLine(command + "\n");
                

                //command.Parser();
            }


            /*
            Tree newTree = new Tree(new TreeNode(new Segment(3, 11)));
            newTree.Insert(new Segment(2, 10));
            newTree.Insert(new Segment(3, 4));
            newTree.Insert(new Segment(2, 10));
            newTree.Insert(new Segment(2, 7));
            newTree.Insert(new Segment(2, 7));
            newTree.Insert(new Segment(4, 6));
            newTree.Insert(new Segment(5, 10));
            newTree.Insert(new Segment(5, 8));
            newTree.Insert(new Segment(5, 10));

            newTree.prettyPrint();


            Console.ReadLine();

            */
        }
    }
}
