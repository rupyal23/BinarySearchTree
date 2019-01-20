using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree BT = new BinarySearchTree();
            BT.Add(25);
            BT.Add(18);
            BT.Add(49);
            BT.Add(56);
            BT.Add(23);
            BT.Add(17);
            BT.Add(54);
            BT.Add(48);
            BT.Add(50);

            
            bool result = BT.Search(24);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
