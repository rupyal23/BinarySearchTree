using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        //Member Variables
        public Node root;


        //Constructor
        public BinarySearchTree()
        {
            root = null;
        }

        //Member Methods
        public void Add(int data)
        {
            Node node = new Node(data);
            if(root == null)
            {
                root = node;
            }
            else
            {
                Node temp = root;
                while(true)
                {
                    if (data < temp.data)
                    {
                        if (temp.left == null)
                        {
                            temp.left = node;
                            return;
                        }
                        else
                        {
                            temp = temp.left;
                        }
                    }
                    else if (data > temp.data)
                    {
                        if (temp.right == null)
                        {
                            temp.right = node;
                            return;
                        }
                        else
                        {
                            temp = temp.right;
                        }
                    }
                }
                
            }
        }

        public void Search(int data)
        {

        }
    }
}
