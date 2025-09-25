using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ArvoreBinaria
{
    public class BinaryTreeNode<T> : TreeNode<T>
    {
        /*public BinaryTreeNode() =>
        Children = new List<TreeNode<T>>(){
        };
    */
        public BinaryTreeNode()
        {
            Children = new List<TreeNode<T>>();
            Children.Add(null!);
            Children.Add(null!);
        }
        public BinaryTreeNode<T> left
        {
            get { return (BinaryTreeNode<T>)Children[1]; }
            set { Children[1] = value; }
        }
        public BinaryTreeNode<T> right
        {
            get { return (BinaryTreeNode<T>)Children[1]; }
            set { Children[1] = value; }
        }
    }
}