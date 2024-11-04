using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class Node
    {
        public Node next;
        public Node prev;
        public int data;

        public Node(int number)
        {
            data = number;
        }
    }

    internal class List
    {
        public Node head;
        public Node tail;
        public int count;

        public void AddFirst(int number)
        {
            Node newNode = new Node(number);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }
            count++;
        }

        internal class NodeT
        {
            public NodeT parent;
            public NodeT left;
            public NodeT right;
            public int data;

            public NodeT(int number)
            {
                data = number;
            }
        }

        internal class BinarySearchTree
        {
            public NodeT root;

            public void Add(int number)
            {
                if (root == null)
                {
                    root = new NodeT(number);
                }
                else
                {
                    Add(root, number);
                }
            }

            private void Add(NodeT node, int number)
            {
                if (number < node.data)
                {
                    if (node.left == null)
                    {
                        node.left = new NodeT(number) { parent = node };
                    }
                    else
                    {
                        Add(node.left, number);
                    }
                }
                else
                {
                    if (node.right == null)
                    {
                        node.right = new NodeT(number) { parent = node };
                    }
                    else
                    {
                        Add(node.right, number);
                    }
                }
            }

            public void Remove(int number)
            {
                NodeT node = find(root, number);
                if (node == null) return;

                if (node.left == null && node.right == null)
                {
                    if (node == root)
                    {
                        root = null;
                    }
                    else
                    {
                        if (node.parent.left == node) node.parent.left = null;
                        else node.parent.right = null;
                    }
                }
                else if (node.left == null || node.right == null)
                {
                    NodeT child = node.left ?? node.right;

                    if (node == root)
                    {
                        root = child;
                    }
                    else
                    {
                        if (node.parent.left == node) node.parent.left = child;
                        else node.parent.right = child;
                    }

                    child.parent = node.parent;
                }
                else
                {
                    NodeT minRight = FindMin(node.right);
                    node.data = minRight.data;
                    Remove(minRight.data);
                }
            }

            private NodeT FindMin(NodeT node)
            {
                while (node.left != null)
                {
                    node = node.left;
                }
                return node;
            }

            private NodeT find(NodeT node, int number)
            {
                if (node == null || node.data == number)
                {
                    return node;
                }
                if (number < node.data)
                {
                    return find(node.left, number);
                }
                else
                {
                    return find(node.right, number);
                }
            }
        }
    }
}