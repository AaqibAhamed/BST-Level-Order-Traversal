using System;
using System.Collections.Generic;
using System.Text;

namespace BST_Level_Order_Traversal
{
    class Node
    {
        public Node left, right;
        public int data;
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
}
