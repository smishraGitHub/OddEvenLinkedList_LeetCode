using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenLinkedList_LeetCode
{
    public class Node
    {
        public int val;
        public Node next;

        public Node(int data)
        {
            val = data;
            next = null;
        }
    }

    public class LinkedList
    {
        Node root;

        public LinkedList()
        {
            root = null;
        }

        public void InsertNode(int data)
        {
            Node newNode = new Node(data);
            if(root !=null)
            {
                newNode.next = root;
            }
            root = newNode;
        }

        public Node ReturnNode()
        {
            return root;
        }

        public void showNode(Node root)
        {
            Node temp = root;
            while(temp != null)
            {
                Console.Write(temp.val + " ");
                temp = temp.next;
            }
        }

        public Node ReverseNode(Node root)
        {
            if (root == null || root.next == null) return root;

            Node newNode = ReverseNode(root.next);
            root.next.next = root;
            root.next = null;

            return newNode;

        }

        public Node OddEvenFunction(Node root)
        {
            Node temp = root;


            if (temp==null || temp.next == null)
            {
                return temp;
            }
            else
            {
                //The first node is considered odd, and the second node is even

                Node temp1 = null;
                Node temp2 = null;
                while (temp !=null)
                {
                    Node newNode1 = new Node(temp.val);
                    if(temp1 !=null)
                    {
                        newNode1.next = temp1;
                    }
                    temp1 = newNode1;

                    temp = temp.next;

                    if(temp !=null)
                    {
                        Node newNode2 = new Node(temp.val);
                        if (temp2 != null)
                        {
                            newNode2.next = temp2;
                        }
                        temp2 = newNode2;
                        temp = temp.next;
                    }
                }


                temp2=ReverseNode(temp2);

                while (temp2 !=null)
                {
                    Node newNode1 = new Node(temp2.val);
                    if (temp1 != null)
                    {
                        newNode1.next = temp1;
                    }
                    temp1 = newNode1;

                    temp2 = temp2.next;
                }

                return temp1;
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            LinkedList ls = new LinkedList();
            ls.InsertNode(1);
            ls.InsertNode(2);
            ls.InsertNode(3);
            ls.InsertNode(4);
            ls.InsertNode(5);
            ls.InsertNode(6);

            Node returnNode=ls.ReturnNode();

            ls.showNode(returnNode);

            Console.WriteLine();

            Node result = ls.OddEvenFunction(returnNode);

            ls.showNode(result);

            Console.ReadLine();


            //Given the head of a singly linked list, group all the nodes with odd indices together followed by 
            //the nodes with even indices, and return the reordered list.

            //The first node is considered odd, and the second node is even, and so on.




        }
    }
}
