using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_08_lesson_boxing_homework
{
    class Program
    {
        static void Main()
        {
            Queue queue = new Queue(2);
            queue.Dequeue();

            Person person = new Person();
        }
    }
    class Queue
    {
        public readonly string[] _queue;
        private int tail = 0;
        private int head = 0;

        public Queue(uint len)
        {
            _queue = new string[len];
        }

        /// <summary>
        /// This method will be used to add element to the end of the queue
        /// </summary>
        /// <param name="item">Element to add to the queue</param>
        public void Enqueue(string item)
        {
            _queue[tail++] = item;
            if (_queue.Length < tail)
            {
                throw new Exception("No queue place");
            }
        }
        public string Dequeue()
        {
           
            if (_queue.Length==0 ||tail==0)
                throw new Exception("Not person");
            else
                return _queue[head++];
            
        }
    }

    class Person
    {

    }

}
