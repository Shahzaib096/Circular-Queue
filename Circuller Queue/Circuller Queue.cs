using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuller_Queue
{
    class Circuller_Queue
    {
        private int front, rear, countItem;
        private int[] myArray = new int[10];
        public Circuller_Queue()
        {
            front = -1;
            rear = -1;
            countItem = 0;
            for (int row = 0; row < 10; row++)
            {
                myArray[row] = 0;
            }
        }
        public bool IsEmpty()
        {
            if (rear == -1 && front == -1)
                return true;
            else
                return false;
        }
        public bool IsFull()
        {
            if ((rear + 1) % 10 == front)
                return true;
            else
                return false;
        }
        public void EnQueue(int Value)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue Is Full !");
            }
            else if (IsEmpty())
            {
                rear = 0;
                front = 0;
                myArray[rear] = Value;
            }
            else
            {
                rear = (rear + 1) % 10;
                myArray[rear] = Value;
            }
            countItem++;
        }
        public int DeQueue()
        {
            int DeQueuedValue;
            if (IsEmpty())
            {
                Console.WriteLine("Queue Is Empty !");
                return 0;
            }
            else if (front == rear)
            {
                DeQueuedValue = myArray[front];
                front = -1;
                rear = -1;
                countItem--;
                return DeQueuedValue;
            }
            else
            {
                DeQueuedValue = myArray[front];
                myArray[front] = 0;
                front = (front + 1) % 10;
                countItem--;
                return DeQueuedValue;
            }
        }
        public void Display()
        {
            for (int row = 0; row < 10; row++)
            {
                Console.Write(" " + myArray[row]);
            }
            Console.WriteLine();
        }
        public int Count()
        {
            
            return countItem;
            
        }
    }
}
