using System;

namespace CircularLinkedListProject
{
    class Node
    {
        public int info;
        public Node prev;
        public Node next;

        public Node(int i)
        {
            info = i;
            prev = null;
            next = null;
        }
    }
}
