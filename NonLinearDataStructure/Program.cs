namespace NonLinearDataStructure
{
    class Node
    {
        public int Data;
        public Node Left;
        public Node Right;
        public void Display()
        {
            Console.WriteLine(Data +" =>");
        }
    }
    class BSTree
    {
        public Node root;
        public BSTree()
        {
            root = null;
        }

        public void Insert(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            if (root == null)
            {
                root = new Node();
                root = newNode;
                Console.WriteLine("Root Node has beed addded");
            }
            else
            {
                Node ptr = root;
                Node parent;
                while (true)
                {
                    parent = ptr;
                    if (data < ptr.Data)
                    {
                        parent.Left = newNode;
                        Console.WriteLine("Added on the left side");
                        break;
                    }

                
                else
                {
                    ptr = ptr.Right;
                    if (ptr == null)
                    {
                        parent.Right = newNode;
                        Console.WriteLine("Added on the right side");
                        break;
                    }
                } }
            }
        }
        public void InOrder(Node parent)
        {
            if( parent!=null)

            {
               
                InOrder(parent.Left);
                Console.WriteLine(parent.Data);
                InOrder(parent.Right);
            }
        }


        public void PreOrder(Node parent)
        {
            if (parent != null)

            {
                Console.WriteLine(parent.Data);
                PreOrder(parent.Left);
               
                PreOrder(parent.Right);
            }
        }

        public void PostOrder(Node parent)
        {
            if (parent != null)

            {
               
                PostOrder(parent.Left);

                PostOrder(parent.Right);
                Console.WriteLine(parent.Data);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BSTree bst = new BSTree();
            bst.Insert(10);
            bst.Insert(12);
            bst.Insert(20);
            bst.Insert(30);
            bst.Insert(4);
            bst.PreOrder(bst.root);
            bst.InOrder(bst.root);
            bst.PostOrder(bst.root);
        }
    }
}
