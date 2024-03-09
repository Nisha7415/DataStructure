using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace singlyLinkesList
{
   
    public class Program
    {
          public class Node
        {
              public string  data;
               public Node next;

            public Node(string  data)
            {
                this.data = data;
                this.next = null;
            }
        }

        //----------ADD-FIRST--------------

        Node head;
        public void addFirst(String data) 
        {
          
            Node newnode= new Node(data);
            if (head== null)//list exist or not
            {
                head = newnode;
                return;
            }
            newnode.next = head;
            head = newnode;
        }

        //---------------ADD-LAST-------------
        public void addLast(String data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
                return;
            }
            Node currNode = head;
            while(currNode.next != null)
            {
                currNode = currNode.next;
            }
            currNode.next = newnode;
        }

        //-------------PRINT-LIST---------------
        public void printList()
        {
            if (head == null)
            {
                Console.WriteLine("list is empty.");
                return;
            }
            Node currNode = head;
            while (currNode != null)
            {
                Console.Write(currNode.data+ " -> ");
                currNode = currNode.next;
            }
            Console.WriteLine("NULL");
        }

        //---------------------DELETE-FIRST--------------

        public void deleteFirst()
        {
            if(head == null)
            {
                Console.WriteLine("This list is empty.");
                return;
            }
            head=head.next; 
        }

        //-------------------DELETE-LAST------------
        public void deleteLast()
        {
            if (head == null)
            {
                Console.WriteLine("This list is empty.");
                return;
            }
            if (head.next==null) 
            {
                head = null;
                return;
            }
            Node secondLast = head;
            Node lastNode = head.next;
            while (lastNode.next!=null)
            {
                lastNode = lastNode.next;
                secondLast=secondLast.next;
            }
            secondLast.next=null;
        }
        static void Main(string[] args)
        {
            Program p1= new Program(); 
            p1.addFirst("a");
            p1.addFirst("is");
            p1.printList();

            p1.addLast("list");
            p1.printList();

            p1.addFirst("this");
            p1.printList();

            p1.deleteFirst();
            p1.printList();

            p1.deleteLast();
            p1.printList();

        }
    }
}
