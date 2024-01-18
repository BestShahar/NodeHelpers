using NodeClass;
using NodeInserts.Models;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using NodeInserts.Models;

namespace NodeInserts
{
    internal class Program
    {
        public static int IsBigger(Node<int> lis1, Node<int> lis2)
        {
            if (lis1 == null && lis2 == null)
            {
                return 0;
            }
            else if (lis1.GetValue() > lis2.GetValue() || lis2 == null)
            {
                return 1;
            }
            else if (lis1.GetValue() < lis2.GetValue()|| lis1==null)
            {
                return 2;
            }
            else
            {
                return IsBigger(lis1.GetNext(), lis2.GetNext());
            }
        }

        public static void ReturnLastOfSeq(Node<int> lis1, Node<int> lis2)
        {
            if (lis1 != null && lis2 != null)
            {

            }
        }

        public static int Func1(Node<int> lst, int k)
        {
            int countk = 0;
            while (lst != null&&lst.GetNext()!=null)
            {
                if (lst.GetValue() == k && lst.GetNext().GetValue() != k)
                {
                    countk++;
                }
                else if (lst.GetValue() == k && lst.GetNext().GetValue() == k)
                {
                    countk=1;
                }
                lst = lst.GetNext();
             
            }
            return countk;
        }
        public static bool IsThere(Node<ShabatRecievers> node, int day, int month, int year)
        {
            Node<ShabatRecievers> p = node;
            while(p != null)
            {
                if(p.GetValue().GetDay()==day&& p.GetValue().GetMonth() == month&& p.GetValue().GetYear()==year)
                {
                    return true;
                }
                p=p.GetNext();
            }
            return false;

        }
        public static Node<ShabatRecievers> Sick(string name, Node<ShabatRecievers> node)
        {
            if (node == null)
                return null;
            Node<ShabatRecievers> p = node;

            while (p != null)
            {
                if (p.GetValue().GetParent1() == name)
                    NodeHelper.Delete(p, p.GetValue());        
                if (p.GetValue().GetParent2() == name)
                    NodeHelper.Delete(p, p.GetValue());
                p = p.GetNext();
            }
            return node;


        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            Node<int> node= new Node<int>(4,new Node<int>(5, new Node<int>(6,new Node<int>(4, new Node<int>(4, new Node<int>(4, new Node<int>(22, new Node<int>(3))))))));
            Console.WriteLine(Func1(node, 4));

            Node<ShabatRecievers> shabatShalom = new Node<ShabatRecievers>(new ShabatRecievers("Shiri","Shira",18,1,2024));
            Node<ShabatRecievers> nextShabat = new Node<ShabatRecievers>(new ShabatRecievers("Ofek", "Aviv", 25, 1, 2024));
            shabatShalom.SetNext(nextShabat);

            ShabatRecievers sh = shabatShalom.GetValue();
            string p1 = sh.GetParent1();



        }
    }
}