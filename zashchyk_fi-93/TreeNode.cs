using System;
using System.Collections.Generic;

namespace Lab123
{
    public class TreeNode
    {
        private Segment firstSegment;
        private Segment secondSegment;
        private TreeNode firstSegmentReference;
        private TreeNode secondSegmentReference;

        public TreeNode()
        {
            firstSegment = null;
            secondSegment = null;
            firstSegmentReference = null;
            secondSegmentReference = null;
        }

        public TreeNode(Segment data)
        {
            firstSegment = data;
            secondSegment = null;
            firstSegmentReference = null;
            secondSegmentReference = null;
        }

        public TreeNode(Segment data1, Segment data2)
        {
            firstSegment = data1;
            secondSegment = data2;
            firstSegmentReference = null;
            secondSegmentReference = null;
        }

        /*public void prettyPrint(int notprint)
        {
            if (firstSegment != null && secondSegment == null && firstSegmentReference == null && secondSegmentReference == null)
            {
                if (notprint == 0)
                    Console.Write("|" + firstSegment + "|" + "\n");

            }
            if (firstSegment == null && secondSegment != null && firstSegmentReference == null && secondSegmentReference == null)
            {
                if (notprint == 0)
                    Console.Write("|" + secondSegment + "|" + "\n");

            }
            if (firstSegment != null && secondSegment != null && firstSegmentReference == null && secondSegmentReference == null)
            {
                if (notprint == 0)
                    Console.Write("|" + firstSegment + "|" + "|" + secondSegment + "|" + "\n");

            }
            if (firstSegment != null && secondSegment == null && firstSegmentReference != null && secondSegmentReference == null)
            {
                if (notprint == 0)
                {
                    Console.Write("|" + firstSegment + "|" + "\n");
                }
                notprint = 0;
                firstSegmentReference.prettyPrint(notprint);
            }
            if (firstSegment == null && secondSegment != null && firstSegmentReference == null && secondSegmentReference != null)
            {
                if (notprint == 0)
                {
                    Console.Write("|" + secondSegment + "|" + "\n");
                }
                notprint = 0;
                secondSegmentReference.prettyPrint(notprint);
            }

            if (firstSegment != null && secondSegment != null && firstSegmentReference == null && secondSegmentReference != null)
            {
                if (notprint == 0)
                    Console.Write("|" + firstSegment + "|" + "|" + secondSegment + "|" + "\n");
                notprint = 0;
                secondSegmentReference.prettyPrint(notprint);
            }
            if (firstSegment != null && secondSegment != null && firstSegmentReference != null && secondSegmentReference == null)
            {
                if (notprint == 0)
                    Console.Write("|" + firstSegment + "|" + "|" + secondSegment + "|" + "\n");
                notprint = 0;
                firstSegmentReference.prettyPrint(notprint);
            }


            
            //1111
            if (firstSegment != null && secondSegment != null && firstSegmentReference != null && secondSegmentReference != null &&
                firstSegmentReference.firstSegment != null && firstSegmentReference.secondSegment != null &&
                secondSegmentReference.firstSegment != null && secondSegmentReference.secondSegment != null)
            {
                Console.Write("|" + firstSegment + "|" + "|" + secondSegment + "|" + "\n");
                Console.Write("|" + firstSegmentReference.firstSegment + "|" + "|" + firstSegmentReference.secondSegment + "|" + "//" +
                    "|" + secondSegmentReference.firstSegment + "|" + "|" + secondSegmentReference.secondSegment + "|" + "\n");
                firstSegmentReference.prettyPrint(1);
                secondSegmentReference.prettyPrint(1);
            }

            //1110
            if (firstSegment != null && secondSegment != null && firstSegmentReference != null && secondSegmentReference != null &&
                firstSegmentReference.firstSegment != null && firstSegmentReference.secondSegment != null &&
                secondSegmentReference.firstSegment != null && secondSegmentReference.secondSegment == null)
            {
                Console.Write("|" + firstSegment + "|" + "|" + secondSegment + "|" + "\n");
                Console.Write("|" + firstSegmentReference.firstSegment + "|" + "|" + firstSegmentReference.secondSegment + "|" + "//" +
                    "|" + secondSegmentReference.firstSegment + "|" + "\n");
                firstSegmentReference.prettyPrint(1);
                secondSegmentReference.prettyPrint(1);
            }

            //1101
            if (firstSegment != null && secondSegment != null && firstSegmentReference != null && secondSegmentReference != null &&
                firstSegmentReference.firstSegment != null && firstSegmentReference.secondSegment != null &&
                secondSegmentReference.firstSegment == null && secondSegmentReference.secondSegment != null)
            {
                Console.Write("|" + firstSegment + "|" + "|" + secondSegment + "|" + "\n");
                Console.Write("|" + firstSegmentReference.firstSegment + "|" + "|" + firstSegmentReference.secondSegment + "|" + "//" +
                     "|" + secondSegmentReference.secondSegment + "|" + "\n");
                firstSegmentReference.prettyPrint(1);
                secondSegmentReference.prettyPrint(1);
            }

            //1100
            if (firstSegment != null && secondSegment != null && firstSegmentReference != null && secondSegmentReference != null &&
                firstSegmentReference.firstSegment != null && firstSegmentReference.secondSegment != null &&
                secondSegmentReference.firstSegment == null && secondSegmentReference.secondSegment == null)
            {
                Console.Write("|" + firstSegment + "|" + "|" + secondSegment + "|" + "\n");
                Console.Write("|" + firstSegmentReference.firstSegment + "|" + "|" + firstSegmentReference.secondSegment + "|" + "//" + "\n");
                firstSegmentReference.prettyPrint(1);
                secondSegmentReference.prettyPrint(1);
            }

            //1011
            if (firstSegment != null && secondSegment != null && firstSegmentReference != null && secondSegmentReference != null &&
                firstSegmentReference.firstSegment != null && firstSegmentReference.secondSegment == null &&
                secondSegmentReference.firstSegment != null && secondSegmentReference.secondSegment != null)
            {
                Console.Write("|" + firstSegment + "|" + "|" + secondSegment + "|" + "\n");
                Console.Write("|" + firstSegmentReference.firstSegment + "|" + "//" +
                    "|" + secondSegmentReference.firstSegment + "|" + "|" + secondSegmentReference.secondSegment + "|" + "\n");
                firstSegmentReference.prettyPrint(1);
                secondSegmentReference.prettyPrint(1);
            }

            //1010
            if (firstSegment != null && secondSegment != null && firstSegmentReference != null && secondSegmentReference != null &&
                firstSegmentReference.firstSegment != null && firstSegmentReference.secondSegment == null &&
                secondSegmentReference.firstSegment != null && secondSegmentReference.secondSegment == null)
            {
                Console.Write("|" + firstSegment + "|" + "|" + secondSegment + "|" + "\n");
                Console.Write("|" + firstSegmentReference.firstSegment + "|"+ "//" +
                    "|" + secondSegmentReference.firstSegment + "|" + "\n");
                firstSegmentReference.prettyPrint(1);
                secondSegmentReference.prettyPrint(1);
            }

            //1001
            if (firstSegment != null && secondSegment != null && firstSegmentReference != null && secondSegmentReference != null &&
                firstSegmentReference.firstSegment != null && firstSegmentReference.secondSegment == null &&
                secondSegmentReference.firstSegment == null && secondSegmentReference.secondSegment != null)
            {
                Console.Write("|" + firstSegment + "|" + "|" + secondSegment + "|" + "\n");
                Console.Write("|" + firstSegmentReference.firstSegment + "|" + "//" + "|" + secondSegmentReference.secondSegment + "|" + "\n");
                firstSegmentReference.prettyPrint(1);
                secondSegmentReference.prettyPrint(1);
            }

            //1000
            if (firstSegment != null && secondSegment != null && firstSegmentReference != null && secondSegmentReference != null &&
                firstSegmentReference.firstSegment != null && firstSegmentReference.secondSegment == null &&
                secondSegmentReference.firstSegment == null && secondSegmentReference.secondSegment == null)
            {
                Console.Write("|" + firstSegment + "|" + "|" + secondSegment + "|" + "\n");
                Console.Write("|" + firstSegmentReference.firstSegment + "|" + "//" + "\n");
                firstSegmentReference.prettyPrint(1);
                secondSegmentReference.prettyPrint(1);
            }

            //0111
            if (firstSegment != null && secondSegment != null && firstSegmentReference != null && secondSegmentReference != null &&
                firstSegmentReference.firstSegment == null && firstSegmentReference.secondSegment != null &&
                secondSegmentReference.firstSegment != null && secondSegmentReference.secondSegment != null)
            {
                Console.Write("|" + firstSegment + "|" + "|" + secondSegment + "|" + "\n");
                Console.Write("|" + firstSegmentReference.secondSegment + "|" + "//" +
                    "|" + secondSegmentReference.firstSegment + "|" + "|" + secondSegmentReference.secondSegment + "|" + "\n");
                firstSegmentReference.prettyPrint(1);
                secondSegmentReference.prettyPrint(1);
            }

            //0110
            if (firstSegment != null && secondSegment != null && firstSegmentReference != null && secondSegmentReference != null &&
                firstSegmentReference.firstSegment == null && firstSegmentReference.secondSegment != null &&
                secondSegmentReference.firstSegment != null && secondSegmentReference.secondSegment == null)
            {
                Console.Write("|" + firstSegment + "|" + "|" + secondSegment + "|" + "\n");
                Console.Write("|" + firstSegmentReference.secondSegment + "|" + "//" +
                    "|" + secondSegmentReference.firstSegment + "|" + "\n");
                firstSegmentReference.prettyPrint(1);
                secondSegmentReference.prettyPrint(1);
            }

            //0101
            if (firstSegment != null && secondSegment != null && firstSegmentReference != null && secondSegmentReference != null &&
                firstSegmentReference.firstSegment == null && firstSegmentReference.secondSegment != null &&
                secondSegmentReference.firstSegment == null && secondSegmentReference.secondSegment != null)
            {
                Console.Write("|" + firstSegment + "|" + "|" + secondSegment + "|" + "\n");
                Console.Write("|" + firstSegmentReference.secondSegment + "|" + "//" + "|" + secondSegmentReference.secondSegment + "|" + "\n");
                firstSegmentReference.prettyPrint(1);
                secondSegmentReference.prettyPrint(1);
            }

            //0100
            if (firstSegment != null && secondSegment != null && firstSegmentReference != null && secondSegmentReference != null &&
                firstSegmentReference.firstSegment == null && firstSegmentReference.secondSegment != null &&
                secondSegmentReference.firstSegment == null && secondSegmentReference.secondSegment == null)
            {
                Console.Write("|" + firstSegment + "|" + "|" + secondSegment + "|" + "\n");
                Console.Write("|" + firstSegmentReference.secondSegment + "|" + "//" + "\n");
                firstSegmentReference.prettyPrint(1);
                secondSegmentReference.prettyPrint(1);
            }

            //0011
            if (firstSegment != null && secondSegment != null && firstSegmentReference != null && secondSegmentReference != null &&
                firstSegmentReference.firstSegment == null && firstSegmentReference.secondSegment == null &&
                secondSegmentReference.firstSegment != null && secondSegmentReference.secondSegment != null)
            {
                Console.Write("|" + firstSegment + "|" + "|" + secondSegment + "|" + "\n");
                Console.Write("//" + "|" + secondSegmentReference.firstSegment + "|" + "|" + secondSegmentReference.secondSegment + "|" + "\n");
                firstSegmentReference.prettyPrint(1);
                secondSegmentReference.prettyPrint(1);
            }

            //0010
            if (firstSegment != null && secondSegment != null && firstSegmentReference != null && secondSegmentReference != null &&
                firstSegmentReference.firstSegment == null && firstSegmentReference.secondSegment == null &&
                secondSegmentReference.firstSegment != null && secondSegmentReference.secondSegment == null)
            {
                Console.Write("|" + firstSegment + "|" + "|" + secondSegment + "|" + "\n");
                Console.Write("//" + "|" + secondSegmentReference.firstSegment + "|" + "\n");
                firstSegmentReference.prettyPrint(1);
                secondSegmentReference.prettyPrint(1);
            }

            //0001
            if (firstSegment != null && secondSegment != null && firstSegmentReference != null && secondSegmentReference != null &&
                firstSegmentReference.firstSegment == null && firstSegmentReference.secondSegment == null &&
                secondSegmentReference.firstSegment == null && secondSegmentReference.secondSegment != null)
            {
                Console.Write("|" + firstSegment + "|" + "|" + secondSegment + "|" + "\n");
                Console.Write("//" + "|" + secondSegmentReference.secondSegment + "|" + "\n");
                firstSegmentReference.prettyPrint(1);
                secondSegmentReference.prettyPrint(1);
            }


        }*/
        /*
        public void prettyPrint(Segment parent) // Обхід по порядку
        {

            if (firstSegment != null && firstSegmentReference != null)
            {
                firstSegmentReference.prettyPrint(firstSegment);
            }
            Console.WriteLine(firstSegment);



            if (secondSegment != null && secondSegmentReference != null)
            {
                if (parent != null)
                {
                    Console.WriteLine(parent);
                }
                secondSegmentReference.prettyPrint(secondSegment);
            }

            if (firstSegmentReference == null && secondSegmentReference == null)
            {
                Console.WriteLine(secondSegment);
            }
        }*/
        //dict[depth].Add(data);        
        public void InOrderTraversal(Segment parent, Dictionary<int, List<Segment>> dict, int depth) // Обхід по порядку
        {
            if (firstSegment != null)
                dict[depth].Add(firstSegment);

            if(secondSegment != null)
                dict[depth].Add(secondSegment);

            depth++;

            if (firstSegment != null && firstSegmentReference != null)
            { 
                firstSegmentReference.InOrderTraversal(firstSegment, dict, depth);
            }
            

            if (secondSegment != null && secondSegmentReference != null)
            {

                secondSegmentReference.InOrderTraversal(secondSegment, dict, depth);
            }

            
        }
        

        public int Insert(Segment data, int depth, Dictionary<int, List<Segment>> dict)
        {
            if (firstSegment == null)
            {
                firstSegment = data;
            }
            else
                if (firstSegment.Includes(firstSegment, data) == true)
            {

                if (firstSegmentReference == null)
                {

                    firstSegmentReference = new TreeNode(data);
                    depth++;
                }
                else
                    depth = firstSegmentReference.Insert(data, depth, dict);
            }

            else
                if (secondSegment == null)
            {
                secondSegment = data;              
            }
            else
                    if (secondSegment.Includes(secondSegment, data) == true)
            {
                if (secondSegmentReference == null)
                {
                    secondSegmentReference = new TreeNode(data);
                    depth++;
                }

                else
                depth = secondSegmentReference.Insert(data, depth, dict);
            }

            else
                Console.WriteLine("Cannot insert " + data);
            
            return depth;
        }
    }
}