using System;
using System.Collections.Generic;
using System.Text;

namespace CircularLinkedListProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, data, k, x;

            CircularLinkedList list = new CircularLinkedList();
            //list.CreateList();

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
                        break;
                    case 2: // Insert node to empty list
                        break;
                    case 3: // Insert node at beginning of list
                        break;
                    case 4: // Insert node at end of list
                        break;
                    case 5: // Insert a node after specifed node
                        break;
                    case 6: // Insert a node before specified node
                        break;
                    case 7: // Delete first node
                        break;
                    case 8: // Delete last node
                        break;
                    case 9: // Delete node with specified data
                        break;
                    case 10: // Reverse the list
                        break;
                    case 11: // 
                        break;
                }
            }
        }
    }
}
