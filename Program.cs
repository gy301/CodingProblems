using System;

namespace CodingProblemsCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine(Solution.Divide(7,-3));


            
             //Your MyLinkedList object will be instantiated and called as such:
             MyLinkedList obj = new MyLinkedList();
            //Console.WriteLine(obj.Head.val);

            int val = 0;
            int index = 2;
            obj.AddAtHead(2);
            Console.WriteLine(obj.Head.val + ";" + obj.Index);
            obj.AddAtHead(6);
            Console.WriteLine(obj.Head.val + ";" + obj.Index);
            obj.AddAtHead(1);
            Console.WriteLine(obj.Head.val + ";" + obj.Index);
            obj.AddAtIndex(2, 999);
            Console.WriteLine(obj.Head.val + ";" + obj.Index);
            obj.AddAtHead(9);
            Console.WriteLine(obj.Head.val + ";" + obj.Index);
            obj.AddAtHead(100000000);
            Console.WriteLine(obj.Head.val + ";" + obj.Index);
            obj.DisplayList();


            int param_1 = obj.Get(index);
            Console.WriteLine(param_1);
             obj.AddAtHead(val);

             //obj.AddAtTail(val);
             //obj.AddAtIndex(index,val);
            // obj.DeleteAtIndex(index);
             




        }
    }


   


}
