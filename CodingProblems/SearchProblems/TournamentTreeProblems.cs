using System;
using System.Collections.Generic;
using System.Text;

namespace SearchProblems
{
    public class TournamentTreeProblems
    {
        private static int comparision = 0;

        public static int FindSecondSmallestInTournamentTree(int[] A)
        {
            int secondLargest = int.MaxValue;
            var treeRoot = CreateTournamentTree(A);
            TraverseTournamentTreeToGetSecondSmallest(treeRoot, A, ref secondLargest);
            Console.WriteLine($"Comparision: {comparision}");
            return secondLargest;
        }

        private static void TraverseTournamentTreeToGetSecondSmallest(TreeNode root, int[] A, ref int result)
        {
            if (root == null || root.LeftChild == null || root.RightChild == null) return;
            if (root.Index == root.LeftChild.Index)
            {
                var rightChild = A[root.RightChild.Index];
                if (result > rightChild) result = rightChild;
                TraverseTournamentTreeToGetSecondSmallest(root.LeftChild, A, ref result);
            }
            else
            {
                var leftChild = A[root.LeftChild.Index];
                if (result > leftChild) result = leftChild;
                TraverseTournamentTreeToGetSecondSmallest(root.RightChild, A, ref result);
            }
            comparision += 3;
        }

        private static TreeNode CreateTournamentTree(int[] A)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            TreeNode root = null;
            var length = A.Length;

            // Add first round of winners to queue
            for (int i = 0; i < length; i+= 2)
            {
                var treeNode1 = CreateNode(i);
                TreeNode treeNode2 = null;
                if (i + 1 < length)
                {
                    treeNode2 = CreateNode(i + 1);
                    root = (A[i] < A[i + 1]) ?
                        CreateNode(i, treeNode1, treeNode2)
                        : CreateNode(i + 1, treeNode1, treeNode2);
                    queue.Enqueue(root);
                    comparision += 2;
                }
                else
                {
                    queue.Enqueue(treeNode1);
                    comparision += 1;
                }
            }

            // Create a complete tournament tree
            var qLen = queue.Count;
            while (qLen != 1)
            {
                var last = (qLen % 2 == 0) ? qLen - 1 : qLen - 2;

                for (int i = 0; i < last; i+=2)
                {
                    var node1 = queue.Dequeue();
                    var node2 = queue.Dequeue();
                    root = (A[node1.Index] < A[node2.Index]) ? CreateNode(node1.Index, node1, node2) : CreateNode(node2.Index, node1, node2);
                    queue.Enqueue(root);
                    comparision += 1;
                }
                if (qLen % 2 == 1) queue.Enqueue(queue.Dequeue());
                comparision += 1;
                qLen = queue.Count;
            }

            return root;
        }

        private static TreeNode CreateNode(int index, TreeNode leftChild = null, TreeNode rightChild = null)
        {
            return new TreeNode()
            {
                Index = index,
                LeftChild = leftChild,
                RightChild = rightChild
            };
        }
    }
}
