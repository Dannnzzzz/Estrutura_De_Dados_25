using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace ArvoreBinaria
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; } = null!;
        public int Count { get; set; }
        private void TraversePreOrder(
            BinaryTreeNode<T> node,
            List<BinaryTreeNode<T>> result
            )
        {
            if (node != null)
            {
                result.Add(node);
                TraversePreOrder(node.left, result);
                TraversePreOrder(node.right, result);
            }
        }
        private void TraverseInOrder(
            BinaryTreeNode<T> node,
            List<BinaryTreeNode<T>> result
        )
        {
            if (node != null)
            {
                TraverseInOrder(node.left, result);
                result.Add(node);
                TraverseInOrder(node.right, result);
            }
        }
        private void TraversePostOrder(
            BinaryTreeNode<T> node,
            List<BinaryTreeNode<T>> result
        )
        {
            TraversePostOrder(node.left, result);
            TraversePostOrder(node.right, result);
            result.Add(node);
        }

        public List<BinaryTreeNode<T>> Traverse(TraversalEnum mode)
        {
            List<BinaryTreeNode<T>> nodes =
                new List<BinaryTreeNode<T>>();

            switch (mode)
            {
                case TraversalEnum.PREORDER:
                    TraversePreOrder(Root, nodes);
                    break;
                case TraversalEnum.INORDER:
                    TraverseInOrder(Root, nodes);
                    break;
                case TraversalEnum.POSTORDER:
                    TraversePostOrder(Root, nodes);        
            }    
        }
    }
}