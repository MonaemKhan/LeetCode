using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class addTwoNumber
    {
        public static void Main2(string[] args)
        {
            ListNode l1 = new ListNode(9);
            l1 = new ListNode(9, l1);
            l1 = new ListNode(9, l1);

            ListNode l2 = new ListNode(9);
            l2 = new ListNode(9, l2);
            //l2 = new ListNode(5, l2);

            var a = AddTwoNumbers(l1, l2);

            while (a != null)
            {
                Console.WriteLine(a.val);
                a = a.next;
            }

            Console.ReadKey();
        }
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int sum = 0;
            int carry = 0;
            string result = "";
            while (l1 != null || l2 != null)
            {
                if (l1 != null)
                {
                    sum = sum + l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum = sum + l2.val;
                    l2 = l2.next;
                }

                sum = sum + carry;

                if (sum >= 10)
                {
                    carry = sum / 10;
                    sum = sum % 10;
                }
                else
                {
                    carry = 0;
                }
                if (l1 == null && l2 == null)
                {
                    if (string.IsNullOrEmpty(result))
                    {
                        result = result + sum;
                        if (carry != 0)
                        {
                            result = result + "," + carry;
                        }
                    }
                    else
                    {
                        result = result + "," + sum;
                        if (carry != 0)
                        {
                            result = result + "," + carry;
                        }
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(result))
                    {
                        result = result + (sum);
                    }
                    else
                    {
                        result = result + "," + (sum);
                    }

                }
                sum = 0;
            }

            string[] split = result.Split(',');
            int length = split.Length - 1;
            ListNode listNode = new ListNode(Convert.ToInt32(split[length]));
            for (int i = length - 1; i >= 0; i--)
            {
                listNode = new ListNode(Convert.ToInt32(split[i]), listNode);
            }

            return listNode;
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
