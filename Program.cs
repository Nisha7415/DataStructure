using System;

namespace ds_stack
{
    public class Stack 
    {

         public int top;
         public int[] stack;
         public int StackSize;
        public Stack(int size)
        {
            top = -1;
            stack=new int[size];
            StackSize = size;
        }

        public void push(int data)
        {
            if (top == StackSize-1)
            {
                Console.WriteLine("Stack is overflow.");
            }
            else
            {

                top++;
                stack[top] = data;
            }
        }

        public void pop() 

        {
            int item;
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
            }
            item = stack[top];
            top--;
            Console.WriteLine(item +"is removed from stack.");
        }
        public void peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty.");
            }
            Console.WriteLine("The top element is: " + stack[top]);
        }
        public void display()
        {
            for(int i=0;i<=top+1;i++)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
    
    public class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack(6);  
            s.push(23);
            s.push(2);
            s.push(6);
            s.push(5);
            s.push(20);

            s.pop();
            s.pop();
            s.display();

        }
    }
}
