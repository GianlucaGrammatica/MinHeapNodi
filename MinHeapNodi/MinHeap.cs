using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHeapNodi
{
    internal class MinHeap<T> where T : IComparable<T>
    {
        public HeapNode<T> Root { get; private set; }
        public int Count { get; private set; }

        public MinHeap()
        {
            Count = 0;
            Root = null;
        }

        public void Insert(T value)
        {
            HeapNode<T> newNode = new HeapNode<T>(value);

            if(Root ==  null)
            {
                Root = newNode;
            }
            else
            {
                HeapNode<T> parent = FindNextPosition();
                newNode.Parent = parent;

                if(parent.SxSon == null)
                {
                    parent.SxSon = newNode;
                }
                else
                {
                    parent.DxSon = newNode;
                }
                HeapifyUp(newNode);
            }
            
            Count++;
        }

        private void HeapifyUp(HeapNode<T> node)
        {
            while (node.Parent != null && node.Value.CompareTo(node.Parent.Value) < 0)
            {
                Swap(node, node.Parent);
                node = node.Parent;
            }
        }

        private HeapNode<T> FindNextPosition()
        {
            int nextIndex = Count + 1;
            string binaryPath = Convert.ToString(nextIndex, 2).Substring(1);

            var current = Root;
            for (int i = 0; i < binaryPath.Length - 1; i++)
            {
                current = binaryPath[i] == '0' ? current.SxSon : current.DxSon;
            }

            return current;
        }

        private void Swap(HeapNode<T> node1, HeapNode<T> node2)
        {
            T temp = node1.Value;
            node1.Value = node2.Value;
            node2.Value = temp;
        }
    }
}
