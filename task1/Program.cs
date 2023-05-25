using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            HashTable hashTable = new HashTable(N);

            string str = Console.ReadLine();
            string[] tokens = Split(str, ' ');


            for (int i = 0; i < N; i++)
            {
                int num = int.Parse(tokens[i]);
                hashTable.Insert(num);
            }

            PrintHashTable(hashTable);

            
        }

        static string[] Split(string str, char sep)
        {
            List<string> strings = new List<string>();

            
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != sep)
                {
                    sb.Append(str[i].ToString());
                }

                if (str[i] == sep || i == str.Length - 1)
                {
                    strings.Add(sb.ToString());
                    sb.Clear();  
                }
               
            }

            return strings.ToArray();
        }

        static void PrintListNode(ListNode node)
        {
            ListNode temp = node;
            while (temp != null)
            {
                Console.Write(temp.value);

                if (temp.next != null)
                    Console.Write(' ');

                temp = temp.next;
            }
        }

        static void PrintHashTable(HashTable ht)
        {
            for (int i = 0; i < ht.values.Length; i++)
            {
                ListNode nodes = ht.values[i];
                Console.Write($"{i}: ");
                if (nodes != null)
                    PrintListNode(nodes);
                Console.WriteLine();
            }

        }
    }
}
