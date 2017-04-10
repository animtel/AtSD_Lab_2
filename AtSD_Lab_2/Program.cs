using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtSD_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            List<int> true_list = new List<int>();

            Random r = new Random();

            //for (int i = 0; i < 4; i++)
            //{
            //    int randomed = r.Next(5);
            //    list.Add(randomed);
            //    true_list.Add(randomed);
            //}

            //Console.WriteLine("Danils list: ");
            //list.PrintList();
            //list.Append(99);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.ExchangeElements(3, 0);
            



            //list.PrintALLDontPareElementsOfList(8, list.head);
            //list.SortLinkedList(list.head, 8);
            //list.RemoveNode(3);
            //list.Rem(list.head, 4);
            //list.AddDataBeforeValue(4, 5);
            //list.RemoveAllPareElementsOurList();
            //list.IsEmpty();
            list.PrintList();
            //Console.WriteLine(list[7]);
            //true_list.ForEach((el) => Console.Write(el.ToString() + "-->"));
        }
    }


    class LinkedList
    {
        public class Node
        {
            public int Data;
            public Node Next;

            public Node()
            {

            }
            public Node(int data)
            {
                Data = data;
            }
            public Node(int data, Node next)
            {
                Data = data;
                Next = next;
            }
        }

        public Node head;

        //******************************************************************************************************************

        //Добавление в начало

        public void Add(int data)
        {
            Node _n = new Node(data);
            if (head == null)
            {
                head = _n;
                return;
            }
            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = _n;
        }

        //Выведение списка

        public void PrintList()
        {
            Node temp = head;

            while (temp != null)
            {
                Console.Write(temp.Data.ToString() + "-->");
                temp = temp.Next;

            }
            Console.Write("NULL");
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));
        }

        //добавление а конец

        public void Append(int v) =>
            head = new Node(v, head);

        //Количесвто различных чисел в списке

        public int NumberOfDifferenNumbersInList()
        {
            Node temp = head;
            int result = 0;
            int prev = 0;

            
            return result;
        }

        //обмен двух элементов списка местами

        public void ExchangeElements(int IndexOfElementFirst, int IndexOfElementSecond)
        {

            Node temp = head;
            int first = 0;
            int second = 0;
            int prevFirst = 0;
            int prevSecond = 0;

            if (IndexOfElementFirst >= IndexOfElementSecond)
            {
                first = IndexOfElementSecond;
                second = IndexOfElementFirst;
            }
            else
            {
                first = IndexOfElementFirst;
                second = IndexOfElementSecond;
            }


            for (int i = 0; i <= second; i++)
            {
                if(i == first)
                {
                    prevFirst = temp.Data;
                }
                if(i == second)
                {
                    prevSecond = temp.Data;
                    temp.Data = prevFirst;
                    temp = head;
                    break;
                }
                temp = temp.Next;
            }

            for (int i = 0; i <= first; i++)
            {
                if(i == first)
                {
                    temp.Data = prevSecond;
                }
                temp = temp.Next;
            }
            
        }

        //Добавление узла перед узлом с заданным значением.

        public void AddDataBeforeValue(int data, int valueOurNumberBeforeWhoWeWantToPutOurData)
        {
            Node temp = head;
            Node _n = new Node(data);
            while (temp.Next.Data != valueOurNumberBeforeWhoWeWantToPutOurData)
            {
                temp = temp.Next;
            }
            if (temp.Next.Data == valueOurNumberBeforeWhoWeWantToPutOurData)
            {
                _n.Next = temp.Next;
                temp.Next = _n;
            }
            else
            {
                Console.WriteLine("Такого числа не существует");
            }
        }

        //Рекурсивное удаление н-го элемента из списка

        public void Rem(Node head, int index, Node prev = null, int count = 0)
        {

            if (head.Next != null)
            {

                if (index == count)
                {
                    prev.Next = head.Next;
                    head = null;
                    Console.WriteLine("Заработало! =)");
                }
                else
                {
                    Rem(head.Next, index, prev = head, count + 1);
                }
            }

        }

        //Удаление Узла по индексу

        public bool RemoveNode(int nodeNumber)
        {
            bool removed = false;

            Node current = head;
            Node prev = null;

            int index = 0;
            while (index < nodeNumber && current != null)
            {
                prev = current;
                current = current.Next;

                index++;
            }
            if (current != null)
            {
                if (prev == null)
                {
                    head = current.Next;
                }
                else
                {
                    prev.Next = current.Next;
                    current = null;
                }

                current = null;
                removed = true;
            }

            return removed;
        }

        //Сдклать список пустым.

        public void IsEmpty() => head = null;


        //Удаление всех парных элементов списка:

        public void RemoveOfLastElement()
        {
            Node temp = head;
            while (temp.Next != null)
            {
                if (temp.Next.Next == null)
                {
                    temp.Next = null;
                    break;
                }
                temp = temp.Next;
            }
        }

        public void RemoveAllPareElementsOurList()
        {
            Node _n = new Node(0);
            Node temp = head;
            Node prev = null;
            int count = 1;

            while (temp != null)
            {
                if (temp.Next.Next == null)
                {
                    temp.Next = null;
                    break;
                }

                if (count % 2 == 0)
                {
                    prev.Next = temp.Next;
                }

                count++;
                prev = temp;
                temp = temp.Next;
            }
        }

        //Рекурсивный метод выведения всех непарных элементов списка

        public int LengthOfList()
        {
            Node temp = head;
            int Length = 0;
            while (temp.Next != null)
            {

                Length++;
                temp = temp.Next;

            }
            return Length;
        }


        public void PrintALLDontPareElementsOfList(int counter, Node head)
        {


            if (counter != 0)
            {
                Console.Write(head.Data.ToString() + "-->");
                PrintALLDontPareElementsOfList(counter - 2, head.Next.Next);
            }
            else
            {
                Console.WriteLine("NULL");
            }
        }

        //Сортировка списка

        public Node SortLinkedList(Node head, int count)
        {
            // Basic Algorithm Steps
            //1. Find Min Node
            //2. Remove Min Node and attach it to new Sorted linked list
            //3. Repeat "count" number of times
            Node temp = head;
            Node prev = temp;
            Node min = temp;
            Node minPrev = min;
            Node _sortedListHead = null;
            Node _sortedListTail = _sortedListHead;
            for (int i = 0; i < count; i++)
            {
                temp = head;
                min = temp;
                minPrev = min;
                //Find min Node
                while (temp != null)
                {
                    if (temp.Data < min.Data)
                    {
                        min = temp;
                        minPrev = prev;
                    }
                    prev = temp;
                    temp = temp.Next;
                }
                // Remove min Node 
                if (min == head)
                {
                    head = head.Next;
                }
                else if (min.Next == null) //if tail is min node
                {
                    minPrev.Next = null;
                }
                else
                {
                    minPrev.Next = minPrev.Next.Next;
                }
                //Attach min Node to the new sorted linked list
                if (_sortedListHead != null)
                {
                    _sortedListTail.Next = min;
                    _sortedListTail = _sortedListTail.Next;
                }
                else
                {
                    _sortedListHead = min;
                    _sortedListTail = _sortedListHead;
                }
            }
            return _sortedListHead;
        }

        //Індексатор з двома параметрами, що дозволяє знайти суму значень елементів,
        //розташованих між елементами із заданими номерами;

        public int this[int a, int b = -1]
        {
            get
            {
                if (b == -1)
                {
                    Node tempNode = head;
                    for (int i = 0; i < a; i++)
                    {
                        tempNode = tempNode.Next;
                    }
                    return tempNode.Data;
                }
                else
                {
                    //chto-to
                    Node tempNode = head;
                    int result = 0;
                    for (int i = 0; i < a; i++)
                    {
                        if (i + 1 == a)
                        {
                            for (int j = 0; j <= b; j++)
                            {
                                result += tempNode.Next.Data;
                            }
                            break;
                        }
                        tempNode = tempNode.Next;

                    }
                    return result;
                }
            }
        }




    }
}
