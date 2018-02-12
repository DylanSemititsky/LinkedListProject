using System;
using System.Collections.Generic;
using System.Text;

namespace SortedLinkedListProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, data, k, x;

            SortedLinkedList list = new SortedLinkedList();
            list.CreateList();

            while (true)
            {
                Console.WriteLine("1. Display list");
                Console.WriteLine("2. Insert a new node");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Quit");
                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 4)
                    break;

                switch(choice)
                {
                    case 1: // Display list
                        list.DisplayList();
                        break;
                    case 2: // Insert new node in order
                        Console.WriteLine("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInOrder(data);
                        break;
                    case 3: // Search for a node
                        Console.WriteLine("Enter the element to be searched: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.Search(data);
                        break;
                    default: //
                        Console.WriteLine("Wrong choice");
                        break;
                }
            }
        }
    }
}
