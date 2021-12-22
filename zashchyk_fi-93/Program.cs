using System;
using System.Collections.Generic;

using System.Text.RegularExpressions;

namespace Lab123
{
    class Program
    {
        /*static string parseCommand(string query)
        {
            query = query.Replace(" ", "");
            query.Replace(Environment.NewLine, "");
            return query;
        }
        *//*
        static List<Segment> searchInsert(string query)
        {
            string tempQuery = query;
            
            for (int i = 0; i < query.Length; i++)
            {
                if ((query[i] == 'i' || query[i] == 'i') && 
            }
        }*/

        static void Main(string[] args)
        {
            /*
            string query = "";
            while (query != "EXIT")
            {

                query = Console.ReadLine();
                Tree newTree = null;
                if (query == "CREATE")
                {

                    newTree = new Tree();
                }
                /*insert [2,4] [5,8];
                if (searchInsert(query) == true)
                {
                    if (newTree == null)
                    {

                    }
                    else
                    {
                        foreach (Segment s in l)
                        {
                            newTree.Insert(s);
                        }
                    }
                       


                       //newTree.Insert(new Segment(3, 11));
                }

                if (query == "PRINT")
                {
                    newTree.prettyPrint();
                }

            }*/
            
        
            
            Tree newTree = new Tree(new TreeNode());
            newTree.Insert(new Segment(2, 10));
            newTree.Insert(new Segment(3, 4));
            newTree.Insert(new Segment(2, 10));
            newTree.Insert(new Segment(2, 7));
            newTree.Insert(new Segment(2, 7));
            newTree.Insert(new Segment(4, 6));
            newTree.Insert(new Segment(5, 10));
            newTree.Insert(new Segment(5, 8));
            newTree.Insert(new Segment(5, 10));
            

            newTree.InOrderTraversal();
            newTree.prettyPrint();
            

            Console.ReadLine();

            
        }
    }
}
