using System;
using System.Collections.Generic;
using System.Text;

namespace SingleLinkedListProject
{
    class SingleLinkedList
    {
        private Node start;

        public SingleLinkedList()
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
                p = p.link;
            }
            Console.WriteLine();
        }

        public void CountNodes()
        {
            int n = 0;
            Node p = start;
            while (p != null)
            {
                n++;
                p = p.link;
            }
            Console.WriteLine("Number of nodes in the list = " + n);
        }

        public bool Search(int x)
        {
            int position = 1;
            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                    break;
                position++;
                p = p.link;
            }
            if (p == null)
            {
                Console.WriteLine(x + " not found in list");
                return false;
            }
            else
            {
                Console.WriteLine(x + " is at postion " + position);
                return true; 
            }
        }

        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;
        }

        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new Node(data);

            if (start == null)
            {
                start = temp;
                return;
            }

            p = start;
            while (p.link != null)
                p = p.link;

            p.link = temp;
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
                InsertAtEnd(data);
            }
        }

        public void InsertAfter(int data, int x)
        {
            Node p = start;
            while (p != null)                   //Find node to insert after
            {
                if (p.info == x)
                    break;
                p = p.link;
            }

            if (p == null)
                Console.WriteLine(x + " not present in list");
            else
            {
                Node temp = new Node(data);     //Make a new node
                temp.link = p.link;             //Made new nodes link equal to p.link
                p.link = temp;                  //Made p.link equal to new node
            }
        }

        public void InsertBefore(int data, int x)
        {
            Node temp;

            if (start == null)                  //If the list is empty, return
            {
                Console.WriteLine("List is empty");
                return;
            }

            if (x == start.info)                //If x is the first node
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            //Find reference to predecessor of node containing x
            Node p = start;
            while (p.link != null)              
            {
                if (p.link.info == x)           //When p.link is equal to x, p will be there predecessor of x
                    break;
                p = p.link;
            }

            if (p.link == null)
                Console.WriteLine(x + " not present in the list");
            else
            {
                temp = new Node(data);          //Make a new node
                temp.link = p.link;             //Make new nodes link equal to found node's link
                p.link = temp;
            }
        }

        public void InsertAtPosition(int data, int k)   // k = position
        {
            Node temp;
            int i;

            if (k == 1)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            Node p = start;
            for (i = 1; i < k - 1 && p != null; i++)    //Loops until the node before "k"
                p = p.link;

            if (p == null)
                Console.WriteLine("You can insert only up to " + i + "th postion");
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void DeleteFirstNode()
        {
            if (start == null)
                return;
            start = start.link;
        }

        public void DeleteLastNode()
        {
            if (start == null)
                return;

            if (start.link == null) //If there is only one node after start, delete it
            {
                start = null;
                return;
            }

            Node p = start;
            while (p.link.link != null)
                p = p.link;
            p.link = null;
        }

        public void DeleteNode(int x)
        {
            if (start == null)
            {
                Console.WriteLine("List is empty\n");
                return;
            }

            if (start.info == x)
            {
                start = start.link;
                return;
            }

            Node p = start;
            while (p.link != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }

            if (p.link == null)
                Console.WriteLine("Element " + x + " not in list");
            else
                p.link = p.link.link;
        }

        public void ReverseList()
        {
            Node prev, p, next;
            prev = null;
            p = start;

            while (p != null)
            {
                next = p.link;
                p.link = prev;
                prev = p;
                p = next;
            }
            start = prev;
        }

        public void BubbleSortExData()
        {
            Node end, p, q;

            for (end = null; end != start.link; end = p)
            {
                for (p = start; p.link != end; p = p.link)
                {
                    q = p.link;
                    if (p.info > q.info)
                    {
                        int temp = p.info;
                        p.info = q.info;
                        q.info = temp;
                    }
                }
            }
        }

        public void BubbleSortExLinks()
        {
            Node end, r, p, q, temp;

            for (end = null; end != start.link; end = p)
            {
                for (r = p = start; p.link != end; r = p, p = p.link)
                {
                    q = p.link;
                    if (p.info > q.info)
                    {
                        p.link = q.link;
                        q.link = p;
                        if (p != start)
                            r.link = q;
                        else
                            start = q;
                        temp = p;
                        p = q;
                        q = temp;
                    }
                }
            }
        }

        // Merge a current list with a new list by copying
        // nodes from one list and inserting them into the other
        public SingleLinkedList Merge1(SingleLinkedList list)
        {
            SingleLinkedList mergeList = new SingleLinkedList();
            mergeList.start = Merge1(start, list.start);
            return mergeList;
        }

        private Node Merge1(Node p1, Node p2)
        {
            Node startM;

            if (p1.info <= p2.info)
            {
                startM = new Node(p1.info);
                p1 = p1.link;
            }
            else
            {
                startM = new Node(p2.info);
                p2 = p2.link;
            }

            Node pM = startM;

            // Loops until one of the lists has finished
            while (p1 != null && p2 != null)
            {
                if (p1.info <= p2.info)
                {
                    pM.link = new Node(p1.info);
                    p1 = p1.link;
                }
                else
                {
                    pM.link = new Node(p2.info);
                    p2 = p2.link;
                }

                pM = pM.link;
            }

            // If second list has finished and elements are left in first list
            while (p1 != null)
            {
                pM.link = new Node(p1.info);
                p1 = p1.link;
                pM = pM.link;
            }

            // If first list has finished and elements are left in second list
            while (p2 != null)
            {
                pM.link = new Node(p2.info);
                p2 = p2.link;
                pM = pM.link;
            }

            return startM;
        }

        // Merge two sorted lists by changing the links so that they
        // point to the correct nodes (does not create new nodes)
        public SingleLinkedList Merge2(SingleLinkedList list)
        {
            SingleLinkedList mergeList = new SingleLinkedList();
            mergeList.start = Merge2(start, list.start);
            return mergeList;
        }

        private Node Merge2(Node p1, Node p2)
        {
            Node startM;

            if (p1.info <= p2.info)
            {
                startM = p1;
                p1 = p1.link;
            }
            else
            {
                startM = p2;
                p2 = p2.link;
            }

            Node pM = startM;

            while (p1 != null && p2 != null)
            {
                if (p1.info <= p2.info)
                {
                    pM.link = p1;
                    pM = pM.link;
                    p1 = p1.link;
                }
                else
                {
                    pM.link = p2;
                    pM = pM.link;
                    p2 = p2.link;
                }
            }

            if (p2 == null)
                pM.link = p1;
            else
                pM.link = p2;

            return startM;
        }

        // Sort a list by dividing it in two and then 
        // merging the lists using the above methods (Merge())
        public void MergeSort() 
        {
            start = MergeSortRec(start);
        }

        private Node MergeSortRec(Node listStart)
        {
            if (listStart == null || listStart.link == null)    // If list has only one element
                return listStart;

            // If list has more than one element
            Node start1 = listStart;
            Node start2 = DivideList(listStart);
            start1 = MergeSortRec(start1);
            start2 = MergeSortRec(start2);
            Node startM = Merge2(start1, start2);

            return startM;
        }

        private Node DivideList(Node p)
        {
            Node q = p.link.link;
            while (q != null && q.link != null)
            {
                p = p.link;
                q = q.link.link;
            }
            Node start2 = p.link;
            p.link = null;

            return start2;
        }

        public bool HasCycle()
        {
            if (FindCycle() == null)
                return false;
            else
                Console.WriteLine("List has a cycle");
                return true;  
        }

        private Node FindCycle()
        {
            if (start == null || start.link == null)
                return null;

            Node slowR = start, fastR = start;

            while (fastR != null && fastR.link != null)
            {
                slowR = slowR.link;
                fastR = fastR.link.link;
                if (slowR == fastR)
                    return slowR;
            }
            return null;
        }

        public void RemoveCycle()
        {
            Node c = FindCycle();
            if (c == null)
                return;
            Console.WriteLine("Node at which the cycle was detected is " + c.info);

            Node p = c, q = c;
            int lenCycle = 0;
            do
            {
                lenCycle++;
                q = q.link;
            } while (p != q);
            Console.WriteLine("Length of cycle is: " + lenCycle);

            int lenRemList = 0;
            p = start;
            while (p != q)
            {
                lenRemList++;
                p = p.link;
                q = q.link;
            }

            Console.WriteLine("Number of nodes not included in the cycle are: " + lenRemList);

            int lengthList = lenCycle + lenRemList;
            Console.WriteLine("Length of the list is: " + lengthList);

            p = start;
            for (int i = 1; i <= lengthList - 1; i++)
                p = p.link;
            p.link = null;
        }

        public void InsertCycle(int x)
        {
            if (start == null)
                return;

            Node p = start, px = null, prev = null;

            while (p != null)
            {
                if (p.info == x)
                    px = p;
                prev = p;
                p = p.link;
            }

            if (px != null)
                prev.link = px;
            else
                Console.WriteLine(x + " not present in list");
        }

        public void Concatenate(SingleLinkedList list)
        {
            if (start == null)
            {
                start = list.start;
                return;
            }

            if (list.start == null)
                return;

            Node p = start;
            while (p.link != null)
                p = p.link;

            p.link = list.start;
        }
    }
}
