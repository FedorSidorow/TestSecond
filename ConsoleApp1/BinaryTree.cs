using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BinaryTree
    {
        public int[] value = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
        int Lol = 0;

        public class TreeNode
        {
            public int Num; // число 
            public TreeNode left; // левое поддерево
            public TreeNode right; // правое поддерево
        }
        public TreeNode root;

        public void ShowTree()// Прямой обход дерева
        {
            ShowTree(root);
        }
        private void ShowTree(TreeNode node)
        {
            if (node != null)
            {
                Console.WriteLine("{0}", node.Num);
                value[Lol] = node.Num;
                Lol++;
                ShowTree(node.left);
                ShowTree(node.right);
            }
        }

        public void Add(int newNum)// Добавление
        {
            TreeNode new_node = new TreeNode();
            new_node.Num = newNum;

            if (root == null)
            {
                root = new_node;
            }
            else
            {
                root = RecursiveInsert(root, new_node);
            }
        }

        private TreeNode RecursiveInsert(TreeNode current, TreeNode n)
        {
            if (current == null)
            {
                current = n;
                return current;
            }
            else if (n.Num <= current.Num)
            {
                current.left = RecursiveInsert(current.left, n);
                current = Balance_Tree(current);
            }
            else if (n.Num > current.Num)
            {
                current.right = RecursiveInsert(current.right, n);
                current = Balance_Tree(current);
            }
            return current;
        }

        private TreeNode Balance_Tree(TreeNode current)  // балансировка
        {
            int b_factor = Balance_Factor(current);
            if (b_factor > 1)
            {
                if (Balance_Factor(current.left) > 0)
                {
                    current = RotateLL(current);
                }
                else
                {
                    current = RotateLR(current);
                }
            }
            else if (b_factor < -1)
            {
                if (Balance_Factor(current.right) > 0)
                {
                    current = RotateRL(current);
                }
                else
                {
                    current = RotateRR(current);
                }
            }
            return current;
        }

        private int Balance_Factor(TreeNode current)
        {
            int l = GetHeight(current.left);
            int r = GetHeight(current.right);
            int b_factor = l - r;
            return b_factor;
        }

        private int Max(int l, int r)
        {
            return l > r ? l : r;
        }

        private int GetHeight(TreeNode current)// Получение "веса"
        {
            int height = 0;
            if (current != null)
            {
                int l = GetHeight(current.left);
                int r = GetHeight(current.right);
                int m = Max(l, r);
                height = m + 1;
            }
            return height;
        }

        private TreeNode RotateRR(TreeNode parent)
        {
            TreeNode pivot = parent.right;
            parent.right = pivot.left;
            pivot.left = parent;
            return pivot;
        }
        private TreeNode RotateLL(TreeNode parent)
        {
            TreeNode pivot = parent.left;
            parent.left = pivot.right;
            pivot.right = parent;
            return pivot;
        }
        private TreeNode RotateLR(TreeNode parent)
        {
            TreeNode pivot = parent.left;
            parent.left = RotateRR(pivot);
            return RotateLL(parent);
        }
        private TreeNode RotateRL(TreeNode parent)
        {
            TreeNode pivot = parent.right;
            parent.right = RotateLL(pivot);
            return RotateRR(parent);
        }
    }
}
