using System;
using System.Collections.Generic;
using System.Text;

namespace SortedLinkedListProject
{
    class SortedLinkedList
    {
        private Node start;

        public SortedLinkedList()
        {
            start = null;
        }

        public void CreateList()
        {
            int i, n, data;

            Console.Write("Enter the number of nodes: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;

            for (i = 1; i <= n; i++)
            {
                Console.Write("Enter the element to be inserted: ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertInOrder(data);
            }
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
                p = p.link;
            }
            Console.WriteLine();
        }

        public void InsertInOrder(int data)
        {
            Node temp = new Node(data);

            // If list is empty
            if (start == null || data < start.info)
            {
                temp.link = start;
                start = temp;
                return;
            }

            Node p = start;
            while (p.link != null && p.link.info <= data)
                p = p.link;

            temp.link = p.link;
            p.link = temp;
        }

        public void Search(int x)
        {
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            int position = 1;
            Node p = start;
            while (p != null && p.info <= x)
            {
                if (p.info == x)
                    break;
                position++;
                p = p.link;
            }
            if (p == null || p.info != x)
                Console.WriteLine(x + " not found in list");
            else
                Console.WriteLine(x + " is at postion " + position);
        }
    }
}
