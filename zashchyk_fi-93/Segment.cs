using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab123
{
    public class Segment
    {
        public int Min { get; set; }
        public int Max { get; set; }
       
        public Segment(int min, int max) //Конструктор для Segment
        {
            Min = min;
            Max = max;
        }
        public bool Includes(Segment segment1, Segment segment2) //Перевірка на включення 2 в 1
        {
            if (segment1.Min < segment2.Min && segment1.Max > segment2.Max)
            {
                return true;
            }

            else if (segment1.Min == segment2.Min && segment1.Max > segment2.Max)
            {
                return true;
            }

            else if (segment1.Min < segment2.Min && segment1.Max == segment2.Max)
            {
                return true;
            }

            else if (segment1.Min == segment2.Min && segment1.Max == segment2.Max)
            {
                return true;
            }

            else return false;
        }

        public void PrintSegment()
        {
            Console.Write(Min + " " + Max); 
        }
        public override string ToString()
        {
            return $"{Min} , {Max}";
        }






    }
}
