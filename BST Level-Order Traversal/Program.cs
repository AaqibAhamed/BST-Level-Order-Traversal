using System;
using System.Collections.Generic;

namespace BST_Level_Order_Traversal
{
    class Program
    {
        static void levelOrder(Node root)
        {
            Node temp = root;

            Queue<Node> nodeQueue = new Queue<Node>();

            while(temp != null)
            {
                Console.WriteLine(temp.data + " ");
            }
        }

        static Node Insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = Insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = Insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        static void Main(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = Insert(root, data);
            }
            levelOrder(root);

        }
    }
}
