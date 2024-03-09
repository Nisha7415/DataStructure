using System;

namespace Ds_Queue
{
    public class Queue
    {
        public int front;
        public int rear;
        public int[] queue;
        public int Size;

        public Queue(int size) 
        {
            front = -1;
            rear = -1;
            queue = new int[size];
            Size = size; 
        }

        public void Enqueue(int data)
        {
            if (rear == Size - 1)
            {
                Console.WriteLine("Queue is full");
            }
            else if(rear==-1 && front == -1)
            {
                front = rear = 0;
                queue[rear] = data;
            }
            else
            {
                rear++;
                queue[rear] = data;
            }
        }
        public void Dqueue()
        {
            if (front==-1 && rear == -1)
            {
                Console.WriteLine("Queue is empty.");
            }
            else if(front==rear)
            {
                front = rear = -1; 
            }
            else
            {
                front++;
            }
        }
        public void peek()
        {
            if(front==-1 && rear == -1)
            {
                Console.WriteLine("Queue is empty.");
            }
            else
            {
                Console.WriteLine("First element in the queue is " + queue[front]);
            }
        }
        public void display()
        {
            if(front==-1 && rear == -1)
            {
                Console.WriteLine("Queue is empty.");
            }
            else
            {
                for(int i=front;i<rear+1;i++)
                {
                    Console.WriteLine(queue[i]);    
                }
            }
        }
        
        static void Main(string[] args)
        {
            Queue q = new Queue(5);
            q.Enqueue(1);
            q.Enqueue(2);   
            q.Enqueue(3);
            q.Enqueue(4);
            q.display();
        }
    }
}
