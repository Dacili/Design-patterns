using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Iterator
{
    public interface ITreeIterator
    {
        void moveDownTop();
        void moveTopDown();
    }

    public interface IterableTreeCollection{
         ITreeIterator createIterator();
    }

    public class Node
    {
        public int value;
        public Node left;
        public Node right;
    }

    // IEnumerable
    public class BinaryTryTree : IterableTreeCollection
    {

        public Node insert(Node root, int v)
            {
                if (root == null)
                {
                    root = new Node();
                    root.value = v;
                }
                else if (v < root.value)
                {
                    root.left = insert(root.left, v);
                }
                else
                {
                    root.right = insert(root.right, v);
                }

                return root;
            }

        public ITreeIterator createIterator()
        {
            var bst = new TreeIterator(new BinaryTryTree());
            bst.initialize();
            return bst;
        }

        // Enumerator
        public class TreeIterator : ITreeIterator
        {
            BinaryTryTree bst; 
            Node root = null;
            Node current = null; // state

            public TreeIterator(BinaryTryTree btt)
            {
                bst = btt;
            }

            public void initialize()
            {
                int SIZE = 5;
                int[] a = new int[SIZE];
                current = root;

                Random random = new Random();
                for (int i = 0; i < SIZE; i++)
                {
                    var temp = random.Next(30);
                    a[i] = temp;
                    Console.WriteLine(temp);
                }

                Console.WriteLine();
                Console.WriteLine("Filling the tree with {0} nodes...", SIZE);

                for (int i = 0; i < SIZE; i++)
                {
                    root = bst.insert(root, a[i]);
                }
            }

            private void traverseFromDown(Node root)
            {
                if (root == null)
                {
                    return;
                }

                traverseFromDown(root.left);
                traverseFromDown(root.right);
                Console.WriteLine(root.value);
            }


            private void traverseFromTop(Node root)
            {
                if (root == null)
                {
                    return;
                }
                Console.WriteLine(root.value);
                traverseFromDown(root.left);
                traverseFromDown(root.right);

            }

            public void moveDownTop()
            {
                Console.WriteLine("Traversing all nodes in tree from down-top...");
                traverseFromDown(root);
            }

            public void moveTopDown()
            {
                Console.WriteLine("Traversing all nodes in tree from top-down...");
                traverseFromTop(root);
            }
        }
    }



    

}
