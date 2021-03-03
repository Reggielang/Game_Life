﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_数组
{
    class Array1
    {
        private int[] data; //数组的长度
        private int N; //数组的元素个数

        public Array1(int capacity)
        {
            data = new int[capacity];
            N = 0;
        }

        //public Array1() : this(10) { }
        public Array1()
        {
            data = new int[10];
            N = 0;
        }


        public int Capacity
        {
            get { return data.Length; }

        }

        public int Count
        {
            get { return N;}
        }

        public bool IsEmpty
        {
            get { return N == 0; }
        }

        //指定位置的添加
        public void Add(int index, int e)
        {
            if (index < 0 || index > N)
            {
                throw new ArgumentException("数组索引越界");
            }

            if (N==data.Length)
            {
                ResetCapacity(2 * data.Length);
            }
            for (int i =N-1; i >=index ; i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = e;
            N++;
        }
        //从数组容量的最后开始添加
        public void AddLast(int e)
        {
            Add(N, e);
        }
        ////从数组容量的开始开始添加
        public void AddFirst(int e)
        {
            Add(0, e);
        }


        //查找数组元素
        public int Get(int index)
        {
            if (index < 0||index >= N)
            {

                throw new ArgumentException("数组索引越界");
            }
            return data[index];
        }
        public int GetFirst()
        {
            return Get(0);
        }

        public int GetLast()
        {
            return Get(N - 1);
        }

        //修改数组元素
        public void Set(int index, int newE)
        {
            if (index<0||index >=N)
            {
                throw new ArgumentException("数组索引越界");
            }
            data[index] = newE;
        }

        //包含数组元素
        public bool Contains(int e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i]==e)
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(int e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i] ==e)
                {
                    return i;
                }
            }
            return -1;
        }

        //删除数组元素 --实际上就是把删除元素的周围数据往前平移，然后再让最后位置的元素等于0
        public int RemoveAt(int index)
        {
            if (index<0||index>=N)
            {
                throw new ArgumentException("索引超出数组界限");
            }

            int del = data[index];

            for (int i = index + 1; i <= N-1; i++)
            {
                data[i - 1] = data[i];
            }

            N--;
            data[N] = default(int);

            if (N==data.Length/4)
            {
                ResetCapacity(data.Length / 2);
            }

            return del;
          }

        public int RemoveFirst()
        {
            return RemoveAt(0);
        }
        public int RemoveLast()
        {
            return RemoveAt(N - 1);
        }
        public void Remove(int e)
        {
            int index = IndexOf(e);
            if (index!=-1)
            {
                RemoveAt(index);
            }
        }

        private void ResetCapacity(int newCapacity)
            {
            int[] newData = new int[newCapacity];
            for (int i = 0; i < N; i++)
            {
                newData[i] = data[i];
            }
            data = newData;
            } 


        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append(string.Format("Array1:  count={0} capacity={1}\n", N, data.Length));
            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append(data[i]);
                if (i!=N-1)
                {
                    res.Append(", ");
                }
            }
            res.Append("]");
            return res.ToString();
        }


    }
}
