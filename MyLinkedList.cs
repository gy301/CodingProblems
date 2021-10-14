using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodingProblemsCS
{
       public class MyLinkedList
    {
        public CodingProblemsCS.Node Curr = new(0);
        public Node Head;
        public Node Next;
        CodingProblemsCS.Node Last;
        public int Index;
        public MyLinkedList()
        {
            Index = 0;
            //Head = new Node(0);
            //Last = new Node(0);

            //if (Head == null)
            //{

            //    Index = 0;
            //    Curr.val = 0;
            //    Next = Curr.next;
            //    Head = Curr;



            //}
            //else
            //{
            //    Curr = Next;
            //    Curr.val = 0;
            //    Index++;
            //}

        }

        public int Get(int index)
        {
            Node list = Head;
            int ind = 0;
            int val=0;
            while (list != null)
            {
                if (index >= ind)
                {
                    val = list.val;
                    list = list.next;
                    ind++;
                }
                else
                    return val;
            }
            return val;
        }

        public void AddAtHead(int val)
        {
            Node list=new Node(val);
            
            if (Head==null)
            {
                Head = list;
                
            }
            else
            {
                list.next = Head;
                Head = list;
            }
            Index++;
        }

        public void AddAtTail(int val)
        {
            Node list = new Node(val);

            if (Head == null)
            {
                Head = list;
            }
            else
            {
                Curr.next=list;
                Curr=Curr.next;
            }
            Index++;
        }

        public void AddAtIndex(int index, int val)
        {
            Node list = Head;
            int ind = 0;
            
            while (list != null)
            {
                if (ind <= this.Index)
                {
                    if (ind == index)
                    {
                        Node temp = new(val);
                        temp.next = list.next;
                        list.next = temp;
                        break;
                    }
                    else
                    { 
                        list = list.next;
                    }
                    ind++;


                }
               
            }
            Index++;
        }

        public void DeleteAtIndex(int index)
        {

        }

        public void DisplayList()
        {
            Node list = Head;
            string msg = "";
            for (int i=0;i<Index;i++)
            {
                msg = "";
                if (i == 0)
                    msg = "This is the head. ";
                if (i==Index-1)
                    msg = "This is the tail. ";
                msg += "Index:" + i + " = " + list.val;
                Console.WriteLine(msg);
                list = list.next;


            }


        }
    }

   

}
