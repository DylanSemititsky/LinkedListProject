﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedListProject
{
    class DoubleLinkedList
    {
        private Node start;

        public DoubleLinkedList()
        {
            start = null;
        }

        public void DisplayList()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.Write("List is :  ");
            p = start;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.next;
            }
            Console.WriteLine();
        }

        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.next = start;
            start.prev = temp;
            start = temp;
        }

        public void InsertInEmptyList(int data)
        {
            Node temp = new Node(data);
            start = temp;
        }

        public void InsertAtEnd(int data)
        {
            Node temp = new Node(data);

            Node p = start;

            while (p.next != null)
                p = p.next;

            temp.prev = p;
            p.next = temp;
        }

        public void CreateList()
        {
            int i, n, data;
            Console.Write("Enter the number of nodes: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;

            Console.Write("Enter the first element to be inserted: ");
            data = Convert.ToInt32(Console.ReadLine());
            InsertInEmptyList(data);

            for (i = 2; i <= n; i++)
            {
                Console.Write("Enter the next element to be inserted: ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }

        public void InsertAfter(int data, int x)
        {
            Node temp = new Node(data);

            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                    break;
                p = p.next;
            }

            if (p == null)
                Console.WriteLine(x + " not present in the list");
            else
            {
                temp.prev = p;
                temp.next = p.next;
                if (p.next != null)
                    p.next.prev = temp;
                p.next = temp;
            }
        }

        public void InsertBefore(int data, int x)
        {
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if (start.info == x)
            {
                Node temp = new Node(data);
                temp.next = start;
                start.prev = temp;
                start = temp;
                return;
            }

            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                    break;
                p = p.next;
            }

            if (p == null)
                Console.WriteLine(x + " not present in the list");
            else
            {
                Node temp = new Node(data);
                temp.prev = p.prev;
                temp.next = p;
                p.prev.next = temp;
                p.prev = temp;
            }
        }

        public void DeleteFirstNode()
        {
            if (start == null)
                return;
            if (start.next == null)
            {
                start = null;
                return;
            }
            start = start.next;
            start.prev = null;
        }

        public void DeleteLastNode()
        {
            if (start == null) // If list is empty
                return;

            if (start.next == null) // If list has only one node
            {
                start = null;
                return;
            }

            Node p = start;
            while (p.next != null)
                p = p.next;
            p.prev.next = null;
        }

        public void DeleteNode(int x)
        {
            if (start == null) // If list is empty
                return;

            if (start.next == null) // If list has only one node
            {
                if (start.info == x)
                    start = null;
                else
                    Console.WriteLine(x + " not found");
                return;
            }

            // Deletion of first node
            if (start.info == x)
            {
                start = start.next;
                start.prev = null;
                return;
            }

            Node p = start.next;
            while (p.next != null)
            {
                if (p.info == x)
                    break;
                p = p.next;
            }

            if (p.next != null) // Node to be deleted is in between
            {
                p.prev.next = p.next;
                p.next.prev = p.prev;
            }
            else // p refers to last node
            {
                if (p.info == x)
                    p.prev.next = null;
                else
                    Console.WriteLine(x + " not found");
            }
        }

        public void ReverseList()
        {
            if (start == null)
                return;

            Node p1 = start;
            Node p2 = p1.next;
            p1.next = null;
            p1.prev = p2;
            while (p2 != null)
            {
                p2.prev = p2.next;
                p2.next = p1;
                p1 = p2;
                p2 = p2.prev;
            }
            start = p1;
        }
    }
}
