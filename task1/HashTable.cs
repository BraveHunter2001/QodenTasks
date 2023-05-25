using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class HashTable
    {
        public ListNode[] values;
        int count = 0;

        public HashTable(int countElements)
        {
            count = countElements;
            values = new ListNode[countElements];
        }

        public void Insert(int newValue)
        {
            int index = newValue % count;

            if (values[index] == null)
                values[index] = new ListNode();

            values[index].Insert(newValue);
        }

    }
}
