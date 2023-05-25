using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class ListNode
    {
        public int value;
        public ListNode next;
        ListNode head;

        public void Insert(int newValue)
        {
            if (head == null)
            {
                value = newValue;
                head = this;
                return;
            }

            ListNode temp = this;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = new ListNode();
            temp.next.value = newValue;
            temp.next.head = temp.head;
        }


    }
}
