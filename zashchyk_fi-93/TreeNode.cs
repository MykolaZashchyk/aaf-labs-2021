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