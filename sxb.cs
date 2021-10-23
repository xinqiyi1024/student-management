using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020002309_方泽楠_学生管理
{
    struct xs {
        public int xh;
        public String name;
    }
    class sxb
    {
        private int maxSize;
        private int[] elem;
        private int len;

        public sxb(int[] elem)
        {
            this.elem = elem;
            this.maxSize = elem.Length;
            len = elem.Length;
        }

        public sxb(int size)
        {
            this.maxSize = size;
            this.elem = new int[size];
            len = 0;
        }

        /**
         * 常用操作：求线性表长度
         */
        public int getLenth()
        {
            return len;
        }

        /**
         * 常用操作：清空线性表
         */
        public void empty()
        {
            this.len = 0;
            elem = null;
        }

        /**
         * 常用操作：判断线性表是否满了
         */
        public bool isFull()
        {
            return this.len == maxSize ? true : false;
        }

        /**
         * 常用操作：判断线性表是否为空
         */
        public bool isEmpty()
        {
            return this.len == 0 ? true : false;
        }

        /**
         * 常用操作：在顺序表第i个位置插入元素
         */
        public void insert(int i, int a)
        {
            if (isFull())
            {
                Console.WriteLine("表已满");
            }
            else {
                int[] newArray = new int[maxSize];
            for (int j = 1; j < maxSize; j++)
            {
                if (j < i)
                {
                    newArray[j] = elem[j];
                }
                else if (j == i)
                {
                    newArray[j] = a;
                }
                else if (j > i)
                {
                    newArray[j] = elem[j - 1];
                }
            }
            elem = newArray;
            len++;
            }

        }

        /**
         * 常用操作：删除指定位置（第i个）的元素
         */
        public void del(int i)
        {
            if (getLenth() > i)
            {
                int[] newArray = new int[elem.Length - 1];
                for (int j = 0; j < newArray.Length; j++)
                {
                    if (j < i)
                    {
                        newArray[j] = elem[j];
                    }
                    else if (j >= i)
                    {
                        newArray[j] = elem[j + 1];
                    }
                }
                elem = newArray;
                len--;
            }
        }

        /**
         * 常用操作：得到第i个元素的值
         */
        public int findI(int i)
        {
            bool b = i < 0 || i > len - 1;
            if (b)
            {
                Console.WriteLine("索引错误");
            }
            return b ? 0 : elem[i];
        }

        /**
         * 常用操作：得到值为ktn的索引
         */
        public String findKtn(int i)
        {
            String s = "";
            for (int j = 0; j < elem.Length; j++)
            {
                if (i == elem[j])
                {
                    s += j + " ";
                }
            }
            return s;
        }

        /**
         * 常用操作：遍历线性表
         */
        public void print()
        {
            for (int j = 0; j < len; j++)
            {
                Console.WriteLine(elem[j] + " ");
            }
        }

        /**
         * 将线性表b1连接到表后
         */
        public void connect(sxb b1)
        {
            int[] newArr = new int[elem.Length + b1.len];
            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < elem.Length)
                {
                    newArr[i] = elem[i];
                }
                else
                {
                    newArr[i] = b1.findI(i - elem.Length);
                }
            }
            elem = newArr;
            maxSize += b1.maxSize;
            len += b1.len;
        }

        /**
         * 删除线性表中所有值为e的元素
         */
        public void delE(int e)
        {
            
        }

        public void setElem(int[] elem)
        {
            this.elem = elem;
            len = elem.Length;
        }
    }
}
