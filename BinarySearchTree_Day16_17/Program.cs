using System;

namespace BinarySearchTree_Day16_17
{
    public class BinarySearchTree
    {
        static void Main(string[] args)
        {
          
            public class Node
            {
                public int Data;
                public Node Left;
                public Node Right;
                public void DisplayNode()
                {
                    Console.Write(Data + " ");
                }
            }
            public Node root;
            public BinarySearchTree()
            {
                root = null;
            }
            public void Insert(int i)
            {
                Node newNode = new Node();
                newNode.Data = i;
                if (root == null)
                    root = newNode;
                else
                {
                    Node current = root;
                    Node parent;
                    while (true)
                    {
                        parent = current;
                        if (i < current.Data)
                        {
                            current = current.Left;
                            if (current == null)
                            {
                                parent.Left = newNode;
                                break;
                            }

                            else
                            {
                                current = current.Right;
                                if (current == null)
                                {
                                    parent.Right = newNode;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            static void Main()
            {
                BinarySearchTree nums = new BinarySearchTree();
                nums.Insert(50);
                nums.Insert(17);
                nums.Insert(23);
                nums.Insert(12);
                nums.Insert(19);
                nums.Insert(54);
                nums.Insert(9);
                nums.Insert(14);
                nums.Insert(67);
                nums.Insert(76);
                nums.Insert(72);
            }
        }

    }
}
    