
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHeapNodi
{
    internal class HeapNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public HeapNode<T> Parent { get; set; }
        public HeapNode<T> SxSon { get; set; }
        public HeapNode<T> DxSon { get; set; }

        public HeapNode(T value)
        {
            Value = value;
            Parent = null;
            SxSon = null;
            DxSon = null;
        }
    }
}
