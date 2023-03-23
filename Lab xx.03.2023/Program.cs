
using System.Collections;

while (true)
{
    Console.Write("1. Dictionary" + '\n' +
    "2. SortedDictionary" + '\n' +
    "3. Queue" + '\n' +
    "4. Stack " + '\n' +
    "5. SortedList" + '\n' +
    "6. BitArray" + '\n' +
    "7. LinkedList" + '\n' +
    "8. SorterdSet");
    string command = Console.ReadLine();
    if (command == "1")
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        string[] array = new string[10];
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.  Add" + '\n' +
                "2.  Clear" + '\n' +
                "3.  CopyTo" + '\n' +
                "4.  ContainsValue" + '\n' +
                "5.  ContainsKey" + '\n' +
                "6.  GetHashCode" + '\n' +
                "7.  Remove" + '\n' +
                "8.  GetType" + '\n' +
                "9.  ToString" + '\n' +
                "10. Equals");
            command = Console.ReadLine();
            Console.Clear();
            if (command == "1")
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                dict.Add(key, value);
            }
            else if (command == "2")
            {
                dict.Clear();
            }
            else if (command == "3")
            {
                dict.Values.CopyTo(array, 10);
            }
            else if (command == "4")
            {
                string value = Console.ReadLine();
                Console.WriteLine(dict.ContainsValue(value));
                Console.ReadLine();
            }
            else if (command == "5")
            {
                string key = Console.ReadLine();
                Console.WriteLine(dict.ContainsKey(key));
                Console.ReadLine();
            }
            else if (command == "6")
            {
                Console.WriteLine(dict.GetHashCode());
                Console.ReadLine();
            }
            else if (command == "7")
            {
                string key = Console.ReadLine();
                dict.Remove(key);
            }
            else if (command == "8")
            {
                Console.WriteLine(dict.GetType());
                Console.ReadLine();
            }
            else if (command == "9")
            {
                Console.WriteLine(dict.ToString());
                Console.ReadLine();
            }
            else if (command == "10")
            {
                Console.WriteLine(dict.Equals(dict));
                Console.ReadLine();
            }
            else
            {
                break;
            }
        }
    }
    else if (command == "2")
    {
        SortedDictionary<string, string> sdict = new SortedDictionary<string, string>();
        string[] array = new string[10];
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.  Add" + '\n' +
                "2.  Clear" + '\n' +
                "3.  CopyTo" + '\n' +
                "4.  ContainsValue" + '\n' +
                "5.  ContainsKey" + '\n' +
                "6.  GetHashCode" + '\n' +
                "7.  Remove" + '\n' +
                "8.  GetType" + '\n' +
                "9.  ToString" + '\n' +
                "10. Equals");
            command = Console.ReadLine();
            Console.Clear();
            if (command == "1")
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                sdict.Add(key, value);
            }
            else if (command == "2")
            {
                sdict.Clear();
            }
            else if (command == "3")
            {
                sdict.Values.CopyTo(array, 10);
            }
            else if (command == "4")
            {
                string value = Console.ReadLine();
                Console.WriteLine(sdict.ContainsValue(value));
                Console.ReadLine();
            }
            else if (command == "5")
            {
                string key = Console.ReadLine();
                Console.WriteLine(sdict.ContainsKey(key));
                Console.ReadLine();
            }
            else if (command == "6")
            {
                Console.WriteLine(sdict.GetHashCode());
                Console.ReadLine();
            }
            else if (command == "7")
            {
                string key = Console.ReadLine();
                sdict.Remove(key);
            }
            else if (command == "8")
            {
                Console.WriteLine(sdict.GetType());
                Console.ReadLine();
            }
            else if (command == "9")
            {
                Console.WriteLine(sdict.ToString());
                Console.ReadLine();
            }
            else if (command == "10")
            {
                Console.WriteLine(sdict.Equals(sdict));
                Console.ReadLine();
            }
            else
            {
                break;
            }
        }
    }
    else if (command == "3")
    {
        Queue<string> que = new Queue<string>();
        string[] array = new string[10];
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.  Enqueue" + '\n' +
                "2.  Clear" + '\n' +
                "3.  CopyTo" + '\n' +
                "4.  Contains" + '\n' +
                "5.  Peek" + '\n' +
                "6.  GetHashCode" + '\n' +
                "7.  Dequeue" + '\n' +
                "8.  GetType" + '\n' +
                "9.  ToString" + '\n' +
                "10. Equals");
            command = Console.ReadLine();
            Console.Clear();
            if (command == "1")
            {
                string value = Console.ReadLine();
                que.Enqueue(value);
            }
            else if (command == "2")
            {
                que.Clear();
            }
            else if (command == "3")
            {
                que.CopyTo(array, 10);
            }
            else if (command == "4")
            {
                string value = Console.ReadLine();
                Console.WriteLine(que.Contains(value));
                Console.ReadLine();
            }
            else if (command == "5")
            {
                Console.WriteLine(que.Peek());
                Console.ReadLine();
            }
            else if (command == "6")
            {
                Console.WriteLine(que.GetHashCode());
                Console.ReadLine();
            }
            else if (command == "7")
            {
                que.Dequeue();
            }
            else if (command == "8")
            {
                Console.WriteLine(que.GetType());
                Console.ReadLine();
            }
            else if (command == "9")
            {
                Console.WriteLine(que.ToString());
                Console.ReadLine();
            }
            else if (command == "10")
            {
                Console.WriteLine(que.Equals(que));
                Console.ReadLine();
            }
            else
            {
                break;
            }
        }
    }
    else if (command == "4")
    {
        Stack<string> st = new Stack<string>();
        string[] array = new string[10];
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.  Push" + '\n' +
                "2.  Clear" + '\n' +
                "3.  CopyTo" + '\n' +
                "4.  Contains" + '\n' +
                "5.  Peek" + '\n' +
                "6.  GetHashCode" + '\n' +
                "7.  Pop" + '\n' +
                "8.  GetType" + '\n' +
                "9.  ToString" + '\n' +
                "10. Equals" + '\n' +
                "11. Задача со скобками (){}[]");
            command = Console.ReadLine();
            Console.Clear();
            if (command == "1")
            {
                string value = Console.ReadLine();
                st.Push(value);
            }
            else if (command == "2")
            {
                st.Clear();
            }
            else if (command == "3")
            {
                st.CopyTo(array, 10);
            }
            else if (command == "4")
            {
                string value = Console.ReadLine();
                Console.WriteLine(st.Contains(value));
                Console.ReadLine();
            }
            else if (command == "5")
            {
                Console.WriteLine(st.Peek());
                Console.ReadLine();
            }
            else if (command == "6")
            {
                Console.WriteLine(st.GetHashCode());
                Console.ReadLine();
            }
            else if (command == "7")
            {
                st.Pop();
            }
            else if (command == "8")
            {
                Console.WriteLine(st.GetType());
                Console.ReadLine();
            }
            else if (command == "9")
            {
                Console.WriteLine(st.ToString());
                Console.ReadLine();
            }
            else if (command == "10")
            {
                Console.WriteLine(st.Equals(st));
                Console.ReadLine();
            }
            else if (command == "11")
            {
// ПОКАЗАЛ НА ПАРЕ // НЕ СОХРАНИЛ // ХРАНИТСЯ В 1 КОМПЬЮТЕРЕ 8-204 //
            }
            else
            {
                break;
            }
        }
    }
    else if (command == "5")
    {
        SortedList<string, string> slist = new SortedList<string, string>();
        string[] array = new string[10];
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.  Add" + '\n' +
                "2.  Clear" + '\n' +
                "3.  CopyTo" + '\n' +
                "4.  ContainsValue" + '\n' +
                "5.  ContainsKey" + '\n' +
                "6.  GetHashCode" + '\n' +
                "7.  Remove" + '\n' +
                "8.  GetType" + '\n' +
                "9.  ToString" + '\n' +
                "10. Equals");
            command = Console.ReadLine();
            Console.Clear();
            if (command == "1")
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                slist.Add(key, value);
            }
            else if (command == "2")
            {
                slist.Clear();
            }
            else if (command == "3")
            {
                slist.Values.CopyTo(array, 10);
            }
            else if (command == "4")
            {
                string value = Console.ReadLine();
                Console.WriteLine(slist.ContainsValue(value));
                Console.ReadLine();
            }
            else if (command == "5")
            {
                string key = Console.ReadLine();
                Console.WriteLine(slist.ContainsKey(key));
                Console.ReadLine();
            }
            else if (command == "6")
            {
                Console.WriteLine(slist.GetHashCode());
                Console.ReadLine();
            }
            else if (command == "7")
            {
                string key = Console.ReadLine();
                slist.Remove(key);
            }
            else if (command == "8")
            {
                Console.WriteLine(slist.GetType());
                Console.ReadLine();
            }
            else if (command == "9")
            {
                Console.WriteLine(slist.ToString());
                Console.ReadLine();
            }
            else if (command == "10")
            {
                Console.WriteLine(slist.Equals(slist));
                Console.ReadLine();
            }
            else
            {
                break;
            }
        }
    }
    else if (command == "6")
    {
        BitArray bit = new BitArray(7);
        string[] array = new string[10];
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.  And" + '\n' +
                "2.  Or" + '\n' +
                "3.  CopyTo" + '\n' +
                "4.  Not" + '\n' +
                "5.  Xor" + '\n' +
                "6.  GetHashCode" + '\n' +
                "7.  Set" + '\n' +
                "8.  GetType" + '\n' +
                "9.  RightShift" + '\n' +
                "10. LeftShift");
            command = Console.ReadLine();
            Console.Clear();
            if (command == "1")
            {
                Console.WriteLine(bit.And(bit));
            }
            else if (command == "2")
            {
                Console.WriteLine(bit.Or(bit));
            }
            else if (command == "3")
            {
                bit.CopyTo(array, 10);
            }
            else if (command == "4")
            {
                Console.WriteLine(bit.Not());
            }
            else if (command == "5")
            {
                Console.WriteLine(bit.Xor(bit));
            }
            else if (command == "6")
            {
                Console.WriteLine(bit.GetHashCode());
                Console.ReadLine();
            }
            else if (command == "7")
            {
                int key = Convert.ToInt32(Console.ReadLine());
                bool value = Convert.ToBoolean(Console.ReadLine());
                bit.Set(key, value);
            }
            else if (command == "8")
            {
                Console.WriteLine(bit.GetType());
                Console.ReadLine();
            }
            else if (command == "9")
            {
                int value = Convert.ToInt32(Console.ReadLine());
                bit.RightShift(value);
            }
            else if (command == "10")
            {
                int value = Convert.ToInt32(Console.ReadLine());
                bit.LeftShift(value);
            }
            else
            {
                break;
            }
        }
    }
    else if (command == "7")
    {
        LinkedList<string> llist = new LinkedList<string>();
        string[] array = new string[10];
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.  AddAfter" + '\n' +
                "2.  AddBefore" + '\n' +
                "3.  AddFirst" + '\n' +
                "4.  AddLast" + '\n' +
                "5.  CopyTo" + '\n' +
                "6.  Clear" + '\n' +
                "7.  Remove" + '\n' +
                "8.  GetType" + '\n' +
                "9.  ToString" + '\n' +
                "10. Equals");
            command = Console.ReadLine();
            Console.Clear();
            if (command == "1")
            {
                LinkedListNode<string> current = llist.FindLast("the");
                string value = Console.ReadLine();
                llist.AddAfter(current, value);
            }
            else if (command == "2")
            {
                LinkedListNode<string> current = llist.FindLast("the");
                string value = Console.ReadLine();
                llist.AddBefore(current, value);
            }
            else if (command == "3")
            {
                string value = Console.ReadLine();
                llist.AddFirst(value);
            }
            else if (command == "4")
            {
                string value = Console.ReadLine();
                llist.AddLast(value);
            }
            else if (command == "5")
            {
                llist.CopyTo(array, 10);
            }
            else if (command == "6")
            {
                llist.Clear();
            }
            else if (command == "7")
            {
                string key = Console.ReadLine();
                llist.Remove(key);
            }
            else if (command == "8")
            {
                Console.WriteLine(llist.GetType());
                Console.ReadLine();
            }
            else if (command == "9")
            {
                Console.WriteLine(llist.ToString());
                Console.ReadLine();
            }
            else if (command == "10")
            {
                Console.WriteLine(llist.Equals(llist));
                Console.ReadLine();
            }
            else
            {
                break;
            }
        }
    }
    else if (command == "8")
    {
        SortedSet<string> sset = new SortedSet<string>();
        string[] array = new string[10];
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.  Add" + '\n' +
                "2.  Clear" + '\n' +
                "3.  CopyTo" + '\n' +
                "4.  ContainsValue" + '\n' +
                "5.  Reverse" + '\n' +
                "6.  GetHashCode" + '\n' +
                "7.  Remove" + '\n' +
                "8.  GetType" + '\n' +
                "9.  ToString" + '\n' +
                "10. Equals");
            command = Console.ReadLine();
            Console.Clear();
            if (command == "1")
            {
                string value = Console.ReadLine();
                sset.Add(value);
            }
            else if (command == "2")
            {
                sset.Clear();
            }
            else if (command == "3")
            {
                sset.CopyTo(array, 10);
            }
            else if (command == "4")
            {
                string value = Console.ReadLine();
                Console.WriteLine(sset.Contains(value));
                Console.ReadLine();
            }
            else if (command == "5")
            {
                sset.Reverse();
            }
            else if (command == "6")
            {
                Console.WriteLine(sset.GetHashCode());
                Console.ReadLine();
            }
            else if (command == "7")
            {
                string key = Console.ReadLine();
                sset.Remove(key);
            }
            else if (command == "8")
            {
                Console.WriteLine(sset.GetType());
                Console.ReadLine();
            }
            else if (command == "9")
            {
                Console.WriteLine(sset.ToString());
                Console.ReadLine();
            }
            else if (command == "10")
            {
                Console.WriteLine(sset.Equals(sset));
                Console.ReadLine();
            }
            else
            {
                break;
            }
        }
    }
    else
    {
        break;
    }
}