using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep
{
    class Node
    {
        public int Data
        {
            get; set;
        }
        public Node Next
        {
            get; set;
        }
        public Node(int data, Node next)
        {
            Data = data;
            Next = null;
        }
    }
}
