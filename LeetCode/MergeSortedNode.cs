using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class MergeSortedNode
    {
    }


//* Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public static void Main(string[]  agrs)
        {
            ListNode l1 = new ListNode(1);
            ListNode i2 = new ListNode(2);
            ListNode i3 = new ListNode(4);
            i2.next = i3;
            l1.next = i2;
            ListNode l2 = new ListNode(1);
            ListNode i4 = new ListNode(3);
            ListNode i5 = new ListNode(4);
            i4.next = i5;
            l2.next = i4;

            l1 = MergeTwoLists(l1, l2);

        }
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode mergednode = null;
            
            ListNode headnode ;
            ListNode returnnode;
            int flag = 0;
            while (l1 != null || l2 != null)
            {
                if(l1 == null)
                {
                    mergednode = l2;
                    l2 = l2.next;
                }
                else if(l2 == null)
                {
                    mergednode = l1;
                    l1 = l1.next;
                }
                else if (l1.val >= l2.val)
                {
                    mergednode = l2;
                    l2 = l2.next;
                }
                else if (l1.val < l2.val)
                {
                    mergednode = l1;
                    l1 = l1.next;
                }

                if (flag == 0)
                {
                    
                    returnnode = mergednode;
                    headnode = returnnode;
                    flag++;
                }
                else if (flag == 1)
                {
                    headnode.next = mergednode;
                    flag++;
                    
                }
                returnnode.next = mergednode;
                returnnode = returnnode.next;

            }
            return headnode;
        }
    }
}
