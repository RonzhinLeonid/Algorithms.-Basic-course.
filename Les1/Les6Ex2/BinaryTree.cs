using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les6Ex2
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        private BinaryTree<T> parent;
        private BinaryTree<T> left;
        private BinaryTree<T> right;
        private T val;

        public BinaryTree(T val, BinaryTree<T> parent)
        {
            this.val = val;
            this.parent = parent;
        }
        public void add(T val)
        {
            if (val.CompareTo(this.val) < 0)
            {
                if (this.left == null)
                {
                    this.left = new BinaryTree<T>(val, this);
                }
                else if (this.left != null)
                    this.left.add(val);
            }
            else
            {
                if (this.right == null)
                {
                    this.right = new BinaryTree<T>(val, this);
                }
                else if (this.right != null)
                    this.right.add(val);
            }
        }
        private void _printTree(BinaryTree<T> node)
        {
            if (node != null)
            {
                Console.Write(node);
                if (node.left != null || node.right != null)
                { 
                    Console.Write("(");
                    if (node.left != null)
                        _printTree(node.left);
                    else
                        Console.Write("NULL");
                    Console.Write(",");
                    if (node.right != null)
                        _printTree(node.right);
                    else
                        Console.Write("NULL");
                    Console.Write(")");
                }
            }
        }
        public void printTree()
        {
            _printTree(this);
            Console.WriteLine();
        }
        private void _preOrderTravers(BinaryTree<T> node)
        {
            if (node != null)
            {
                Console.Write(node + " ");
                _preOrderTravers(node.left);
                _preOrderTravers(node.right);
            }
        }
        public void preOrderTravers()
        {
            _preOrderTravers(this);
            Console.WriteLine();
        }

        private void _inOrderTravers(BinaryTree<T> node)
        {
            if (node != null)
            {
                _inOrderTravers(node.left);
                Console.Write(node + " ");
                _inOrderTravers(node.right);
            }
        }
        public void inOrderTravers()
        {
            _inOrderTravers(this);
            Console.WriteLine();
        }

        private void _postOrderTravers(BinaryTree<T> node)
        {
            if (node != null)
            {
                _postOrderTravers(node.left);
                _postOrderTravers(node.right);
                Console.Write(node + " ");
            }
        }
        public void postOrderTravers()
        {
            _postOrderTravers(this);
            Console.WriteLine();
        }

        private BinaryTree<T> _search(BinaryTree<T> tree, T val)
        {
            if (tree == null) return null;
            switch (val.CompareTo(tree.val))
            {
                case 1: return _search(tree.right, val);
                case -1: return _search(tree.left, val);
                case 0: return tree;
                default: return null;
            }
        }

        public BinaryTree<T> search(T val)
        {
            return _search(this, val);
        }

        public override string ToString()
        {
            return val.ToString();
        }

    }
}
