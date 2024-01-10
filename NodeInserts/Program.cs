using NodeClass;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Node<int> node= new Node<int>(4,new Node<int>(5, new Node<int>(6,new Node<int>(4, new Node<int>(4, new Node<int>(4, new Node<int>(22, new Node<int>(3))))))));
            Console.WriteLine(Func1(node, 4));
        }
    }
}