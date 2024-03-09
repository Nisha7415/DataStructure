using System;

namespace DoublyLinkedList
{
    public class Program
  { 
        class Node
        {
             public int data;
             public Node next;
             public Node prev;

            public Node(int data)
            {
                this.data = data;

            }
        }
        Node head;
        public void add( int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                this.head= node;
            }
            else
            {
                Node temp= head;
                while(temp.next != null)
                {
                    temp=temp.next;
                }
                temp.next = node;
                node.prev = temp;
            }
            Console.WriteLine("{0} inserted into the doubly linked list.",node.data);
        }
        public void Display()
        {
            Node temp=this.head;
            if(temp==null)
            {
                Console.WriteLine("Doubly linked ist is empty.");
                return;
            }
            while(temp!=null)
            {
                Console.Write(temp.data + " ");
                temp=temp.next;
            }
        }
         
        static void Main(string[] args)
        {
            Program p=new Program();
            p.add(1);
            p.add(34);
            p.add(45);
            p.Display();






        }
    }
}
