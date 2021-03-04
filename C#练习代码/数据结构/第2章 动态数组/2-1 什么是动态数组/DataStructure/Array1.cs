using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Array1
    {
        private int[] data;
        private int N;

        public Array1(int capacity)
        {
            data = new int[capacity];
            N = 0;
        }

        public Array1() : this(10) { }

        public int Capacity
        {
            get { return data.Length; }
        }

        public int Count
        {
            get { return N; }
        }

        public bool IsEmpty
        {
            get { return N == 0; }
        }
    }
}
