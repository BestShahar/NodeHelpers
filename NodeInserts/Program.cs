using NodeClass;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace NodeInserts
{
    internal class Program
    {
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