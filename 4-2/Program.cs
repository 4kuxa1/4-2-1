﻿using System.Collections;
using System;
class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue();

        queue.Enqueue("First"); 
        queue.Enqueue("Second"); 
        queue.Enqueue("Third"); 
        queue.Enqueue("Fourth");
    while (queue.Count > 0)
        {
            object obj = queue.Dequeue();
            Console.WriteLine("From Queue: {0}", obj);
        }
    }
}
