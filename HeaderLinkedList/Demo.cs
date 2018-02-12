using System;
using System.Collections.Generic;
using System.Text;

namespace HeaderLinkedListProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, data, k, x;

            HeaderLinkedList list = new HeaderLinkedList();
            list.CreateList();

            while (true)
            {
                Console.WriteLine("1. Display list");
                Console.WriteLine("2. Inset a node at the end of the list");
                Console.WriteLine("3. Insert a node before a specified node");
                Console.WriteLine("4. Insert a node at a given position");
                Console.WriteLine("5. Delete any node");
                Console.WriteLine("6. Reverse the list");
                Console.WriteLine("7. Quit");

                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 7)
                    break;

                switch(choice)
                {
                    case 1: // Display List
                        list.DisplayList();
                        break;
                    case 2: // Insert at end
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;
                    case 3: // Insert before a node
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element before which to insert: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, x);
                        break;
                    case 4: // Insert a specified node
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element before which to insert: ");
                        k = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtPosition(data, k);
                        break;
                    case 5: // Delete node
                        Console.Write("Enter the element to be deleted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;
                    case 6: // Reverse list
                        list.Reverse();
                        break;
                    default: // wrong choice
                        Console.Write("Wrong choice");
                        break;
                }
            }
        }
    }
}
