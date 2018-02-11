using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedListProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, data, k, x;

            DoubleLinkedList list = new DoubleLinkedList();
            list.CreateList();

            while (true)
            {
                Console.WriteLine("1. Display List ");
                Console.WriteLine("2. Insert in empty list");
                Console.WriteLine("3. Insert a node in beginning of the list");
                Console.WriteLine("4. Insert a node at the end of the list");
                Console.WriteLine("5. Insert a node after a specified node");
                Console.WriteLine("6. Insert a node before a specified node");
                Console.WriteLine("7. Delete first node");
                Console.WriteLine("8. Delete last node");
                Console.WriteLine("9. Delete a specified node");
                Console.WriteLine("10. Reverse the list");
                Console.WriteLine("11. Exit program");

                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 11)
                    break;

                switch(choice)
                {
                    case 1: // Display current list
                        list.DisplayList();
                        break;
                    case 2: // Insert node to empty list
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInEmptyList(data);
                        break;
                    case 3: // Insert node at beginning of list
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInBeginning(data);
                        break;
                    case 4: // Insert node at end of list
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;
                    case 5: // Insert a node after specifed node
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element before which to insert: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(data, x);
                        break;
                    case 6: // Insert a node before specified node
                        Console.Write("Enter the element to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the element after which to insert: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, x);
                        break;
                    case 7: // Delete first node
                        list.DeleteFirstNode();
                        break;
                    case 8: // Delete last node
                        list.DeleteLastNode();
                        break;
                    case 9: // Delete node with specified data
                        Console.Write("Enter the element to be deleted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;
                    case 10: // Reverse the list
                        list.ReverseList();
                        break;
                    case 11: // 
                        break;
                }
            }
        }
    }
}
