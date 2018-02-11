using System;
using System.Collections.Generic;
using System.Text;

namespace SingleLinkedListProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, data, k, x;

            SingleLinkedList list = new SingleLinkedList();
            list.CreateList();

            while (true)
            {
                Console.WriteLine("1. Display list");
                Console.WriteLine("2. Count the number of nodes");
                Console.WriteLine("3. Search for an element");
                Console.WriteLine("4. Insert in empty list / Insert in beginning of the list");
                Console.WriteLine("5. Inset a node at the end of the list");
                Console.WriteLine("6. Insert a node after a specified node");
                Console.WriteLine("7. Insert a node before a specified node");
                Console.WriteLine("8. Insert a node at a given position");
                Console.WriteLine("9. Delete first node");
                Console.WriteLine("10. Delete last node");
                Console.WriteLine("11. Delete any node");
                Console.WriteLine("12. Reverse the list");
                Console.WriteLine("13. Bubble sort by exchanging data");
                Console.WriteLine("14. Bubble sort by exchanging links");
                Console.WriteLine("15. Merge a new list with the current list");
                Console.WriteLine("16. Sort the list using Merge Sort");
                Console.WriteLine("17. Insert a cycle");
                Console.WriteLine("18. Detect a cycle");
                Console.WriteLine("19. Remove a cycle");

                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                    break;

                switch(choice)
                {
                    case 1: // Display List
                        list.DisplayList();
                        break;
                    case 2: // Count Nodes
                        list.CountNodes();
                        break;
                    case 3: // Search by data
                        Console.Write("Enter the element to be searched: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.Search(data);
                        break;
                    case 4: // Insert new node at beginning
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInBeginning(data);
                        break;
                    case 5: // Insert new node at end
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;
                    case 6: // Insert new node after a specific node
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element after which to insert: ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(data, choice);
                        break;
                    case 7: // Insert new node before a speecific node
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element before which to insert: ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, choice);
                        break;
                    case 8: // Insert a new node at a specific node position
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element at which to insert: ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtPosition(data, choice);
                        break;
                    case 9: // Delete first node
                        list.DeleteFirstNode();
                        break;
                    case 10: // Delete last node
                        list.DeleteLastNode();
                        break;
                    case 11: // Delete a node by its data/name
                        Console.Write("Enter the element(data) to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;
                    case 12: // Reverse List
                        list.ReverseList();
                        break;
                    case 13: // Bubble sort by exchanging data
                        list.BubbleSortExData();
                        break;
                    case 14: // Bubble sort by exchanging links
                        list.BubbleSortExLinks();
                        break;
                    case 15: // Merge a new list with the current list
                        Demo demo = new Demo();
                        demo.MergeListTest(list);
                        break;
                    case 16: // Sort the list using Merge Sort
                        list.MergeSort();
                        break;
                    case 17: // Create a Cycle
                        Console.Write("Enter element to start cycle at: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertCycle(x);
                        break;
                    case 18: // Detect a Cycle
                        list.HasCycle();
                        break;
                    case 19: // Remove a Cycle
                        list.RemoveCycle();
                        break;
                }
            }
        }

        public void MergeListTest(SingleLinkedList list)
        {
            //SingleLinkedList list1 = new SingleLinkedList();
            SingleLinkedList list2 = new SingleLinkedList();

            //list1.CreateList();
            list2.CreateList();

            list.BubbleSortExData();
            //list1.BubbleSortExData();
            list2.BubbleSortExData();

            Console.WriteLine("First List - "); list.DisplayList();
            Console.WriteLine("Second List - "); list2.DisplayList();

            SingleLinkedList list3;

            list3 = list.Merge1(list2);
            Console.WriteLine("MergedListByData - "); list3.DisplayList();

            Console.WriteLine("First List - "); list.DisplayList();
            Console.WriteLine("Second List - "); list2.DisplayList();

            list3 = list.Merge2(list2);
            Console.WriteLine("MergedListByLinks - "); list3.DisplayList();
        }
    }
}
