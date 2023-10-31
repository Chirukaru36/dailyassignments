using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._9
{
    public class Stack
    {

        private Node top;

        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.Next = top;
                top = newNode;
            }
        }

        public int Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            int data = top.Data;
            top = top.Next;
            return data;
        }

        public int Peek()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return top.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }


}

