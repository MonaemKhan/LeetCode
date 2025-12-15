class TestClass
{
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
    static void Main(string[] args)
    {
        ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        ListNode list3 = new ListNode(2, new ListNode(6));

        List<ListNode> aa = new List<ListNode>();
        aa.Add(list1);
        aa.Add(list2);
        aa.Add(list3);

        ListNode dd = list1;
        while (dd != null)
        {
            Console.WriteLine(dd.val);
            dd = dd.next;
        }

        Console.WriteLine("---- After Reverse K Group ----");

        dd = ReverseKGroup(list1, 2);
        while (dd != null)
        {
            Console.WriteLine(dd.val);
            dd = dd.next;
        }
        Console.ReadKey();
    }

    public static ListNode ReverseKGroup(ListNode head, int k)
    {
        ListNode temp = head;
        List<int> numList = new List<int>();

        while (temp != null)
        {
            numList.Add(temp.val);
            temp = temp.next;
        }
        ListNode current = new ListNode();
        bool isFirst = true;

        int notChangedLength = numList.Count % k;

        for (int i = numList.Count - 1; i > numList.Count - 1 - notChangedLength; i--)
        {
            ListNode Tempcurrent = new ListNode();

            Tempcurrent.val = numList[i];
            if (isFirst)
            {
                Tempcurrent.next = null;
                isFirst = false;
            }
            else
            {
                Tempcurrent.next = current;
            }
            current = Tempcurrent;
        }

        int startLength = numList.Count - notChangedLength;
        int endLength = numList.Count - notChangedLength - k;
        while (endLength >= 0)
        {
            for (int i = endLength; i < startLength; i++)
            {
                ListNode Tempcurrent = new ListNode();

                Tempcurrent.val = numList[i];
                if (isFirst)
                {
                    Tempcurrent.next = null;
                    isFirst = false;
                }
                else
                {
                    Tempcurrent.next = current;
                }
                current = Tempcurrent;
            }
            startLength = startLength - k;
            endLength = endLength - k;
        }
        return isFirst ? null : current;
    }

    public static ListNode SwapPairs(ListNode head)
    {
        ListNode temp = head;
        List<int> numList = new List<int>();

        while (temp != null)
        {
            numList.Add(temp.val);
            temp = temp.next;
        }

        ListNode current = new ListNode();
        bool isFirst = true;
        int length = numList.Count;
        if (length % 2 != 0)
        {
            ListNode Tempcurrent = new ListNode();
            Tempcurrent.val = numList[numList.Count - 1];
            if (isFirst)
            {
                Tempcurrent.next = null;
                isFirst = false;
            }
            else
            {
                Tempcurrent.next = current;
            }
            current = Tempcurrent;
            length = length - 1;
        }
        for (int i = length - 1; i >= 0; i = i - 2)
        {
            ListNode Tempcurrent = new ListNode();

            // swap 2nd index to 1st index
            Tempcurrent.val = numList[i - 1];
            if (isFirst)
            {
                Tempcurrent.next = null;
                isFirst = false;
            }
            else
            {
                Tempcurrent.next = current;
            }
            current = Tempcurrent;

            // swap 1st index to 2nd index
            Tempcurrent = new ListNode();

            Tempcurrent.val = numList[i];
            if (isFirst)
            {
                Tempcurrent.next = null;
                isFirst = false;
            }
            else
            {
                Tempcurrent.next = current;
            }
            current = Tempcurrent;
        }
        return isFirst ? null : current;
    }

    public static ListNode MergeKLists(ListNode[] lists)
    {
        List<int> numList = new List<int>();
        foreach (var item in lists)
        {
            ListNode temp = item;
            while (temp != null)
            {
                if (temp.next != null)
                {
                    numList.Add(temp.val);
                    temp = temp.next;
                }
                else
                {
                    numList.Add(temp.val);
                    temp = null;
                }
            }
        }

        var arr = numList.ToArray().Order().ToList();
        ListNode current = new ListNode();
        bool isFirst = true;

        for (int i = numList.Count - 1; i >= 0; i--)
        {
            ListNode Tempcurrent = new ListNode();

            Tempcurrent.val = arr[i];
            if (isFirst)
            {
                Tempcurrent.next = null;
                isFirst = false;
            }
            else
            {
                Tempcurrent.next = current;
            }
            current = Tempcurrent;
        }

        return isFirst ? null : current;
    }

    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        List<int> numList = new List<int>();
        ListNode temp1 = list1;
        ListNode temp2 = list2;
        while (temp1 != null || temp2 != null)
        {
            if (temp1 != null)
            {
                if (temp1.next != null)
                {
                    numList.Add(temp1.val);
                    temp1 = temp1.next;
                }
                else
                {
                    numList.Add(temp1.val);
                    temp1 = null;
                }
            }
            if (temp2 != null)
            {
                if (temp2.next != null)
                {
                    numList.Add(temp2.val);
                    temp2 = temp2.next;
                }
                else
                {
                    numList.Add(temp2.val);
                    temp2 = null;
                }
            }
        }
        var arr = numList.ToArray().Order().ToList();
        ListNode current = new ListNode();
        bool isFirst = true;
        for (int i = numList.Count - 1; i >= 0; i--)
        {
            ListNode Tempcurrent = new ListNode();

            Tempcurrent.val = arr[i];
            if (isFirst)
            {
                Tempcurrent.next = null;
                isFirst = false;
            }
            else
            {
                Tempcurrent.next = current;
            }
            current = Tempcurrent;

        }


        return isFirst ? null : current;
    }

    public static ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode temp = head;
        List<int> numList = new List<int>();

        while (temp != null)
        {
            numList.Add(temp.val);
            temp = temp.next;
        }

        int Indexcount = 0;
        ListNode current = new ListNode();
        bool isFirst = true;
        for (int i = numList.Count - 1; i >= 0; i--)
        {
            ListNode Tempcurrent = new ListNode();
            Indexcount = Indexcount + 1;
            if (Indexcount != n)
            {
                Tempcurrent.val = numList[i];
                if (isFirst)
                {
                    Tempcurrent.next = null;
                    isFirst = false;
                }
                else
                {
                    Tempcurrent.next = current;
                }
                current = Tempcurrent;
            }
        }


        return isFirst ? null : current;
    }
}